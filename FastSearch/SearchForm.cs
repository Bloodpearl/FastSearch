using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastSearch
{
    public partial class SearchForm : Form
    {
        private double version = 0.1;
        private string phrase = "Alfa";
        private string name = "Fast Search";
        private FormApp formApp = null;
        private FormConf formConf = null;

        public string FullName
        {
            get {
                string[] text = { name, "-", version.ToString(), phrase };
                return string.Join(" ", text);
            }
        }

        public bool AlfaSwitch = true;
        public double OpacityMax;
        public double OpacityMin;

        public SearchForm()
        {
            InitializeComponent();

            UseUserSettings();
        }

        private void UseUserSettings()
        {
            OpacityMax = 1;
            OpacityMin = 0.4;
            AlfaSwitch = true;
            this.Opacity = OpacityMin;
        }


        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Balfa_Click(object sender, EventArgs e)
        {
            AlfaSwitch = !AlfaSwitch;
            if (AlfaSwitch)
            {
                this.Text = "";
                this.Opacity = OpacityMin;
            }
            else
            {
                this.Text = FullName;
                this.Opacity = OpacityMax;
            }
        }

        private void BApp_Click(object sender, EventArgs e)
        {
            if (formApp == null)
            {
                formApp = new FormApp();
                formApp.Text = FullName.Replace(" - ", ", Aplikacje - ");
            }

            formApp.Show();
            formApp.Activate();
        }

        private void Bconf_Click(object sender, EventArgs e)
        {
            if (formConf == null)
            {
                formConf = new FormConf();
                formConf.Text = FullName.Replace(" - ", ", Konfiguracja - ");
            }

            formConf.Show();
            formConf.Activate();
        }
    }
}
