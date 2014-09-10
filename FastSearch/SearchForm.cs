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
            (new AppSettings()).LoadSettings();
            SetUserSettings();
        }

        private void SetUserSettings()
        {
            AppSettings.AlfaSwitch = AppSettings.DefaultAlfaSwitch;
            SetOpacity();
            
            TestData();
        }

        private void TestData()
        {
            AppSettings.Applications.Clear();
            AppSettings.Applications.Add("c", @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
            AppSettings.Applications.Add("o", @"C:\Program Files (x86)\Opera\opera.exe");
            AppSettings.DefaultApplication = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";

            AppSettings.Args.Clear();
            AppSettings.Args.Add("tpa", new AplicationArgsData(@"https://translate.google.pl/#pl/en/", "Tłumacz Polski-Angielski", true));
            AppSettings.Args.Add("tap", new AplicationArgsData(@"https://translate.google.pl/#en/pl/", "Tłumacz Angielski-Polski", true));
            AppSettings.DefaultArgs = new AplicationArgsData(@"https://translate.google.pl/#pl/en/", "Tłumacz Polski-Angielski", true);
        }


        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Balfa_Click(object sender, EventArgs e)
        {
            AppSettings.AlfaSwitch = !AppSettings.AlfaSwitch;
            SetOpacity();
        }

        private void SetOpacity()
        {
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
