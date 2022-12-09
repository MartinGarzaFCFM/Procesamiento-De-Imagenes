using ProcesamientoDeImagenes;
using System.Drawing;
using Emgu.CV;

internal static class Form1Helpers
{
    public static Bitmap imagenload;
    public static int numFaces;
    //Ruta de Video
    public static Capture videoCapture;
    public static bool IsPlaying = false;
    public static int TotalFrames;
    public static int CurrentFrameNo;
    public static Mat CurrentFrame;
    public static int FPS;
    public static string videoLoad;
}