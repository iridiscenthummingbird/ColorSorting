using System.Drawing;

namespace ColorSorting
{
    class ImageToSort : AbstractImage
    {
        private static Bitmap image;
        public static Bitmap Image { get { return image; } set { image = value; } }
    }
}
