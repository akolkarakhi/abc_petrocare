using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                adminAuth adaobj = new adminAuth();
                adaobj.Show();
                this.Hide();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home hobj = new home();
            hobj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String connectionString = null;
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            String sql;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                /*if (rd["username"].ToString() == textBox4.Text &&
                    rd["password"].ToString() == textBox3.Text)
                {
                    //redirect to user pageatt

                    MessageBox.Show("Attendance updated successfuly!");

                }
                else
                {
                    //error
                    MessageBox.Show("Enter valid userid and password");
                }*/
            }
            
        }
    }
}