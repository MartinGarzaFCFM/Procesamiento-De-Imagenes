using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
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
using ZedGraph;

namespace ProcesamientoDeImagenes
{
    public partial class VideoProcess : Form
    {

        //copy image
        private readonly Bitmap imagenIn;
        //RGB TrackBars
        double[] rgbColors;
        //detect face
        bool detectFace = false;
        //Selected Filter
        String filter;

        public VideoProcess()
        {
            InitializeComponent();

            rgbColors = new double[3] { 0, 0, 0 };
        }

        private void VideoProcess_Load(object sender, EventArgs e)
        {
            //Load Video
            trackBar1.Minimum= 0;
            trackBar1.Maximum= Form1Helpers.TotalFrames - 1;
            trackBar1.Value = 0;

            PlayVideo();
        }

        private async void PlayVideo()
        {
            if (Form1Helpers.videoCapture == null)
            {
                return;
            }

            try
            {
                while (Form1Helpers.IsPlaying && Form1Helpers.CurrentFrameNo<Form1Helpers.TotalFrames)
                {
                    Form1Helpers.videoCapture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, Form1Helpers.CurrentFrameNo);
                    Form1Helpers.videoCapture.Retrieve(Form1Helpers.CurrentFrame);

                    procesar();

                    trackBar1.Value = Form1Helpers.CurrentFrameNo;
                    Form1Helpers.CurrentFrameNo++;
                    await Task.Delay(1000/Form1Helpers.FPS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (Form1Helpers.videoCapture!=null)
            {
                Form1Helpers.IsPlaying = true;
            }
            else
            {
                Form1Helpers.IsPlaying = false;
            }
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            Form1Helpers.IsPlaying = !Form1Helpers.IsPlaying;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            Form1Helpers.IsPlaying = false;
            Form1Helpers.CurrentFrameNo = 0;
            trackBar1.Value = 0;
            imagePic.Image = null;
            imagePic.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (Form1Helpers.videoCapture != null)
            {
                Form1Helpers.CurrentFrameNo = trackBar1.Value;
            }
        }

        //Cambiar colores de Tinte
        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            rgbColors[0] = (double)trackBarR.Value / 100;
            procesar();
        }
        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            rgbColors[1] = (double)trackBarG.Value / 100;
            procesar();
        }
        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            rgbColors[2] = (double)trackBarB.Value / 100;
            procesar();
        }

        private void procesar()
        {
            try
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    switch (filter)
                    {
                        case "Invertir":
                            imagePic.Image = Filtros.Invert(Form1Helpers.CurrentFrame.Bitmap, detectFace);
                            break;
                        case "Remolino":
                            imagePic.Image = Filtros.Swirl(Form1Helpers.CurrentFrame.Bitmap, 0.01, detectFace);
                            break;

                        case "B/N":

                            imagePic.Image = Filtros.GrayScale(Form1Helpers.CurrentFrame.Bitmap, detectFace);
                            break;

                        case "Sepia":
                            imagePic.Image = Filtros.DrawAsSepiaTone(Form1Helpers.CurrentFrame.Bitmap, detectFace);
                            break;

                        case "Tint":
                            imagePic.Image = Filtros.ColorTint(Form1Helpers.CurrentFrame.Bitmap, (float)rgbColors[2], (float)rgbColors[1], (float)rgbColors[0], detectFace);
                            break;

                        case "Mirror":
                            imagePic.Image = Filtros.Mirror(Form1Helpers.CurrentFrame.Bitmap, detectFace);
                            break;

                        case "Edge":
                            imagePic.Image = Filtros.EdgeDetectHomogenity(Form1Helpers.CurrentFrame.Bitmap, 0, detectFace);
                            break;


                        default:

                            break;
                    }
                }
                else
                {
                    imagePic.Image = Form1Helpers.CurrentFrame.Bitmap;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //cambiar el filtro y agregar a var
        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = cboFilter.Text;
            //Procesar y mostrar Imagen
            procesar();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePic.Image.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}
