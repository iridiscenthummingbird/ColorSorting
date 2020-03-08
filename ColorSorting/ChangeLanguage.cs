using System.Resources;
namespace ColorSorting
{
    class ChangeLanguage
    {
        private static bool language = Properties.Settings.Default.Language;
        private static ResourceManager[] langs;
        public static bool Language
        {
            get { return language; }
            set { language = value; }
        }

        public static ResourceManager[] ResManager
        {
            get { return langs; }
            set { langs = value; }
        }
    }
}
