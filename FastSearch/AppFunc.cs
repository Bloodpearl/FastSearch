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
    }
}
