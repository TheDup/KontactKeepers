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
            if (ConfigurationManager.AppSettings.Get("Fullscreen") == "0")
            {
                cbFullscreen.Checked = false;
            }
            else
            {
                cbFullscreen.Checked = true;
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

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;
                if (settings["Fullscreen"].Value == "0")
                {
                    settings["Fullscreen"].Value = "1";
                    cbDarkMode.Checked = true;
                }
                else
                {
                    settings["Fullscreen"].Value = "0";
                    cbDarkMode.Checked = false;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
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
            try
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;
                if (settings["DarkMode"].Value == "0")
                {
                    settings["DarkMode"].Value = "1";
                    cbDarkMode.Checked = true;
                }
                else
                {
                    settings["DarkMode"].Value = "0";
                    cbDarkMode.Checked = false;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
