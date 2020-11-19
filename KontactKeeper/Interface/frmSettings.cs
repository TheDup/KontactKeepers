using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Interface
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            if (cbFullscreen.Checked)
            {
                ConfigurationManager.AppSettings.Set("FullScreen", "0");
                cbFullscreen.Checked = true;
            }
            else
            {
                ConfigurationManager.AppSettings.Set("FullScreen", "1");
                cbFullscreen.Checked = false;
            }
            this.Hide();
            this.Show();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            if (cbDarkMode.Checked)
            {
                ConfigurationManager.AppSettings.Set("DarkMode", "0");
                cbDarkMode.Checked = true;
            }
            else
            {
                ConfigurationManager.AppSettings.Set("DarkMode", "1");
                cbDarkMode.Checked = false;
            }
            this.Hide();
            this.Show();
        }

        private void frmSettings_Activated(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings.Get("Fullscreen") == "1")
            {
                cbFullscreen.Checked = true;
            }
            else
            {
                cbFullscreen.Checked = false;
            }
            if (ConfigurationManager.AppSettings.Get("DarkMode") == "1")
            {
                cbDarkMode.Checked = true;
            }
            else
            {
                cbDarkMode.Checked = false;
            }
        }
    }
}
