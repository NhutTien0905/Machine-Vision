using System.Security.Cryptography.Xml;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap Img;
        public Form1()
        {
            InitializeComponent();
            
            Img = new Bitmap(@"D:\University\Semester_2_2nd\Machine Vision\image\lena.png");
            orgimg.Image = Img;
        }

        public double[] calAvgColor(Bitmap img, int[] point1, int[] point2)
        {
            int x1 = point1[0];
            int y1 = point1[1];
            int x2 = point2[0];
            int y2 = point2[1];
            int element = Math.Abs((x2 - x1) * (y2 - y1));
            double red = 0;
            double green = 0; 
            double blue = 0;
            for (int x = x1; x <= x2; x++)
            {
                for (int y = y1; y <= y2; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    red += (double)pixel.R;
                    green += (double)pixel.G;
                    blue += (double)pixel.B;
                }
            }
            red /= element;
            green /= element;
            blue /= element;
            return new double[] { red, green, blue };
        }

        public Bitmap convertImg(Bitmap img,int threshold, int[]point1, int[]point2)
        {
            //int threshold = Convert.ToInt16(thresh.Text);
            Bitmap nImg = new Bitmap(img.Width, img.Height);
            int w = img.Width;
            int h = img.Height;
            double[]avgColor = calAvgColor(img, point1, point2);
            double avgRed = avgColor[0];
            double avgGreen = avgColor[1];
            double avgBlue = avgColor[2];
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    double red = pixel.R;
                    double green = pixel.G;
                    double blue = pixel.B;
                    double D = Math.Sqrt((red-avgRed)*(red - avgRed) + (green - avgGreen) * (green - avgGreen) + (blue - avgBlue) * (blue - avgBlue));
                    if (D < threshold)
                    {
                        nImg.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        nImg.SetPixel(x, y, Color.FromArgb((byte)red, (byte)green, (byte)blue));
                    }
                }
            }
            return nImg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int threshold = Convert.ToInt16(thresh.Text);
            int[] point1 = { Convert.ToInt16(point1X.Text), Convert.ToInt16(point1Y.Text) };
            int[] point2 = { Convert.ToInt16(point2X.Text), Convert.ToInt16(point2Y.Text) };
            segImg.Image = convertImg(Img, threshold,point1,point2);
        }
    }
}