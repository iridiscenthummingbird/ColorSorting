using System.Collections.Generic;
using System.Drawing;

namespace ColorSorting
{
    class Colors
    {
        private static byte constantColor = Properties.Settings.Default.ConstantColor;
        private static List<Color> listOfColors = new List<Color>();
        private static Color[,] arr;

        public static byte ConstantColor
        {
            get { return constantColor; }
            set { constantColor = value; }
        }
        public static Color[,] Array { get { return arr; } set { arr = value; } }

        public static List<Color> ListOfColors { get => listOfColors; set => listOfColors = value; }



    }
}
