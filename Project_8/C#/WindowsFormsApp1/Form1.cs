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
            Bitmap img = new Bitmap(@"D:/University/Semester_2_2nd/Machine Vision/image/lena.png");
            orgImg.Image= img;
            hue.Image = Hue(img);
            satu.Image = satur(img);
            val.Image = Value(img);
            hsv.Image = HSV(Hue(img),satur(img),Value(img));
        }

        public Bitmap Hue(Bitmap orgImg)
        {
            Bitmap grayImg = new Bitmap(orgImg.Width, orgImg.Height);
            for (int i = 0; i < grayImg.Width; i++)
            {
                for (int j = 0; j < grayImg.Height; j++)
                {
                    Color pixel = orgImg.GetPixel(i, j);
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    double det = 0.5 * ((R - G) + (R - B));
                    double nom = Math.Sqrt((R - G) * (R - G) + (R - B) * (G - B));
                    double hue = Math.Acos(det / nom);
                    if (B >= G) hue = 2 * Math.PI - hue;
                    hue = hue * 180 / Math.PI;
                    byte gray = (byte)hue;
                    grayImg.SetPixel(i, j, Color.FromArgb(gray, gray, gray));

                }
            }
            return grayImg;
        }
        public Bitmap satur(Bitmap orgImg)
        {
            Bitmap grayImg = new Bitmap(orgImg.Width, orgImg.Height);
            for (int i = 0; i < grayImg.Width; i++)
            {
                for (int j = 0; j < grayImg.Height; j++)
                {
                    Color pixel = orgImg.GetPixel(i, j);
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    double sat = (1 - 3 / (R + G + B) * Math.Min(R, Math.Min(G, B))) * 255;
                    grayImg.SetPixel(i, j, Color.FromArgb((byte)sat, (byte)sat, (byte)sat));
                }
            }
            return grayImg;
        }
        public Bitmap Value(Bitmap orgImg)
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

                    byte gray = (byte)Math.Max(B,Math.Max(G,R));

                    grayImg.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            return grayImg;
        }

        public Bitmap HSV(Bitmap hue, Bitmap sature, Bitmap value)
        {
            Bitmap grayImg = new Bitmap(hue.Width, hue.Height);
            for (int i = 0; i < grayImg.Width; i++)
            {
                for (int j = 0; j < grayImg.Height; j++)
                {
                    Color pixelH = hue.GetPixel(i, j);
                    Color pixelS = sature.GetPixel(i, j);
                    Color pixelV = value.GetPixel(i, j);

                    grayImg.SetPixel(i, j, Color.FromArgb(pixelH.G, pixelS.G, pixelV.G));
                }
            }
            return grayImg;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
