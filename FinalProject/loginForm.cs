using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (txtusername.Text != "" && txtpassword.Text != "")
            {
                if (txtusername.Text == "Admin" && txtpassword.Text == "Skills@123")
                {
                    MessageBox.Show("Successfully Login", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    studentRegistration srForm = new studentRegistration();
                    srForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Credentials, please check Username and Password and try again",
                                       "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtusername.Text = "";
                    txtpassword.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Invalid Login",
                                   "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (dr == DialogResult.No)
            {
                //nothing happens 
            }
        }
    }
}
