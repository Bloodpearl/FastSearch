using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastSearch.Common
{
    public static class AppFunc
    {
        private static Dictionary<string, string> escapeMap = null;

        public static Dictionary<string, string> EscapeMap
        {
            get {
                if (escapeMap == null)
                {
                    escapeMap = new Dictionary<string, string>();

                    escapeMap.Add("ą", "%C4%85");
                    escapeMap.Add("ć", "%C4%87");
                    escapeMap.Add("ę", "%C4%99");
                    escapeMap.Add("ł", "%C5%82");
                    escapeMap.Add("ń", "%C5%84");
                    escapeMap.Add("ó", "%C3%B3");
                    escapeMap.Add("ś", "%C5%9B");
                    escapeMap.Add("ż", "%C5%BC");
                    escapeMap.Add("ź", "%C5%BA");
                    escapeMap.Add(" ", "%20");
                    escapeMap.Add("&", "%26");
                    escapeMap.Add("@", "%40");
                    escapeMap.Add("$", "%24");
                    escapeMap.Add("#", "%23");
                    escapeMap.Add("%", "%25");
                    escapeMap.Add("^", "%5E");
                    escapeMap.Add("=", "%3D");
                    escapeMap.Add("+", "%2B");
                    escapeMap.Add("[", "%5B");
                    escapeMap.Add("]", "%5D");
                    escapeMap.Add("{", "%7B");
                    escapeMap.Add("}", "%7D");
                    escapeMap.Add("\"", "%22");
                    escapeMap.Add("|", "%7C");
                    escapeMap.Add("\\", "%5C");
                    escapeMap.Add(",", "%2C");
                    escapeMap.Add("<", "%3C");
                    escapeMap.Add(">", "%3E");
                    escapeMap.Add("/", "%2F");
                    escapeMap.Add("?", "%3F");
                    escapeMap.Add("`", "%60");
                }
                return AppFunc.escapeMap; 
            }
            set { AppFunc.escapeMap = value; }
        }

        public static void SendError(string message)
        {
            SendError(new Exception(message));
        }
        public static void SendError(Exception exception)
        {
            if (AppSettings.blockOnError)
            {
                throw exception;
            }
            else
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static void Alert(string message)
        {
            MessageBox.Show(message);
        }

        public static string EscaoeChars(string text)
        {
            string output = text;
            output = output.Replace("%", EscapeMap["%"]);
            foreach (string c in EscapeMap.Keys)
            {
                if (c != "%")
                {
                    output = output.Replace(c, EscapeMap[c]);
                }
            }
            return output;
        }
    }
}
