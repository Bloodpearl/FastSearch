using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastSearch.Common
{
    public static class AppSettings
    {
        internal static double version = 0.1;
        internal static string phrase = "Alfa";
        internal static string name = "Fast Search";
        internal static string fullName = null;
        internal static bool blockOnError = false;
        
        public static string FullName
        {
            get
            {
                if (fullName == null)
                {
                    string[] text = { name, "-", version.ToString(), phrase };
                    fullName = string.Join(" ", text);
                }
                return fullName;
            }
        }
        public static bool AlfaSwitch = true;
        public static double OpacityMax;
        public static double OpacityMin;

        public static Dictionary<string, string> Browsers = new Dictionary<string, string>();
        private static string defaultBrowser;
        public static string DefaultBrowser
        {
            get
            {
                if (AppSettings.defaultBrowser == null)
                {
                    AppFunc.SendError("Brak zdefiniowanej domyślnej przeglądarki");
                }
                return AppSettings.defaultBrowser;
            }
            set { AppSettings.defaultBrowser = value; }
        }

        public static Dictionary<string, ApplicationData> Applications = new Dictionary<string, ApplicationData>();
        private static ApplicationData defaultApplication;
        public static ApplicationData DefaultApplication
        {
            get
            {
                if (AppSettings.defaultApplication == null)
                {
                    AppFunc.SendError("Brak zdefiniowanej domyślnej aplikacji");
                }
                return AppSettings.defaultApplication; 
            }
            set { AppSettings.defaultApplication = value; }
        }

    }
}
