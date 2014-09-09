using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastSearch
{
    public class ApplicationData
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

        private bool convertChars;
        public bool ConvertChars
        {
            get { return convertChars; }
            set { convertChars = value; }
        }

        public ApplicationData(string address, string name = "", bool convertChars = false)
        {
            this.address = address;
            this.name = name;
            this.convertChars = convertChars;
        }

        public string GetAddressWithParams(string arguments)
        {
            return address + arguments;
        }

        public override string ToString()
        {
            return name + ": " + address;
        }
    }
}
