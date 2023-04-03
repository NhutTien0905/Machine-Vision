using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ColorImageSmoothing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Load the Image 
            Bitmap HinhGoc = new Bitmap(@"D:\University\Semester_2_2nd\Machine Vision\image\lena.png");
            //display the image to the picBox
            picBoxHinhGoc.Image = HinhGoc;

            Bitmap SmoothedImage3x3 = ColorImageSmoothing3x3(HinhGoc);
            picBoxSmoothedImage3x3.Image = SmoothedImage3x3;

            Bitmap SmoothedImage5x5 = ColorImageSmoothing5x5(HinhGoc);
            picBoxSmoothedImage5x5.Image = SmoothedImage5x5;

            Bitmap SmoothedImage7x7 = ColorImageSmoothing7x7(HinhGoc);
            picBoxSmoothedImage7x7.Image = SmoothedImage7x7;

            Bitmap SmoothedImage9x9 = ColorImageSmoothing9x9(HinhGoc);
            picBoxSmoothedImage9x9.Image = SmoothedImage9x9;



        }
        // create Smoothing function
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public Bitmap ColorImageSmoothing3x3(Bitmap HinhGoc)
        {
            //Tao san mot hinh bitmap de chua anh
            Bitmap SmoothedImage = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            //Quet cac diem anh,De de lam muot thi bo qua cac vien ngoai, chi quet tu 1 toi width-1 va height-1
            for (int x = 1; x < HinhGoc.Width-1; x++)
                for (int y = 1; y < HinhGoc.Height-1; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    byte K = 3 * 3;
                    Rs = (byte)(Rs / K);
                    Gs = (byte)(Gs / K);
                    Bs = (byte)(Bs / K);

                    SmoothedImage.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));

                }
            return SmoothedImage;
        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        public Bitmap ColorImageSmoothing5x5(Bitmap HinhGoc)
        {
            //Tao san mot hinh bitmap de chua anh
            Bitmap SmoothedImage = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            //Quet cac diem anh,De de lam muot thi bo qua cac vien ngoai, chi quet tu 1 toi width-1 va height-1
            for (int x = 2; x < HinhGoc.Width - 2; x++)
                for (int y = 2; y < HinhGoc.Height - 2; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;
                    for (int i = x - 2; i <= x + 2; i++)
                        for (int j = y - 2; j <= y + 2; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    byte K = 5*5;
                    Rs = (byte)(Rs / K);
                    Gs = (byte)(Gs / K);
                    Bs = (byte)(Bs / K);

                    SmoothedImage.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));

                }
            return SmoothedImage;
        }
        public Bitmap ColorImageSmoothing7x7(Bitmap HinhGoc)
        {
            //Tao san mot hinh bitmap de chua anh
            Bitmap SmoothedImage = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            //Quet cac diem anh,De de lam muot thi bo qua cac vien ngoai, chi quet tu 1 toi width-1 va height-1
            for (int x = 3; x < HinhGoc.Width - 3; x++)
                for (int y = 3; y < HinhGoc.Height - 3; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;
                    for (int i = x - 3; i <= x + 3; i++)
                        for (int j = y - 3; j <= y + 3; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    byte K = 7 * 7;
                    Rs = (byte)(Rs / K);
                    Gs = (byte)(Gs / K);
                    Bs = (byte)(Bs / K);

                    SmoothedImage.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));

                }
            return SmoothedImage;
        }

        public Bitmap ColorImageSmoothing9x9(Bitmap HinhGoc)
        {
            //Tao san mot hinh bitmap de chua anh
            Bitmap SmoothedImage = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            //Quet cac diem anh,De de lam muot thi bo qua cac vien ngoai, chi quet tu 1 toi width-1 va height-1
            for (int x = 4; x < HinhGoc.Width - 4; x++)
                for (int y = 4; y < HinhGoc.Height - 4; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;
                    for (int i = x - 4; i <= x + 4; i++)
                        for (int j = y - 4; j <= y + 4; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    byte K = 9 * 9;
                    Rs = (byte)(Rs / K);
                    Gs = (byte)(Gs / K);
                    Bs = (byte)(Bs / K);

                    SmoothedImage.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));

                }
            return SmoothedImage;
        }

    }
}
