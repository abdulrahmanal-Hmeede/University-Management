using CoreLibrary;
using OperationsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class AddCol : UserControl
    {
        public AddCol()
        {
            InitializeComponent();
            comboBox1.DataSource = University.universities;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            label7.Text = "";
            try
            {
                College college = new College(Tname.Text,Convert.ToInt32(Tnumber.Text),(University)comboBox1.SelectedItem);
                label7.Text = "Add Success";
                Tnumber.Text = "";
                Tname.Text = "";
                Operation p = new Operation();
                p.AddToFile($@"Data\Colleges\{college.Name}.txt", $"Name {college.Name}, Number OfS tudent: {college.NumberOfStudent}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroor! => " + ex.Message);
                label8.Text = "Error! try agine";
            }
        }
    }
}
