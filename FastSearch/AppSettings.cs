using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastSearch
{
    public static class AppSettings
    {
        private static double version = 0.1;
        private static string phrase = "Alfa";
        private static string name = "Fast Search";
        public static string FullName
        {
            get
            {
                string[] text = { name, "-", version.ToString(), phrase };
                return string.Join(" ", text);
            }
        }
        public static bool AlfaSwitch = true;
        public static double OpacityMax;
        public static double OpacityMin;

        public static Dictionary<string, string> Browsers = new Dictionary<string, string>();
        public static string DefaultBrowser;
    }
}
