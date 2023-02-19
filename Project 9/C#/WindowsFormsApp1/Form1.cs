using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            (xyzImage.Image, frameX.Image, frameY.Image, frameZ.Image) = convertColor(img);
        }

        public byte[,] MultiplyMatrix(byte[,] rgb)
        {
            double[,] transfer_matrix = new double[3, 3] { { 0.4124564, 0.3575761, 0.1804375 },
                                                      { 0.2126729, 0.7151522, 0.0721750 },
                                                      { 0.0193339, 0.1191920, 0.9503041} };
            byte[,] converted = new byte[3, 1];
            int w = transfer_matrix.GetLength(0); // row
            int h = transfer_matrix.GetLength(1); // column
            for (int i = 0; i < w; i++)
            {
                byte xyz = 0;
                for (int j = 0; j < h; j++)
                {
                    xyz += (byte)(transfer_matrix[i,j] * rgb[j, 0]);
                }
                converted[i,0] = xyz;
            }
            return converted;
        }

        public Tuple<Bitmap,Bitmap,Bitmap,Bitmap> convertColor(Bitmap img)
        {
            Bitmap XYZ = new Bitmap(img.Width, img.Height);
            Bitmap X = new Bitmap(img.Width, img.Height);
            Bitmap Y = new Bitmap(img.Width, img.Height);
            Bitmap Z = new Bitmap(img.Width, img.Height);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    byte[,] rgb = new byte[3, 1] { { pixel.R }, { pixel.G }, { pixel.B } };
                    byte[,] xyz = MultiplyMatrix(rgb);
                    
                    XYZ.SetPixel(i, j, Color.FromArgb(xyz[0, 0], xyz[1, 0], xyz[2, 0]));
                    X.SetPixel(i, j, Color.FromArgb(xyz[0, 0], xyz[0, 0], xyz[0, 0]));
                    Y.SetPixel(i, j, Color.FromArgb(xyz[1, 0], xyz[1, 0], xyz[1, 0]));
                    Z.SetPixel(i, j, Color.FromArgb(xyz[2, 0], xyz[2, 0], xyz[2, 0]));
                }
            }
            return Tuple.Create(XYZ, X, Y, Z);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
