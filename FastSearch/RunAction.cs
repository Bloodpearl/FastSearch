using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastSearch.Common;
using System.Diagnostics;

namespace FastSearch
{
    public class RunAction
    {
        public static void Run(string Text, bool forceDefault = false)
        {
            string browser = null, arguments = null;
            ApplicationData app = null;
            if (forceDefault)
            {
                if (Text == null || Text.Trim().Length == 0)
                {
                    AppFunc.Alert("Wpisz komendę");
                    return;
                }
                browser = AppSettings.DefaultBrowser;
                app = AppSettings.DefaultApplication;
                arguments = Text;
            }
            else
            {
                ParseText(Text, ref browser, ref  app, ref  arguments);
            }

            runApp(browser, app, arguments);
        }

        public static void ParseText(string Text, ref string browser, ref ApplicationData app, ref string arguments)
        {
            browser = null;
            app = null;
            int index = 0;

            // get parts of command
            char[] whiteSpace = {' '};
            string[] parts = Text.Split(whiteSpace, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0)
            {
                AppFunc.Alert("Wpisz komendę");
                return;
            }
            // match browser or use default
            foreach (string browerAlias in AppSettings.Browsers.Keys)
            {
                if (browerAlias == parts[index])
                {
                    browser = AppSettings.Browsers[browerAlias];
                    index++;
                    break;
                }
            }
            if (browser == null)
            {
                if (AppSettings.DefaultBrowser == null)
                {
                    AppFunc.SendError("Brak zdefiniowanej domyślnej przeglądarki");
                }
                browser = AppSettings.DefaultBrowser;
            }
            // match action
            foreach (string appAlias in AppSettings.Applications.Keys)
            {
                if (appAlias == parts[index])
                {
                    app = AppSettings.Applications[appAlias];
                    index++;
                    break;
                }
            }
            if (app == null)
            {
                if (AppSettings.DefaultApplication == null)
                {
                    AppFunc.SendError("Brak zdefiniowanej domyślnej aplikacji");
                }
                app = AppSettings.DefaultApplication;
            }

            int argumentStart = Text.IndexOf(parts[index], 0);
            arguments = Text.Substring(argumentStart);
        }

        private static void runApp(string browser, ApplicationData app, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(browser, app.GetAddressWithParams(arguments));
            Process.Start(startInfo);
        }
    }
}
