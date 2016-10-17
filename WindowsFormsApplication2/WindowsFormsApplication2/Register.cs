using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Register : Form
    {


        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox2, "Please fill this section.");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname, mname, lname, addrs, contno, tele, email, username, passd;
            String connectionString = null;
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            String sql,sql1;
            connectionString = ("Data Source=Amogh\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True");
           //try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                fname = textBox1.Text;
                mname = textBox2.Text;
                lname = textBox3.Text;
                addrs = textBox4.Text;
                contno = textBox5.Text;
                tele = textBox6.Text;
                email = textBox7.Text;
                username = textBox8.Text;
                passd = textBox9.Text;
              
                // sql="insert into register values('abd','abd','zxy',"
              //sql = "INSERT INTO register values('" + fname + "','" + mname + "','" + lname + "','" + addrs + "'," + contno + "," + tele + ",'" + email + "','" + username + "','" + passd + "')";
                sql = "INSERT INTO register values('" + fname + "','" + mname + "','" + lname + "','" + addrs + "'," + contno + "," + tele + ",'" + email + "','" + username + "','" + passd + "')";
                cmd = new SqlCommand(sql, con); 
               /* 
                sql1 = "INSERT INTO attendance(username) values('"+ username + "')";
                cmd = new SqlCommand(sql1, con); */
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Submit Successful!");
            }
          // catch (Exception ex)
            {
                MessageBox.Show("Cannot insert ! Error occurs");
            } 



        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home hobj = new home();
            hobj.Show();
            this.Hide();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please fill this section.");
            }
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please fill this section.");
            }
            

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1,"You must fill this section");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                errorProvider3.SetError(textBox3, "Please fill this section.");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                errorProvider4.SetError(textBox4, "Please fill this section.");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                errorProvider5.SetError(textBox5, "Please fill this section.");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                errorProvider7.SetError(textBox7, "Please fill this section.");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                errorProvider8.SetError(textBox8, "Please fill this section.");
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                errorProvider9.SetError(textBox9, "Please fill this section.");
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != textBox9.Text )
            {
                errorProvider10.SetError(textBox10, "Password and Confirm password must be same");
            }
            else
            {
                errorProvider10.Clear();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        /*   private interface openFileDialog1_FileOk (object sender, CancelEventArgs e)
           {

           } */

        /* private void Register_Load(object sender, EventArgs e)
         {

         } */
    }

}