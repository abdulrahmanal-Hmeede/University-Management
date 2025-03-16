using CoreLibrary;
using OperationsLibrary;
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
    public partial class AddUniv : UserControl
    {
        public AddUniv()
        {
            InitializeComponent();
        }

        private void Page2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label6.Text = "";
            try
            {
                University university = new University(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text);
                label4.Text = "Add Success";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                Operation p = new Operation();
                p.AddToFile($@"Data\Universities\{university.Name}.txt", $"Name {university.Name}, UniversityOpeningYear: {university.UniversityOpeningYear} , Type : {university.type}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroor! => " + ex.Message);
                label6.Text = "Error! try agine";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
