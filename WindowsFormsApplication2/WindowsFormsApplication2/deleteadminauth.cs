using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class deleteadminauth : Form
    {
        public deleteadminauth()
        {
            InitializeComponent();
        }

        private void deleteadminauth_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String username, passd;
            String connectionString = null;
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            String sql;
            connectionString = ("Data Source=Amogh\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True");
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                username = textBox1.Text;
                passd = textBox2.Text;
               
                // sql="insert into register values('abd','abd','zxy',"
                
             /*   if((textBox1.Text = sql1) && (textBox2.Text sql2))
                {
                     cmd = new SqlCommand(sql, con)              
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                        con.Close();
                MessageBox.Show("User Deleted Succesfully!");
                    sql = "(delete * from register where())";
                }
                else
                {
                    MessageBox.Show();
                }
                */
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check user id and passworsd.");
            }


        }
    }
}
