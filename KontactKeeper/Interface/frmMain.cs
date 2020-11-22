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

            btnAdmins1.Click += new EventHandler(btnAdmins_Click);
            btnCallAgents1.Click += new EventHandler(btnCallAgents_Click);
            btnEndUsers1.Click += new EventHandler(btnEndUsers_Click);
            refresh();
        }

        public void refresh()
        {
            Connector conn = new Connector();

            BindingSource BsAdmin = new BindingSource();
            BsAdmin.DataSource = conn.GetAdmins();
            dgvAdmin.DataSource = BsAdmin;
            txtAAdminID.DataBindings.Clear();
            txtAAdminID.DataBindings.Add(new Binding("Text", BsAdmin, "pidadmin"));
            txtAFName.DataBindings.Clear();
            txtAFName.DataBindings.Add(new Binding("Text", BsAdmin, "fname"));
            txtALname.DataBindings.Clear();
            txtALname.DataBindings.Add(new Binding("Text", BsAdmin, "lname"));
            txtAUname.DataBindings.Clear();
            txtAUname.DataBindings.Add(new Binding("Text", BsAdmin, "uname"));
            txtAPassword.DataBindings.Clear();
            txtAPassword.DataBindings.Add(new Binding("Text", BsAdmin, "password"));

            BindingSource BsAgent = new BindingSource();
            BsAgent.DataSource = conn.GetCallAgents();
            dgvCallAgent.DataSource = BsAgent;
            txtCID.DataBindings.Clear();
            txtCID.DataBindings.Add(new Binding("Text", BsAgent, "pidagent"));
            txtCFName.DataBindings.Clear();
            txtCFName.DataBindings.Add(new Binding("Text", BsAgent, "fname"));
            txtCLName.DataBindings.Clear();
            txtCLName.DataBindings.Add(new Binding("Text", BsAgent, "lname"));
            txtCUserName.DataBindings.Clear();
            txtCUserName.DataBindings.Add(new Binding("Text", BsAgent, "uname"));
            txtCPassword.DataBindings.Clear();
            txtCPassword.DataBindings.Add(new Binding("Text", BsAgent, "password"));
            txtCTotalCalls.DataBindings.Clear();
            txtCTotalCalls.DataBindings.Add(new Binding("Text", BsAgent, "totalcalls"));
            txtCAgentEXT.DataBindings.Clear();
            txtCAgentEXT.DataBindings.Add(new Binding("Text", BsAgent, "agentext"));
            txtCAVG.DataBindings.Clear();
            txtCAVG.DataBindings.Add(new Binding("Text", BsAgent, "avgcalllength"));
            txtCTotalHours.DataBindings.Clear();
            txtCTotalHours.DataBindings.Add(new Binding("Text", BsAgent, "totalhours"));
            txtCPerformance.DataBindings.Clear();
            txtCPerformance.DataBindings.Add(new Binding("Text", BsAgent, "performancescore"));

            BindingSource BsEUser = new BindingSource();
            BsEUser.DataSource = conn.GetEndUsers();
            dgvEndUser.DataSource = BsEUser;
            txtEID.DataBindings.Clear();
            txtEID.DataBindings.Add(new Binding("Text", BsEUser, "pidenduser"));
            txtEFName.DataBindings.Clear();
            txtEFName.DataBindings.Add(new Binding("Text", BsEUser, "fname"));
            txtELName.DataBindings.Clear();
            txtELName.DataBindings.Add(new Binding("Text", BsEUser, "lname"));
            txtEUName.DataBindings.Clear();
            txtEUName.DataBindings.Add(new Binding("Text", BsEUser, "uname"));
            txtEPassword.DataBindings.Clear();
            txtEPassword.DataBindings.Add(new Binding("Text", BsEUser, "password"));
            txtECell.DataBindings.Clear();
            txtECell.DataBindings.Add(new Binding("Text", BsEUser, "cellnumber"));
            txtEEmail.DataBindings.Clear();
            txtEEmail.DataBindings.Add(new Binding("Text", BsEUser, "email"));
            txtEFBID.DataBindings.Clear();
            txtEFBID.DataBindings.Add(new Binding("Text", BsEUser, "fbid"));

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
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            if (ConfigurationManager.AppSettings.Get("DarkMode") == "1")
            {
                panHome.BackColor = Color.Black;
                panEndUsers.BackColor = Color.Black;
                panAdmins.BackColor = Color.Black;
                panCallAgents.BackColor = Color.Black;
            }
            else
            {
                panHome.BackColor = Color.White;
                panEndUsers.BackColor = Color.White;
                panAdmins.BackColor = Color.White;
                panCallAgents.BackColor = Color.White;
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
        private void btnAdmins_Click(object sender, EventArgs e)
        {
            this.ActiveControl = this.btnAdmins;
            panButtons.Show();
            panAdmins.Show();
            panCallAgents.Hide();
            panEndUsers.Hide();
            panHome.Hide();
            refresh();
        }

        private void btnCallAgents_Click(object sender, EventArgs e)
        {
            this.ActiveControl = this.btnCallAgents;
            panButtons.Show();
            panAdmins.Hide();
            panCallAgents.Show();
            panEndUsers.Hide();
            panHome.Hide();
            refresh();
        }

        private void btnEndUsers_Click(object sender, EventArgs e)
        {
            this.ActiveControl = this.btnEndUsers;
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
        private void btnCAAdd_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            cn.AddAdmin(txtAFName.Text, txtALname.Text, txtAUname.Text, txtAPassword.Text);
            refresh();
            KontactKeepers.EmailConf ec = new KontactKeepers.EmailConf();
            if (txtEEmail.Text.Length > 1)
            {
                ec.SendActivityEmail(txtEEmail.Text);
            }
        }
        private void btnADelete_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            cn.DeleteAdmin(txtAAdminID.Text);
            refresh();
        }

        private void btnAUpdate_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            cn.UpdateAdmin(txtAAdminID.Text, txtAFName.Text, txtALname.Text, txtAUname.Text, txtAPassword.Text);
            refresh();
            KontactKeepers.EmailConf ec = new KontactKeepers.EmailConf();
            if (txtEEmail.Text.Length > 1)
            {
                ec.SendActivityEmail(txtEEmail.Text);
            }
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            cn.AddCallAgent(txtCFName.Text, txtCLName.Text, txtCUserName.Text, txtCPassword.Text, int.Parse(txtCTotalHours.Text), txtCAgentEXT.Text, txtCAVG.Text, int.Parse(txtCTotalCalls.Text), int.Parse(txtCPerformance.Text));
            refresh();
            KontactKeepers.EmailConf ec = new KontactKeepers.EmailConf();
            if (txtEEmail.Text.Length > 1)
            {
                ec.SendActivityEmail(txtEEmail.Text);
            }
        }

        private void btnCDelete_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            cn.DeleteCallAgent(txtCID.Text);
            refresh();
        }

        private void btnCUpdate_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            cn.UpdateCallAgent(int.Parse(txtCID.Text), txtCFName.Text, txtCLName.Text, txtCUserName.Text, txtCPassword.Text, int.Parse(txtCTotalHours.Text), txtCAgentEXT.Text, txtCAVG.Text, int.Parse(txtCTotalCalls.Text), int.Parse(txtCPerformance.Text));
            refresh();
            KontactKeepers.EmailConf ec = new KontactKeepers.EmailConf();
            if (txtEEmail.Text.Length > 1)
            {
                ec.SendActivityEmail(txtEEmail.Text);
            }
        }

        private void btnEAdd_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            cn.AddEndUser(txtEFName.Text, txtELName.Text, txtEUName.Text, txtEPassword.Text, txtECell.Text, false, txtEEmail.Text, false, txtEFBID.Text, false);
            refresh();
            KontactKeepers.EmailConf ec = new KontactKeepers.EmailConf();
            if (txtEEmail.Text.Length > 1)
            {
                ec.SendActivityEmail(txtEEmail.Text);
            }
        }

        private void btnEDelete_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            cn.DeleteEndUser(txtEID.Text);
            refresh();
        }

        private void btnEUpdate_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            cn.UpdateEndUser(txtEID.Text, txtEFName.Text, txtELName.Text, txtEUName.Text, txtEPassword.Text, txtECell.Text, false, txtEEmail.Text, false, txtEFBID.Text, false);
            refresh();
        }
    }
}
