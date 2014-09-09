using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastSearch.Common;

namespace FastSearch
{
    public partial class SearchForm : Form
    {
        private FormApp formApp = null;
        private FormConf formConf = null;



        public SearchForm()
        {
            InitializeComponent();

            UseUserSettings();
        }

        private void UseUserSettings()
        {
            AppSettings.OpacityMax = 1;
            AppSettings.OpacityMin = 0.4;
            AppSettings.AlfaSwitch = true;
            this.Opacity = AppSettings.OpacityMin;

            TestData();
        }

        private void TestData()
        {
            AppSettings.Browsers.Add("c", @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
            AppSettings.Browsers.Add("o", @"C:\Program Files (x86)\Opera\opera.exe");
            AppSettings.DefaultBrowser = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            
            AppSettings.Applications.Add("tpa", new ApplicationData(@"https://translate.google.pl/#pl/en/","Tłumacz Polski-Angielski"));
            AppSettings.Applications.Add("tap", new ApplicationData(@"https://translate.google.pl/#en/pl/","Tłumacz Angielski-Polski"));
            AppSettings.DefaultApplication = new ApplicationData(@"https://translate.google.pl/#pl/en/", "Tłumacz Polski-Angielski");
        }


        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Balfa_Click(object sender, EventArgs e)
        {
            AppSettings.AlfaSwitch = !AppSettings.AlfaSwitch;
            if (AppSettings.AlfaSwitch)
            {
                this.Text = "";
                this.Opacity = AppSettings.OpacityMin;
            }
            else
            {
                this.Text = AppSettings.FullName;
                this.Opacity = AppSettings.OpacityMax;
            }
        }

        private void BApp_Click(object sender, EventArgs e)
        {
            if (formApp == null)
            {
                formApp = new FormApp();
                formApp.Text = AppSettings.FullName.Replace(" - ", ", Aplikacje - ");
            }

            formApp.Show();
            formApp.Activate();
        }

        private void Bconf_Click(object sender, EventArgs e)
        {
            if (formConf == null)
            {
                formConf = new FormConf();
                formConf.Text = AppSettings.FullName.Replace(" - ", ", Konfiguracja - ");
            }

            formConf.Show();
            formConf.Activate();
        }

        private void TBtext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RunAction.Run(TBtext.Text, e.Control);
            }
        }
    }
}
