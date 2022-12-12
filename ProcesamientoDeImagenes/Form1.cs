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
        bool detectMov;

        //Detect Mov
        GridMotionProcessing detectarMov;

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
            detectMov = false;
            Form1Helpers.numFaces = 0;

            Timer tmr = new Timer();
            tmr.Interval = 50;
            tmr.Tick += Tmr_Tick;
            tmr.Start();

            detectarMov = new GridMotionProcessing();
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
            detectMov = MovCheck.Checked ? true : false;

            countFaces(Form1Helpers.numFaces);

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
                        case "Remolino":
                            pic.Image = Filtros.Swirl(previewImage, 0.01, detectFace);
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

                        case "Mirror":
                            pic.Image = Filtros.Mirror(previewImage, detectFace);
                            break;

                        case "Edge":
                            pic.Image = Filtros.EdgeDetectHomogenity(previewImage, 0, detectFace);
                            break;


                        default:

                            break;
                    }
                }
                else
                {
                    if (detectFace) previewImage = Filtros.ShowFaces(previewImage);
                    if (detectMov) detectarMov.Detectar(previewImage); ;

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

        private void imagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //camera.Stop();

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos de Imagen(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Imagen Cargada
                Form1Helpers.imagenload = new Bitmap(open.FileName);
                ImageProcess imageProcess = new ImageProcess();
                imageProcess.FormClosed += new FormClosedEventHandler(imageProcess_FormClosed);
                imageProcess.Show();
                this.Hide();
            }
            else
            {

            }

        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos de Video (*.mp4, *.flv) | *.mp4;*.flv";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Form1Helpers.videoCapture = new Capture(open.FileName);
                Form1Helpers.TotalFrames = Convert.ToInt32(Form1Helpers.videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount));
                Form1Helpers.FPS = Convert.ToInt32(Form1Helpers.videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps));
                Form1Helpers.IsPlaying = true;
                Form1Helpers.CurrentFrame = new Mat();
                Form1Helpers.CurrentFrameNo = 0;

                Form1Helpers.videoLoad = open.FileName;
                VideoProcess videoProcess = new VideoProcess();
                videoProcess.FormClosed += new FormClosedEventHandler(videoProcess_FormClosed);
                videoProcess.Show();
                this.Hide();
            }
        }

        private void imageProcess_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void videoProcess_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
