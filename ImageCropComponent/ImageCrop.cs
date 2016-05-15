using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using ImageProcessor;
using ImageProcessor.Imaging;
using ImageProcessor.Imaging.Formats;
using ImageProcessor.Imaging.Filters.Photo;

namespace ImageCropComponent
{
    public class ImageCrop: Component
    {
        private byte[] m_imageBytes;
        private Image[] m_resultImages;
        private Size m_size;
        public ImageCrop(Image image){
            m_size = image.Size;
            ImageConverter converter = new ImageConverter();
            m_imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
        public Image[] Crop(int m, int n){
            int w_total_error = (int)(0.07 * m_size.Width);
            int w_local_error = w_total_error / n + 1;

            int h_total_error = (int)(0.07 * m_size.Height);
            int h_local_error = h_total_error / m + 1;

            int w_step = (m_size.Width - w_total_error)/ n;
            int h_step = (m_size.Height - h_total_error) / m;
            int x = 0, y = h_local_error;
            m_resultImages = new Image[m * n];

            using (MemoryStream inStream = new MemoryStream(this.m_imageBytes))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        for (int i = 0; i < m; i++){
                            
                            x = w_local_error;
                            
                            for (int j = 0; j < n; j++){
                                imageFactory.Reset();
                              
                                CropLayer layer = new CropLayer(x,y,w_step,h_step, CropMode.Pixels);
                                Console.WriteLine("x = {0}, y = {1}", x, y);
                                imageFactory.Load(inStream).Crop(layer).Save(outStream);
                                
                                m_resultImages[i * n + j] = Image.FromStream(outStream);

                                x += (w_step + w_local_error);

                                outStream.SetLength(0);
                                outStream.Position = 0;
                            }
                            y += (h_step + h_local_error);
                        }

                    }
                    inStream.Close();
                }
            }
            return m_resultImages;
        }
    }
}
