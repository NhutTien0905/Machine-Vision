using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap image = new Bitmap(@"D:\University\Semester_2_2nd\Machine Vision\image\lena.jpg");
            orgImage.Image = image;
            Avarage.Image = AverageFunction(image);
            Lightness.Image = LightnessFunction(image);
            Luminance.Image = LuminanceFunction(image);
        }

        public Bitmap AverageFunction(Bitmap orgImg)
        {
            Bitmap grayImg = new Bitmap(orgImg.Width, orgImg.Height);
            for (int i = 0; i < grayImg.Width; i++)
            {
                for (int j = 0; j < grayImg.Height; j++)
                {
                    Color pixel = orgImg.GetPixel(i, j);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte gray = (byte)((R+G+B)/3);

                    grayImg.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            return grayImg;
        }
        
        public Bitmap LightnessFunction(Bitmap orgImg)
        {
            Bitmap grayImg = new Bitmap(orgImg.Width, orgImg.Height);
            for (int i = 0; i < grayImg.Width; i++)
            {
                for (int j = 0; j < grayImg.Height; j++)
                {
                    Color pixel = orgImg.GetPixel(i, j);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte min = Math.Min(R, Math.Min(G, B));
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte gray = (byte)((min + max)/2);

                    grayImg.SetPixel(i,j,Color.FromArgb(gray, gray, gray));
                }
            }
            return grayImg;
        }

        public Bitmap LuminanceFunction(Bitmap orgImg)
        {
            Bitmap grayImg = new Bitmap(orgImg.Width, orgImg.Height);
            for (int i = 0; i < grayImg.Width; i++)
            {
                for (int j = 0; j < grayImg.Height; j++)
                {
                    Color pixel = orgImg.GetPixel(i, j);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte gray = (byte)(0.2125*R + 0.7152*G + 0.0722*B);

                    grayImg.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            return grayImg;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
