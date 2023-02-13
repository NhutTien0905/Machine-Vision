using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace MP5_TinhvavebieudoHistogramcuamucxam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Load Hinh
            Bitmap HinhGoc = new Bitmap(@"C:\Users\THETRUNG\Downloads\lena_color.jpg");
            //Hien thi tren pictureBox
            picBoxHinhGoc.Image = HinhGoc;

            // Tinh hinh muc xam theo phuong phap Luminance va cho hien thi
            Bitmap HinhMucXam = ChuyenHinhRGBSangHinhXamLumainance(HinhGoc);
            picBoxHinhXam.Image = HinhMucXam;

            double[] histogram = TinhHistogram(HinhMucXam);

            PointPairList points = ChuyenDoiHistogram(histogram);

            zGHistogram.GraphPane=BieuDoHistogram(points);
            zGHistogram.Refresh();

        }

        public Bitmap ChuyenHinhRGBSangHinhXamLumainance(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam= new Bitmap(hinhgoc.Width,hinhgoc.Height);
            for(int x=0;x<hinhgoc.Width;x++)
                for (int y=0; y < hinhgoc.Height;y++)
                {
                    Color pixel=hinhgoc.GetPixel(x,y);
                    byte R=pixel.R;
                    byte G=pixel.G;
                    byte B=pixel.B;

                    byte gray=(byte)((0.2126*R+0.7152*G+0.0722*B)/3);
                    HinhMucXam.SetPixel(x,y,Color.FromArgb(gray,gray,gray));
                }
            return HinhMucXam;
        }
        public double[] TinhHistogram(Bitmap HinhMucXam)
        {
            double[] histogram = new double[256];
            for  ( int x=0;x<HinhMucXam.Width;x++)
                for (int y = 0; y < HinhMucXam.Height; y++)
                {
                    Color color=HinhMucXam.GetPixel(x, y);
                    byte gray=color.R;

                    histogram[gray]++;

                }
            return histogram;
        }
        PointPairList ChuyenDoiHistogram(double[] histogram)
        {
            PointPairList points=new PointPairList();
            for (int i=0;i<histogram.Length;i++)
            {
                points.Add(i, histogram[i]);
            }
            return points;

        }
        public GraphPane BieuDoHistogram(PointPairList histogram)
        {
            GraphPane gp = new GraphPane();
            gp.Rect= new Rectangle(0, 0, 700, 500); ;
            gp.Title.Text = @"Bieu do Histogram";
            
            gp.XAxis.Title.Text = @"Gia tri muc xam cua cac diem anh";
            gp.XAxis.Scale.Min= 0;
            gp.XAxis.Scale.Max = 255;
            gp.XAxis.Scale.MajorStep = 5;
            gp.XAxis.Scale.MinorStep = 1;

            gp.XAxis.Title.Text = @"So diem anh co cung muc xam";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 1500;
            gp.YAxis.Scale.MajorStep = 5;
            gp.YAxis.Scale.MinorStep = 1;

            gp.AddBar("Histogram", histogram, Color.OrangeRed);

            return gp;

           

        }
            


        
    }
}