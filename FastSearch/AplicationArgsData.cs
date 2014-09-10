using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastSearch.Common;

namespace FastSearch
{
    public class AplicationArgsData
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private bool escapeChars;
        public bool EscapeChars
        {
            get { return escapeChars; }
            set { escapeChars = value; }
        }

        public AplicationArgsData(string address, string name = "", bool escapeChars = false)
        {
            this.address = address;
            this.name = name;
            this.escapeChars = escapeChars;
        }

        public string GetAddressWithParams(string arguments)
        {
            string arg;
            if (escapeChars)
            {
                arg = AppFunc.EscaoeChars(arguments);
            }
            else
            {
                arg = arguments;
            }
            return address + arg;
        }

        public override string ToString()
        {
            return name + ": " + address;
        }
    }
}
