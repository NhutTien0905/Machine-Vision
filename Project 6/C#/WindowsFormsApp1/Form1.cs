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
            Bitmap img = new Bitmap(@"D:\University\Semester_2_2nd\Machine Vision\image\lena.jpg");
            orgImage.Image = img;
            (Cyan.Image, Magenta.Image, Yellow.Image, Black.Image)= ConvertFunction(img);
        }

        public Tuple<Bitmap,Bitmap,Bitmap,Bitmap> ConvertFunction(Bitmap orgImg)
        {
            Bitmap cyan = new Bitmap(orgImg.Width, orgImg.Height);
            Bitmap magenta = new Bitmap(orgImg.Width, orgImg.Height);
            Bitmap yellow = new Bitmap(orgImg.Width, orgImg.Height);
            Bitmap black = new Bitmap(orgImg.Width, orgImg.Height);
            for (int i = 0; i < orgImg.Width; i++)
            {
                for (int j = 0; j < orgImg.Height; j++)
                {
                    Color pixel = orgImg.GetPixel(i, j);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    byte gray = Math.Min(R,Math.Max(G,B));

                    cyan.SetPixel(i, j, Color.FromArgb(0, G, B));
                    magenta.SetPixel(i, j, Color.FromArgb(R, 0, B));
                    yellow.SetPixel(i, j, Color.FromArgb(R, G, 0));
                    black.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            return Tuple.Create(cyan, magenta, yellow, black);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
