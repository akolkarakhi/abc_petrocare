using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class adminAuth : Form
    {
        public adminAuth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register nobj = new Register();
            nobj.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home hobj = new home();
            hobj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminview vobj = new adminview();
            vobj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminview vobj = new adminview();
            vobj.Show();
            this.Hide();

        }

        private void adminAuth_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewatt vobj = new viewatt();
            vobj.Show();
            this.Hide();
        }
    }
}
