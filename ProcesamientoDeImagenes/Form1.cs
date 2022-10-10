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
            try
            {
                camera.Retrieve(m);
                pic.Image = m.ToImage<Bgr, byte>().Bitmap;
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

    }
}
