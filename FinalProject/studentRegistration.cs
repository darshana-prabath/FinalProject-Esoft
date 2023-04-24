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
    public partial class studentRegistration : Form
    {
        public studentRegistration()
        {
            InitializeComponent();
        }

        private void linklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure Do you really want to logout?", "Logout",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                loginForm login = new loginForm();
                login.Show();
                this.Hide();
            }

            else if (dr == DialogResult.No)
            {
                //nothing happens 
            }     
        }

        private void studentRegistration_Load(object sender, EventArgs e)
        {
            GenarateIDList();//genrate ID list for cmbRegNo
            GenarateNewID();//genrate new ID for Next Registration
        }

        private void GenarateIDList()
        {
            //Create Connection
            string connectionString = @"data source=DESKTOP-OANS3O6\SQLEXPRESS;initial catalog=Student;integrated security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = @"SELECT regNo FROM Registration GROUP BY regNo";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connection);
            SqlDataReader dataReader = adapter.SelectCommand.ExecuteReader();
            cmbRegNo.Items.Clear();


            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    cmbRegNo.Items.Add(dataReader.GetString(0));
                }
            }
            connection.Close();
        }
        
        private void GenarateNewID()
        {
            //genrate new ID for Next Registration
            string connectionString = @"data source=DESKTOP-OANS3O6\SQLEXPRESS;initial catalog=Student;integrated security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            int RegNo = 0;
            string sql = @"SELECT ISNULL(MAX(regNo),0) FROM Registration";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connection);
            SqlDataReader dataReader = adapter.SelectCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    RegNo = Convert.ToInt32(dataReader.GetString(0));
                }
            }
            cmbRegNo.Text = Convert.ToString(RegNo + 1);
        }

      

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.Text == "" ||
                txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                dtpDOB.Text == "" ||
                (rbFemale.Checked == false && rbMale.Checked == false) ||
                txtAddress.Text == "" ||
                txtEmail.Text == "" ||
                txtMobilePhone.Text == "" ||
                txtHomePhone.Text == "" ||
                txtParentName.Text == "" ||
                txtNIC.Text == "" ||
                txtContactNumber.Text == "")
            {
                MessageBox.Show("Pleace fill the all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString = @"data source=DESKTOP-OANS3O6\SQLEXPRESS;initial catalog=Student;integrated security=true";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string sql = @"INSERT INTO Registration(regNo,firstName,lastName,dateOfBirth,gender,address,email,mobilePhone,homePhone,parentName,nic,contactNo)
                          VALUES('" + cmbRegNo.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + dtpDOB.Text + "','" + gender + "'," +
                              "'" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtMobilePhone.Text + "','" + txtHomePhone.Text + "','" + txtParentName.Text + "','" + txtNIC.Text + "'," +
                              "'" + txtContactNumber.Text + "')";

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Record Added Succesfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();

                GenarateIDList();
                GenarateNewID();

                txtFirstName.Text = "";
                txtLastName.Text = "";
                dtpDOB.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtMobilePhone.Text = "";
                txtHomePhone.Text = "";
                txtParentName.Text = "";
                txtNIC.Text = "";
                txtContactNumber.Text = "";
            }
            
        }

      

        String gender = "";

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (
                cmbRegNo.Text == "" ||
                txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                dtpDOB.Text == "" ||
                (rbFemale.Checked == false && rbMale.Checked == false) ||
                txtAddress.Text == "" ||
                txtEmail.Text == "" ||
                txtMobilePhone.Text == "" ||
                txtHomePhone.Text == "" ||
                txtParentName.Text == "" ||
                txtNIC.Text == "" ||
                txtContactNumber.Text == "")
            {
                MessageBox.Show("Pleace fill the all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString = @"data source=DESKTOP-OANS3O6\SQLEXPRESS;initial catalog=Student;integrated security=true";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string sql = @"UPDATE Registration SET firstName = '" + txtFirstName.Text + "', lastName = '" + txtLastName.Text + "'," +
                        "dateOfBirth = '" + dtpDOB.Text + "', gender = '" + gender + "', address = '" + txtAddress.Text + "'," +
                        "email = '" + txtEmail.Text + "',mobilePhone= '" + txtMobilePhone.Text + "',homePhone='" + txtHomePhone.Text + "'," +
                        "parentName='" + txtParentName.Text + "',nic='" + txtNIC.Text + "',contactNo='" + txtContactNumber.Text + "'" +
                        "WHERE regNo = '" + cmbRegNo.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = new SqlCommand(sql, connection);
                adapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Record Updated Succesfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFirstName.Text = "";
                txtLastName.Text = "";
                dtpDOB.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtMobilePhone.Text = "";
                txtHomePhone.Text = "";
                txtParentName.Text = "";
                txtNIC.Text = "";
                txtContactNumber.Text = "";

                GenarateIDList();
                GenarateNewID();
            }


            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dtpDOB.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMobilePhone.Text = "";
            txtHomePhone.Text = "";
            txtParentName.Text = "";
            txtNIC.Text = "";
            txtContactNumber.Text = "";
            cmbRegNo.Text = "";

            GenarateIDList();//genrate ID list for cmbRegNo
            GenarateNewID();//genrate new ID for Next Registration

        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            viewStudents viewStudents = new viewStudents();
            viewStudents.ShowDialog();
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-OANS3O6\SQLEXPRESS;initial catalog=Student;integrated security=true";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql = @"SELECT firstName,lastName,dateOfBirth,gender,address,email,mobilePhone,homePhone,parentName,nic,contactNo FROM Registration WHERE regNo='" + cmbRegNo.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connection);
            SqlDataReader reader = adapter.SelectCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtFirstName.Text = reader.GetString(0);
                    txtLastName.Text = reader.GetString(1);
                    dtpDOB.Text = reader.GetString(2);
                    string gender = reader.GetString(3);
                    if (gender=="Male")
                    {
                        rbMale.Checked = true;
                        rbFemale.Checked = false;
                    }

                    else if (gender=="Female")
                    {
                        rbMale.Checked = false;
                        rbFemale.Checked = true;
                    }

                    txtAddress.Text = reader.GetString(4);
                    txtEmail.Text = reader.GetString(5);
                    txtMobilePhone.Text = reader.GetString(6);
                    txtHomePhone.Text = reader.GetString(7);
                    txtParentName.Text = reader.GetString(8);
                    txtNIC.Text = reader.GetString(9);
                    txtContactNumber.Text = reader.GetString(10);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-OANS3O6\SQLEXPRESS;initial catalog=Student;integrated security=true";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql = @"DELETE FROM Registration WHERE regNo='" + cmbRegNo.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = new SqlCommand(sql, connection);

            DialogResult dr = MessageBox.Show("Are you sure, Do you really want to Delete this record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                adapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Succesfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenarateIDList();
                GenarateNewID();

                txtFirstName.Text = "";
                txtLastName.Text = "";
                dtpDOB.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtMobilePhone.Text = "";
                txtHomePhone.Text = "";
                txtParentName.Text = "";
                txtNIC.Text = "";
                txtContactNumber.Text = "";
                btnDelete.Text = "Delete";
            }

            else if (dr == DialogResult.No)
            {
                //nothing happen
            }

        }

        private void gbStudentRegistration_Enter(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
