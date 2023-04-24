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
    public partial class viewStudents : Form
    {
        public viewStudents()
        {
            InitializeComponent();
        }

        private void viewStudents_Load(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-OANS3O6\SQLEXPRESS;initial catalog=Student;integrated security=true";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string sql = @"SELECT regNo,concat(firstName, ' ',lastName) FROM Registration";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            dataTable.Clear(); //refresh data table
            adapter.Fill(dataTable);
            dgvStudents.DataSource = dataTable;
            dgvStudents.Columns[0].Width = 30;
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];

                if (row != null)
                {
                    lblRegNo.Text = row.Cells[0].Value.ToString();
                }
            }
        }

        //this is the text change event of label reg no 
        private void lblRegNo_TextChanged(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-OANS3O6\SQLEXPRESS;initial catalog=Student;integrated security=true";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql = @"SELECT concat(firstName, ' ',lastName),dateOfBirth,gender,address,email,mobilePhone,homePhone,parentName,nic,contactNo FROM Registration WHERE regNo='" + lblRegNo.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connection);
            SqlDataReader reader = adapter.SelectCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lblName.Text = reader.GetString(0);
                    lblDoB.Text = Convert.ToDateTime(reader.GetString(1)).ToString("yyyy/MM/dd");
                    lblGender.Text = reader.GetString(2);
                    lblAddress.Text = reader.GetString(3);
                    lblEmail.Text = reader.GetString(4);
                    lblMob.Text = reader.GetString(5);
                    lblHome.Text = reader.GetString(6);
                    lblParentName.Text = reader.GetString(7);
                    lblNIC.Text = reader.GetString(8);
                    lblContactNo.Text = reader.GetString(9);
                }
            }
        }


    }
}
