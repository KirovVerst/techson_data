using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageCropComponent;

using ImageConverterComponent;
using ImageGrayScaleComponent;
using BlackWhiteImageComponent;
using ImageFormatComponent;
using TechsonAPIComponent;
using ImageResizeComponent;

namespace TechsonData
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                digitsComboBox.Items.Add(i);
            }
            try
            {
                User[] result = TechsonAPI.UsersList();
                foreach (User u in result)
                {
                    usersComboBox.Items.Add(u);
                }
                usersComboBox.DisplayMember = "firstName";
                usersComboBox.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }            
        }

        private bool isImageChosen = false;
        private bool isImageUpdated = false;

        private void chooseImage(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            fdlg.FilterIndex = 1;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap newImage = new Bitmap(fdlg.FileName);
                pictureBox.Image = newImage;
                pictureBox.ImageLocation = fdlg.FileName;
                isImageChosen = true;
                isImageUpdated = true;
            }
            resetLabels();
        }

        private Tuple<bool, string> CheckInputData(){

            if (pictureBox.Image == null)
            {
                return new Tuple<bool, string>(false, "Выберите изображение ...");
            }

            if (isImageUpdated == false)
            {
                return new Tuple<bool, string>(false, "Это изображение уже было загружено");
            }


            if (usersComboBox.SelectedItem == null)
            {
                return new Tuple<bool, string>(false, "Выберите имя пользователя ...");
            }

            if (digitsComboBox.SelectedItem == null)
            {
                return new Tuple<bool, string>(false, "Выберите цифру ...");
            }
            return new Tuple<bool, string>(true, "");
        }

        private void resetLabels()
        {
            segmentLabel.Visible = false;
            nUploadedImagesLabel.Visible = false;
            uploadTitleLabel.Visible = false;
            nUploadedImagesLabel.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetLabels();

            Tuple<bool, string> resultOfChecking = CheckInputData();

            if (!resultOfChecking.Item1)
            {
                MessageBox.Show(resultOfChecking.Item2, "Error");
                return;
            }

            User user = (User)usersComboBox.SelectedItem;
            string imageName = Path.GetFileNameWithoutExtension(pictureBox.ImageLocation);
            string label = digitsComboBox.SelectedItem.ToString();

            Image[] images = CropImage();
            string nImages = images.Length.ToString();

            nUploadedImagesLabel.Visible = true;
            uploadTitleLabel.Visible = true;

            for (int i = 0; i < images.Length; i++)
            {
                Tuple<int, string> result;
                try
                {
                    int[] pixels = TransfomImage(images[i]);
                    string data = string.Join(",", pixels);

                    result = TechsonAPI.UploadImage(images[i], String.Concat(imageName,"-") + i.ToString(), user.id.ToString(), label, data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }
                if (result.Item1 == 200)
                {
                    nUploadedImagesLabel.Text = String.Concat((i + 1).ToString(), " из ", nImages);
                }
                else
                {
                    MessageBox.Show(result.Item2, "Error");
                    return;
                }

            }

            nUploadedImagesLabel.ForeColor = Color.Green;

        }
        private Image[] CropImage()
        {
            segmentLabel.ForeColor = Color.Black;
            segmentLabel.Text = "Идет сегментирование ...";
            segmentLabel.Visible = true;
            
            Image src = pictureBox.Image;
            ImageCrop cropper = new ImageCrop(src);
            int m = (int)mNumericBox.Value;
            int n = (int)nNumericBox.Value;
            
            Image[] images = cropper.Crop(m, n);

            segmentLabel.ForeColor = Color.Green;
            segmentLabel.Text = "Сегментирование завершено";

            return images;
        }
        
        private int[] TransfomImage(Image image)
        {
            using (ImageFormatComponent.ImageFormat imgConverter = new ImageFormatComponent.ImageFormat(image))
            {
                image = imgConverter.SetPngFormat();
                using (ImageGrayScale imgGrayScale = new ImageGrayScale(image))
                {
                    image = imgGrayScale.Transform();
                    using (BlackWhiteImage imgBlackWhite = new BlackWhiteImage(image))
                    {
                        image = imgBlackWhite.Transform();
                        using (ImageResize imgResize = new ImageResize(image))
                        {
                            image = imgResize.Resize(50, 50);
                            
                            using (ImageToByte imgToByte = new ImageToByte(image))
                            {
                                return imgToByte.Transform();
                            }
                        }
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
