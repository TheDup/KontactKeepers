using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void Messg(string err)
        {
            MessageBox.Show(err);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool check = false;
            Connector cn = new Connector();
            List<Admin> admins = cn.GetAdmins();

            foreach (Admin item in admins)
            {
                if (txtUsername.Text == item.UName)
                {
                    if (txtPassword.Text == item.Password)
                    {
                        check = true;
                    }
                }
            }
            if (check)
            {
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect details, Try again?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtPassword.Clear();
            }
        }
    }
}
