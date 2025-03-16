using CoreLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            not.Text = Teacher.teachers.Count.ToString();
            noc.Text = College.colleges.Count.ToString();
            nou.Text = University.universities.Count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nou_Click(object sender, EventArgs e)
        {
            nou.Text = University.universities.Count.ToString();
        }

        private void noc_Click(object sender, EventArgs e)
        {
            noc.Text = College.colleges.Count.ToString();
        }

        private void not_Click(object sender, EventArgs e)
        {
            not.Text = Teacher.teachers.Count.ToString();
        }
    }
}
