using System.Threading;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap Img;
        int[,] maskX = new int[3, 3]{ { -1,-2,-1},
                         { 0,0,0},
                         { 1,2,1}};
        int[,] maskY = new int[3, 3]{ { -1, 0, 1 },
                         {-2,0,2 },
                         {-1,0, 1 }};
        public Form1()
        {
            InitializeComponent();
            Img = new Bitmap(@"D:\University\Semester_2_2nd\Machine Vision\image\lena.png");
            orgImg.Image = Img;
        }
        public Bitmap zeroPad(Bitmap img, int numPad)
        {
            int nH = img.Height + 2 * numPad;
            int nW = img.Width + 2 * numPad;
            Bitmap nImg = new Bitmap(nW, nH);

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
        public Bitmap convolution(Bitmap img, int[,] mask)
        {
            int w = img.Width;
            int h = img.Height;
            int lenK = mask.GetLength(0);
            Bitmap nImg = new Bitmap(img.Width, img.Height);
            for (int i = 0; i < w - lenK; i++)
            {
                for (int j = 0; j < h - lenK; j++)
                {
                    int r = 0;
                    int g = 0;
                    int b = 0;
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
                    nImg.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            return nImg;
        }

        public byte calRateOfChange(Color pixelX, Color pixelY)
        {
            double F = 0;
            int gxx = pixelX.R^2 + pixelX.G^2 + pixelX.B^2;
            int gyy = pixelY.R^2 + pixelY.G^2 + pixelY.B^2;
            int gxy = pixelY.R*pixelY.R + pixelY.G*pixelY.G + pixelX.B*pixelY.B;
            try
            {
                double theta = 0.5 * Math.Atan((double)(2 * (gxy / (gxx - gyy))));
                F = Math.Sqrt(0.5 * ((gxx + gyy) + (gxx - gyy) * Math.Cos(2 * theta) + 2 * gxy * Math.Sin(2 * theta)));
            }
            catch
            {
                F = 255;
            }
            
            return (byte)F;
        }
        public Bitmap convertImg(Bitmap img, int threshold)
        {
            Bitmap sobelX = convolution(zeroPad(img, 1), maskX);
            Bitmap sobelY = convolution(zeroPad(img, 1), maskY);
            Bitmap sobel = new Bitmap(img.Width, img.Height);
            int w = img.Width;
            int h = img.Height;
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Color pixelX = sobelX.GetPixel(x, y);
                    Color pixelY = sobelY.GetPixel(x, y);
                    byte F = calRateOfChange(pixelX, pixelY);
                    if (F < threshold)
                    {
                        F = 0;
                    }
                    else
                    {
                        F  = 255;
                    }
                    sobel.SetPixel(x, y, Color.FromArgb((byte)F, (byte)F, (byte)F));
                }
            }
            return sobel;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int threshold = Convert.ToInt16(thresh.Text);
            sobelImg.Image = convertImg(Img, threshold);
        }
    }
}