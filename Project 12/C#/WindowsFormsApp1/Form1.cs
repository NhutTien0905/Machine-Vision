using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
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
            Bitmap img = new Bitmap(@"D:\University\Semester_2_2nd\Machine Vision\image\lena.jpg");
            orgImg.Image = img;
            int[,] mask = new int[3, 3]{ { 0,-1,0},
                                        { -1,4,-1},
                                        {0,-1,0 } };
            shapenedImg.Image = convolution(zeroPad(img,1), mask);
        }

        public Bitmap zeroPad(Bitmap img,int numPad)
        {
            int nH = img.Height + 2*numPad;
            int nW = img.Width + 2*numPad;
            Bitmap nImg = new Bitmap(nW,nH);

            for (int i = 0; i < nW; i++)
            {
                for (int j = 0; j < nH; j++)
                {
                    if (i >= numPad && i < img.Width)
                    {
                        if (j >= numPad && j < img.Height)
                        {
                            nImg.SetPixel(i, j, img.GetPixel(i - numPad, j - numPad));
                        }                       
                    }
                    else
                    {
                        nImg.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            return nImg;
        }

        public Bitmap convolution(Bitmap img, int[,]mask) 
        {
            int w = img.Width;
            int h = img.Height;
            int lenK = mask.GetLength(0);
            Bitmap nImg = new Bitmap(img.Width,img.Height);
            for (int i = 0; i < w - lenK; i++)
            {
                for (int j = 0; j < h - lenK; j++)
                {
                    Color color = img.GetPixel(i, j);
                    int r = color.R;
                    int g = color.G;
                    int b = color.B;
                    for (int k = 0; k < lenK; k++)
                    {
                        for (int t = 0; t < lenK; t++)
                        {
                            Color rgb = img.GetPixel(k + i, t + j);
                            r += rgb.R * mask[k, t];
                            g += rgb.G * mask[k, t];
                            b += rgb.B * mask[k, t];
                        }
                    }
                    int red = Math.Max(Math.Min(r, 255), 0);
                    int green = Math.Max(Math.Min(g, 255), 0);
                    int blue = Math.Max(Math.Min(b, 255), 0);
                    nImg.SetPixel(i,j,Color.FromArgb(red, green, blue));
                }
            }
            return nImg;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
