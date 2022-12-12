using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesamientoDeImagenes
{
    public partial class ImageProcess : Form
    {
        //copy image
        private readonly Bitmap imagenIn;
        //RGB TrackBars
        double[] rgbColors;
        //detect face
        bool detectFace = false;
        //Selected Filter
        String filter;
        public ImageProcess()
        {
            InitializeComponent();

            rgbColors = new double[3] { 0, 0, 0 };
            imagePic.Image = Form1Helpers.imagenload;
            imagenIn = Form1Helpers.imagenload;
        }

        private void ImageProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ImageProcess_Load(object sender, EventArgs e)
        {
            
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
                            imageOut.Image = Filtros.Invert(imagenIn, detectFace);
                            break;
                        case "Remolino":
                            imageOut.Image = Filtros.Swirl(imagenIn, 0.01, detectFace);
                            break;

                        case "B/N":
                            imageOut.Image = Filtros.GrayScale(imagenIn, detectFace);
                            break;

                        case "Sepia":
                            imageOut.Image = Filtros.DrawAsSepiaTone(imagenIn, detectFace);
                            break;

                        case "Tint":
                            imageOut.Image = Filtros.ColorTint(imagenIn, (float)rgbColors[2], (float)rgbColors[1], (float)rgbColors[0], detectFace);
                            break;
                        case "Mirror":
                            imageOut.Image = Filtros.Mirror(imagenIn, detectFace);
                            break;

                        case "Edge":
                            imageOut.Image = Filtros.EdgeDetectHomogenity(imagenIn, 0, detectFace);
                            break;

                        default:
                            imageOut.Image = null;
                            break;
                    }
                }
                else
                {
                    imageOut.Image = imagenIn;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //cambiar el filtro y agregar a var
        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = cboFilter.Text;
            //Procesar y mostrar Imagen
            procesar();
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
