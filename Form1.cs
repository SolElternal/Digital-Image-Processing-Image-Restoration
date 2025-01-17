using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Bitmap f_image = null;  //input image
        public Bitmap image;       //output image
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Null
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Image Smoothing
            Bitmap smoothedImage = new Bitmap(image.Width, image.Height);

            int[,] filter = new int[3, 3]
            {
        { 1, 1, 1 },
        { 1, 1, 1 },
        { 1, 1, 1 }
            };

            int filterWeight = 9;

            for (int x = 1; x < image.Width - 1; x++)
            {
                for (int y = 1; y < image.Height - 1; y++)
                {
                    int sum = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            sum += image.GetPixel(x + i, y + j).R * filter[i + 1, j + 1];
                        }
                    }

                    int newGray = sum / filterWeight;
                    smoothedImage.SetPixel(x, y, Color.FromArgb(newGray, newGray, newGray));
                }
            }

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if (x == 0 || y == 0 || x == image.Width - 1 || y == image.Height - 1)
                    {
                        smoothedImage.SetPixel(x, y, image.GetPixel(x, y));
                    }
                }
            }

            pictureBox2.Image = smoothedImage;
        }

        private int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        private void ImageShapening_Click(object sender, EventArgs e)
        {
            //Image Image Shapening
            Bitmap sharpenedImage = new Bitmap(image.Width, image.Height);

            int[,] filter = new int[3, 3]
            {
        { 1,  1,  1 },
        { 1, -8,  1 },
        { 1,  1,  1 }
            };

            for (int x = 1; x < image.Width - 1; x++)
            {
                for (int y = 1; y < image.Height - 1; y++)
                {
                    int sum = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            sum += image.GetPixel(x + i, y + j).R * filter[i + 1, j + 1];
                        }
                    }

                    int newGray = Clamp(sum, 0, 255);
                    sharpenedImage.SetPixel(x, y, Color.FromArgb(newGray, newGray, newGray));
                }
            }

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if (x == 0 || y == 0 || x == image.Width - 1 || y == image.Height - 1)
                    {
                        sharpenedImage.SetPixel(x, y, image.GetPixel(x, y));
                    }
                }
            }

            pictureBox2.Image = sharpenedImage;
        }

        private void MaxFilter_Click(object sender, EventArgs e)
        {
            //Max Filter
            Bitmap maxFilteredImage = new Bitmap(image.Width, image.Height);

            // วนลูปสำหรับพิกเซลกลาง
            for (int x = 1; x < image.Width - 1; x++)
            {
                for (int y = 1; y < image.Height - 1; y++)
                {
                    // สร้าง array เก็บค่า pixel 3x3
                    int[] neighborhood = new int[9];
                    int index = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            neighborhood[index++] = image.GetPixel(x + i, y + j).R;
                        }
                    }

                    // หา Max value ใน neighborhood
                    int maxGray = neighborhood.Max();

                    maxFilteredImage.SetPixel(x, y, Color.FromArgb(maxGray, maxGray, maxGray));
                }
            }

            // ตั้งค่าขอบภาพ (g(x, y) = f(x, y))
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if (x == 0 || y == 0 || x == image.Width - 1 || y == image.Height - 1)
                    {
                        maxFilteredImage.SetPixel(x, y, image.GetPixel(x, y));
                    }
                }
            }

            pictureBox2.Image = maxFilteredImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //input image
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //output image
        }

        private void OPENFOLDER_Click(object sender, EventArgs e)
        {
            // ใช้ OpenFileDialog เพื่อเลือกภาพ
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Open Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // กำจัดภาพเก่าที่โหลดมาแล้ว
                        if (f_image != null)
                        {
                            f_image.Dispose();
                        }

                        // โหลดภาพใหม่จากไฟล์
                        f_image = new Bitmap(openFileDialog.FileName);

                        // แปลงภาพเป็นระดับสีเทา
                        image = new Bitmap(f_image.Width, f_image.Height);

                        for (int i = 0; i < f_image.Width; i++)
                        {
                            for (int j = 0; j < f_image.Height; j++)
                            {
                                Color pixelColor = f_image.GetPixel(i, j);
                                int c_gray = (int)(pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                                image.SetPixel(i, j, Color.FromArgb(c_gray, c_gray, c_gray));
                            }
                        }

                        // แสดงผลภาพใน PictureBox
                        pictureBox1.Image = f_image;
                        pictureBox2.Image = image;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Cannot open file: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            //not use
        }
    }
}
