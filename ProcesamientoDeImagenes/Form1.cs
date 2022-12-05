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

        //Selected Filter
        String filter;

        Point[,] pt;

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
                            pic.Image = Invert(m.ToImage<Bgr, byte>().Bitmap);
                            break;
                        case "Offset":

                            pic.Image = OffsetFilter(m.ToImage<Bgr, byte>().Bitmap, pt);
                            break;

                        case "B/N":

                            pic.Image = GrayScale(m.ToImage<Bgr, byte>().Bitmap);
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
        public static Bitmap Invert(Bitmap b)
        {
            // GDI+ still lies to us - the return format is BGR, NOT RGB. 
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                int nOffset = stride - b.Width * 3;
                int nWidth = b.Width * 3;
                for (int y = 0; y < b.Height; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        p[0] = (byte)(255 - p[0]);
                        ++p;
                    }
                    p += nOffset;
                }
            }

            b.UnlockBits(bmData);

            return b;
        }

        public static Bitmap GrayScale(Bitmap b)
        {
            // GDI+ still lies to us - the return format is BGR, NOT RGB. 
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - b.Width * 3;

                byte red, green, blue;

                for (int y = 0; y < b.Height; ++y)
                {
                    for (int x = 0; x < b.Width; ++x)
                    {
                        blue = p[0];
                        green = p[1];
                        red = p[2];

                        p[0] = p[1] = p[2] = (byte)(.299 * red
                            + .587 * green
                            + .114 * blue);

                        p += 3;
                    }
                    p += nOffset;
                }
            }

            b.UnlockBits(bmData);

            return b;
        }

        public static Bitmap OffsetFilter(Bitmap b, Point[,] offset)
        {
            Bitmap bSrc = (Bitmap)b.Clone();

            // GDI+ still lies to us - the return format is BGR, NOT RGB.
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0,
                bSrc.Width, bSrc.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int scanline = bmData.Stride;

            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr SrcScan0 = bmSrc.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* pSrc = (byte*)(void*)SrcScan0;

                int nOffset = bmData.Stride - b.Width * 3;
                int nWidth = b.Width;
                int nHeight = b.Height;

                int xOffset, yOffset;

                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        xOffset = offset[x, y].X;
                        yOffset = offset[x, y].Y;

                        p[0] = pSrc[((y + yOffset) * scanline) + ((x + xOffset) * 3)];
                        p[1] = pSrc[((y + yOffset) * scanline) + ((x + xOffset) * 3) + 1];
                        p[2] = pSrc[((y + yOffset) * scanline) + ((x + xOffset) * 3) + 2];

                        p += 3;
                    }
                    p += nOffset;
                }
            }

            b.UnlockBits(bmData);
            bSrc.UnlockBits(bmSrc);

            return b;
        }
    }
}
