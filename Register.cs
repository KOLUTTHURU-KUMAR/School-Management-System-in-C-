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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection("data source = LAPTOP-BSSPS1N5\\SQLEXPRESS ; initial catalog = College Management System ; persist security info = True ; Integrated Security = SSPI  ");
            con.Open();
            try
            {
                if (textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBox3.Text != string.Empty)
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        SqlCommand cmd = new SqlCommand("select * from Login where username = '" + textBox1.Text + "'", con);
                        SqlDataReader rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            rd.Close();
                            MessageBox.Show("You already have account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            rd.Close();
                            cmd = new SqlCommand("Insert into Login values ( '" + textBox1.Text + "' , '" + textBox2.Text + "')", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your account is created succesfully . please login ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter same password and confirm password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }
    }
}
