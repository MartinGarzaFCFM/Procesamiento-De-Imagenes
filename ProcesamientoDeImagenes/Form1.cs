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
using System.Security.Cryptography.X509Certificates;

namespace ProcesamientoDeImagenes
{
    public partial class Form1 : Form
    {
        //Webcam
        Capture camera;

        //Preview Image
        Bitmap previewImage;

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

        //Detect Face
        //public static CascadeClassifier cascadeClassifier;
        bool detectFace;
        public static int numFaces;

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

            rgbColors = new double[3] { 0, 0, 0 };

            RGBBox.Enabled = true;

            //Detect Face
            //Face Detection
            detectFace = false;
            numFaces = 0;

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

        private void Camera_ImageGrabbed(object sender, EventArgs e)
        {
            detectFace = facesCheck.Checked ? true : false;

            countFaces(numFaces);

            try
            {
                camera.Retrieve(m);
                previewImage = m.ToImage<Bgr, byte>().Bitmap;
                pt = new Point[m.Width, m.Height];

                if (!string.IsNullOrEmpty(filter))
                {
                    switch (filter)
                    {
                        case "Invertir":
                            pic.Image = Filtros.Invert(previewImage, detectFace);
                            break;
                        case "Offset":

                            pic.Image = Filtros.OffsetFilter(previewImage, pt, detectFace);
                            break;

                        case "B/N":

                            pic.Image = Filtros.GrayScale(previewImage, detectFace);
                            break;

                        case "Sepia":
                            pic.Image = Filtros.DrawAsSepiaTone(previewImage, detectFace);
                            break;

                        case "Tint":
                            pic.Image = Filtros.ColorTint(previewImage, (float)rgbColors[2], (float)rgbColors[1], (float)rgbColors[0], detectFace);
                            break;


                        default:

                            break;
                    }
                }
                else
                {
                    if (detectFace) previewImage = Filtros.ShowFaces(previewImage);
                    pic.Image = previewImage;
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

        private void countFaces(int numFaces)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(countFaces), new object[] { numFaces });
                return;
            }
            facesCount.Text = numFaces.ToString();
        }
    }
}
