using System.Windows.Media.Imaging;

namespace ColorSorting
{
    abstract class AbstractImage
    {
        private static int height = Properties.Settings.Default.Height;
        public static int Height { get { return height; } set { height = value; } }
        private static GifBitmapEncoder GEnc = new GifBitmapEncoder();
        public static GifBitmapEncoder gifEncoder { get { return GEnc; } set { GEnc = value; } }
    }
}
