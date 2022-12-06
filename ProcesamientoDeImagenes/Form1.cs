using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProcesamientoDeImagenes
{
    public partial class Form1 : Form
    {
        //Webcam
        Capture camera;
        //Histogram
        Mat m = new Mat();
        Image<Bgr, byte> _inputImage;
        Image<Gray, byte> R;
        Image<Gray, byte> G;
        Image<Gray, byte> B;

        //Selected Filter
        String filter;

        Point[,] pt;

        //RGB TrackBars
        double[] rgbColors;

        private void Tmr_Tick(object sender, EventArgs e)
        {
            _inputImage = m.ToImage<Bgr, byte>();
            R = _inputImage[0];
            histogramBox1.ClearHistogram();
            histogramBox1.GenerateHistograms(R, 256);
            histogramBox1.Refresh();
        }

        public Form1()
        {
            InitializeComponent();

            rgbColors = new double[3] {0, 0, 0};

            RGBBox.Visible = true;

            Timer tmr = new Timer();
            tmr.Interval = 50;
            tmr.Tick += Tmr_Tick;
            tmr.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (camera == null)
                camera = new Capture(0);

            camera.ImageGrabbed += Camera_ImageGrabbed;
            camera.Start();
        }

        private void Form1_Update(object sender, EventArgs e)
        {


        }

        private void Camera_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                camera.Retrieve(m);
                pt = new Point[m.Width, m.Height];

                if (!string.IsNullOrEmpty(filter))
                {
                    switch (filter)
                    {
                        case "Invertir":
                            pic.Image = Filtros.Invert(m.ToImage<Bgr, byte>().Bitmap);
                            break;
                        case "Offset":

                            pic.Image = Filtros.OffsetFilter(m.ToImage<Bgr, byte>().Bitmap, pt);
                            break;

                        case "B/N":

                            pic.Image = Filtros.GrayScale(m.ToImage<Bgr, byte>().Bitmap);
                            break;

                        case "Sepia":
                            pic.Image = Filtros.DrawAsSepiaTone(m.ToImage<Bgr, byte>().Bitmap);
                            break;

                        case "Tint":
                            //RGBBox.Visible = true;
                            pic.Image = Filtros.ColorTint(m.ToImage<Bgr, byte>().Bitmap, (float)rgbColors[2], (float)rgbColors[1], (float)rgbColors[0]);
                            break;


                        default:
                            
                            break;
                    }
                }
                else
                {
                    pic.Image = m.ToImage<Bgr, byte>().Bitmap;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {


            histogramBox1.Update();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = cboFilter.Text;
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            rgbColors[0] = (double)trackBarR.Value / 100;
        }
        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            rgbColors[1] = (double)trackBarG.Value / 100;
        }
        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            rgbColors[2] = (double)trackBarB.Value / 100;
        }

    }
}
