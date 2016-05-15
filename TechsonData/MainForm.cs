using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using TechsonAPIComponent;

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            successLabel.Visible = false;

            
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Выберите изображение ...", "Error");
                return;
            }

            if (isImageUpdated == false)
            {
                MessageBox.Show("Это изображение уже было загружено", "Error");
                return;
            }


            if (usersComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите имя пользователя ...", "Error");
                return;
            }

            if (digitsComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите цифру ...", "Error");
                return;
            }

            User user = (User)usersComboBox.SelectedItem;

            string imageName = Path.GetFileNameWithoutExtension(pictureBox.ImageLocation);

            string label = digitsComboBox.SelectedItem.ToString();
            Tuple<int,string> result;
            try
            {
                result = TechsonAPI.UploadImage(pictureBox.Image, imageName, user.id.ToString(), label);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            Console.WriteLine(result);

            if (result.Item1 == 200)
            {
                successLabel.Visible = true;
                isImageUpdated = false;
            }
            else
            {
                MessageBox.Show(result.Item2);
            }
            
        }
    }
}
