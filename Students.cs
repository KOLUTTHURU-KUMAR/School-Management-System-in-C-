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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // inserting the values 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please Enter the data !!");
            }
            else
            {

                SqlConnection con = new SqlConnection("data source = LAPTOP-BSSPS1N5\\SQLEXPRESS ; initial catalog = College Management System ; persist security info = True ; Integrated Security = SSPI  ");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Student values ('" + textBox1.Text + "','" + comboBox1.Text + "' ,'"+textBox2.Text+"', '"+textBox3.Text+"','"+textBox4.Text+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");
                con.Close();
            }
        }
        // updating the details by Name
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please Enter the data !!");
            }
            else
            {
                SqlConnection con = new SqlConnection("data source = LAPTOP-BSSPS1N5\\SQLEXPRESS ; initial catalog = College Management System ; persist security info = True ; Integrated Security = SSPI  ");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Student Set Gender = '" + comboBox1.Text + "' ,Phoneno = '" + textBox2.Text + "', Address = '" + textBox3.Text + "',Pname = '" + textBox4.Text + "' where Name = '" + textBox1.Text+"'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                con.Close();
            }
        }
        // deleting the data by taking name
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter the data !!");
            }
            else
            {
                SqlConnection con = new SqlConnection("data source = LAPTOP-BSSPS1N5\\SQLEXPRESS ; initial catalog = College Management System ; persist security info = True ; Integrated Security = SSPI  ");
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from  Student  where Name = '" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                con.Close();
            }
        }
        //showing the details
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = LAPTOP-BSSPS1N5\\SQLEXPRESS ; initial catalog = College Management System ; persist security info = True ; Integrated Security = SSPI  ");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DepPage_Click(object sender, EventArgs e)
        {
            Departments obj = new Departments();
            obj.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();  
        }
    }
}
