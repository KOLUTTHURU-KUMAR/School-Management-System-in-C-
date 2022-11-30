using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(DepNameTb.Text == "" || DetailsTb.Text == "")
            {
                MessageBox.Show("Please Enter the data !!");
            }
            else
            {

                SqlConnection con = new SqlConnection("data source = LAPTOP-BSSPS1N5\\SQLEXPRESS ; initial catalog = College Management System ; persist security info = True ; Integrated Security = SSPI  ");
                con.Open();
               SqlCommand cmd = new SqlCommand("insert into Department values ('" + DepNameTb.Text + "','" + DetailsTb.Text + "')" , con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");
                  con.Close();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection("data source = LAPTOP-BSSPS1N5\\SQLEXPRESS ; initial catalog = College Management System ; persist security info = True ; Integrated Security = SSPI  ");
             con.Open();
             SqlCommand cmd = new SqlCommand("Delete from Department Where DepName = '" + DepNameTb.Text + "' ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully");
             con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            SqlConnection con = new SqlConnection("data source = LAPTOP-BSSPS1N5\\SQLEXPRESS ; initial catalog = College Management System ; persist security info = True ; Integrated Security = SSPI  ");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Department ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DepartmentsList.DataSource = dt;
            con.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void StudentPage_Click(object sender, EventArgs e)
        {
            Students obj = new Students();
            obj.Show();
            this.Close();
        }
    }
}
