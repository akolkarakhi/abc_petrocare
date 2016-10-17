using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class viewatt : Form
    {
        public viewatt()
        {
            InitializeComponent();
        }

        private void viewatt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet2.attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.databaseDataSet2.attendance);

        }
    }
}
