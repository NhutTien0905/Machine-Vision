using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            (Y.Image, Cr.Image, Cb.Image, YCrCb.Image) = convertImg(img);
        }

        public Tuple<Bitmap,Bitmap,Bitmap,Bitmap> convertImg(Bitmap img)
        {
            Bitmap Y = new Bitmap(img.Width,img.Height);
            Bitmap Cr = new Bitmap(img.Width, img.Height);
            Bitmap Cb = new Bitmap(img.Width, img.Height);
            Bitmap YCrCb = new Bitmap(img.Width, img.Height);
            for (int i = 0; i<img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    byte y = (byte)(16 + (65.738 * R + 129.057 * G + 25.064 * B) / 256);
                    byte cb = (byte)(128 - (37.945 * R + 74.494 * G - 112.439 * B) / 256);
                    byte cr = (byte)(128 + (112.439 * R - 94.154 * G - 18.285 * B)/256);

                    Y.SetPixel(i, j, Color.FromArgb(y,y,y));
                    Cr.SetPixel(i, j, Color.FromArgb(cr, cr, cr));
                    Cb.SetPixel(i, j, Color.FromArgb(cb, cb, cb));
                    YCrCb.SetPixel(i, j, Color.FromArgb(y,cb,cr));
                }
            }
            return Tuple.Create(Y,Cr,Cb,YCrCb);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
