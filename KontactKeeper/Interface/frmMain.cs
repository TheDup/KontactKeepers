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
using FacebookAPI;
using BusinessLogic;
using System.IO;
using DataAccess;

namespace Interface
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            btnCalls1.Click += new EventHandler(btnCalls_Click);
            btnClients1.Click += new EventHandler(btnClients_Click);
            btnContracts1.Click += new EventHandler(btnContracts_Click);
            FBConf.Login("jannesdownload09@gmail.com", "V@facebook009");
            refresh();
        }
        
        public void refresh()
        {
            Connector cn = new Connector();
            BindingSource bsA = new BindingSource();
            BindingSource bsC = new BindingSource();
            BindingSource bsE = new BindingSource();
            bsA.DataSource = cn.GetAdmins();
            bsC.DataSource = cn.GetCallAgents();
            bsE.DataSource = cn.GetEndUsers();

            dgvAdmin.DataSource = bsA;
            dgvCallAgent.DataSource = bsC;
            dgvEndUser.DataSource = bsE;

            Connector conn = new Connector(); //Addded everything here and below...

            BindingSource BsAdmin = new BindingSource();
            BsAdmin.DataSource = conn.GetAdmins();
            dgvAdmin.DataSource = BsAdmin;
            txtAAdminID.DataBindings.Clear();
            txtAAdminID.DataBindings.Add(new Binding("Text", BsAdmin, "ID"));
            txtAFName.DataBindings.Clear();
            txtAFName.DataBindings.Add(new Binding("Text", BsAdmin, "FName"));
            txtALname.DataBindings.Clear();
            txtALname.DataBindings.Add(new Binding("Text", BsAdmin, "LName"));
            txtAUname.DataBindings.Clear();
            txtAUname.DataBindings.Add(new Binding("Text", BsAdmin, "UName"));
            txtAPassword.DataBindings.Clear();
            txtAPassword.DataBindings.Add(new Binding("Text", BsAdmin, "Password"));

            BindingSource BsAgent = new BindingSource();
            BsAgent.DataSource = conn.GetCallAgents();
            dgvCallAgent.DataSource = BsAgent;
            txtCID.DataBindings.Clear();
            txtCID.DataBindings.Add(new Binding("Text", BsAgent, "ID"));
            txtCFName.DataBindings.Clear();
            txtCFName.DataBindings.Add(new Binding("Text", BsAgent, "FName"));
            txtCLName.DataBindings.Clear();
            txtCLName.DataBindings.Add(new Binding("Text", BsAgent, "LName"));
            txtCTotalCalls.DataBindings.Clear();
            txtCTotalCalls.DataBindings.Add(new Binding("Text", BsAgent, "TotalCalls"));
            txtCAgentEXT.DataBindings.Clear();
            txtCAgentEXT.DataBindings.Add(new Binding("Text", BsAgent, "AgentEXT"));
            txtCAVG.DataBindings.Clear();
            txtCAVG.DataBindings.Add(new Binding("Text", BsAgent, "AVGCallLength"));
            txtCPassword.DataBindings.Clear();
            txtCPassword.DataBindings.Add(new Binding("Text", BsAgent, "Password"));
            txtCTotalHours.DataBindings.Clear();
            txtCTotalHours.DataBindings.Add(new Binding("Text", BsAgent, "TotalHours"));
            txtCPerformance.DataBindings.Clear();
            txtCPerformance.DataBindings.Add(new Binding("Text", BsAgent, "Performance"));

            BindingSource BsEUser = new BindingSource();
            BsEUser.DataSource = conn.GetEndUsers();
            dgvEndUser.DataSource = BsEUser;
            txtEID.DataBindings.Clear();
            txtEID.DataBindings.Add(new Binding("Text", BsEUser, "ID"));
            txtEFName.DataBindings.Clear();
            txtEFName.DataBindings.Add(new Binding("Text", BsEUser, "FName"));
            txtELName.DataBindings.Clear();
            txtELName.DataBindings.Add(new Binding("Text", BsEUser, "LName"));
            txtEUsername.DataBindings.Clear();
            txtEUsername.DataBindings.Add(new Binding("Text", BsEUser, "UName"));
            txtEPassword.DataBindings.Clear();
            txtEPassword.DataBindings.Add(new Binding("Text", BsEUser, "Password"));
            txtECell.DataBindings.Clear();
            txtECell.DataBindings.Add(new Binding("Text", BsEUser, "CellNumber"));
            txtEEmail.DataBindings.Clear();
            txtEEmail.DataBindings.Add(new Binding("Text", BsEUser, "Email"));
            txtEFBID.DataBindings.Clear();
            txtEFBID.DataBindings.Add(new Binding("Text", BsEUser, "FBID")); //...until here
        }
        

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmsettings = new frmSettings();
            frmsettings.Show();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings.Get("Fullscreen") == "1")
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Fullscreen"].Value = "1";
                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");

                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Fullscreen"].Value = "0";
                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");

                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.Focus();
            panButtons.Hide();
            panAdmins.Hide();
            panCallAgents.Hide();
            panEndUsers.Hide();
            panHome.Show();
            refresh();
        }
        private void btnCalls_Click(object sender, EventArgs e)
        {
            this.ActiveControl = this.btnCalls;
            panButtons.Show();
            panAdmins.Show();
            panCallAgents.Hide();
            panEndUsers.Hide();
            panHome.Hide();
            refresh();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.ActiveControl = this.btnClients;
            panButtons.Show();
            panAdmins.Hide();
            panCallAgents.Show();
            panEndUsers.Hide();
            panHome.Hide();
            refresh();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            this.ActiveControl = this.btnContracts;
            panButtons.Show();
            panAdmins.Hide();
            panCallAgents.Hide();
            panEndUsers.Show();
            panHome.Hide();
            refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnCAAdd_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
        }

        private void dgvEndUser_CellContentClick(object sender, DataGridViewCellEventArgs e) //Added the datagridview
        {
            Admin administrator = (Admin)dgvAdmin.SelectedRows[0].DataBoundItem;
            txtAAdminID.Text = administrator.PIDAdmin.ToString();
            txtAFName.Text = administrator.FName;
            txtALname.Text = administrator.LName;
            txtAUname.Text = administrator.UName;
            txtAPassword.Text = administrator.Password;

            Agent agents = (Agent)dgvCallAgent.SelectedRows[0].DataBoundItem;
            txtCID.Text = agents.PIDAgent.ToString();
            txtCFName.Text = agents.FName;
            txtCLName.Text = agents.LName;
            txtCAgentEXT.Text = agents.AgentEXT;
            txtCTotalCalls.Text = agents.TotalCalls.ToString();

            EndUser endUser = (EndUser)dgvEndUser.SelectedRows[0].DataBoundItem;
            txtEID.Text = endUser.PIDEndUser.ToString();
            txtEFName.Text = endUser.FName;
            txtELName.Text = endUser.LName;
            txtEFBID.Text = endUser.FBID;
            txtEEmail.Text = endUser.Email;
            txtECell.Text = endUser.CellNumber;
        }
    }
}
