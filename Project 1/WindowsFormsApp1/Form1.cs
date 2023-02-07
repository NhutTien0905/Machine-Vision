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

            string path = @"D:\University\Semester_2_2nd\Machine Vision\image\lena.gif";
            Bitmap img = new Bitmap(path);
            pictureBox1.Image = img;

            Bitmap red = new Bitmap(img.Width, img.Height);
            Bitmap green = new Bitmap(img.Width, img.Height);
            Bitmap blue = new Bitmap(img.Width, img.Height);

            for (int x = 0; x<img.Width; x++)
            {
                for (int y = 0; y<img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    byte r = pixel.R;
                    byte g = pixel.G;
                    byte b = pixel.B;
                    byte transparent = pixel.A;

                    red.SetPixel(x, y, Color.FromArgb(transparent, r, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(transparent, 0, g, 0));
                    blue.SetPixel(x, y, Color.FromArgb(transparent,0 ,0, b));
                }
            }

            pictureBox2.Image = red;
            pictureBox3.Image = green;
            pictureBox4.Image = blue;   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
