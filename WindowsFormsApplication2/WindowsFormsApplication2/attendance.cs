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
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String connectionString = null;
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(); 
            String sql,sql1,sql2,sql3 ;
            int i = 1,p;
            connectionString = ("Data Source=Amogh\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True");


            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "select username,password from register";
                cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();

                string[] ARRAYNAME = { "day1", "day2", "day3", "day4", "day5", "day6", "day7", "day8", "day9", "day10", "day11", "day12", "day13", "day14", "day15", "day16", "day17", "day18", "day19", "day20", "day21", "day22", "day23", "day24", "day25", "day26", "day27", "day28", "day29", "day30", "day31" };
	/* SET NOCOUNT ON */

                while (rd.Read())
                {
                    if (rd["username"].ToString() == textBox4.Text &&
                        rd["password"].ToString() == textBox3.Text )
                    {
                        //redirect to user pageatt
                        foreach (string A in ARRAYNAME)
                        {
                            sql2 = "(UPDATE attendance SET " + A + "=1 where username ='" + textBox4.Text + "')";
                            cmd = new SqlCommand(sql2, con);
                        }
                      MessageBox.Show("Attendance updated successfuly!");
                     
                    }
                    else
                    {
                        //error
                        MessageBox.Show("Enter valid userid and password");
                    }
                }
               /* while (rd.Read())
                {
                    int sum = 0;
                    for (p = 2; p <= 32; p++)
                    {
                       // sum = sum + rd[p];
                    }
                }
                    sql2 = "(UPDATE attendance SET " + A + "=1 where username ='" + textBox4.Text + "')";
                            cmd = new SqlCommand(sql2, con);
                */

                // sql = "INSERT INTO attendance(username) values('"+ username + "')";

                // cmd = new SqlCommand(sql, con);

               // con.Close();
               // MessageBox.Show("Submit Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!");
            }
           
            //';./';>//;.'/';';>>//';./;'.///';/cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
