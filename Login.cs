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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                 SqlConnection con = new SqlConnection("data source = LAPTOP-BSSPS1N5\\SQLEXPRESS ; initial catalog = College Management System ; persist security info = True ; Integrated Security = SSPI  ");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Login  where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Students hm = new Students();
                    hm.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No user existing please make Registration !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all blanks ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
