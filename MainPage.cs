using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBG_CG
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image originalImage = Image.FromFile(openFileDialog.FileName);
                   

                    Image resizedImage = ResizeImage(originalImage, pictureBox.Width, pictureBox.Height);
                    

                    pictureBox.Image = resizedImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
        }

        private Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            int originalWidth = image.Width;
            int originalHeight = image.Height;
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }


        private void cmdPickColour_Click(object sender, EventArgs e)
        {
            pictureBox.MouseClick += new MouseEventHandler(pictureBox_MouseClick);
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image != null)
            {
                try
                {
                    Bitmap bmp = new Bitmap(pictureBox.Image);
                    Color color = bmp.GetPixel(e.X, e.Y);
                    txtRGB.Text = $"R: {color.R}, G: {color.G}, B: {color.B}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error picking color: {ex.Message}");
                }
            }
        }
    }
}
