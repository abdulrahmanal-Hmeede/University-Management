using CoreLibrary;
using OperationsLibrary;

namespace GUI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        LoadPage(new Home());

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    private void LoadPage(UserControl page)
    {
        panel1.Controls.Clear();  //حضف الصفحة الحالية
        page.Dock = DockStyle.Fill;
        panel1.Controls.Add(page); // إضافة الصفحة الجديدة
    }
    private void addUniversityToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LoadPage(new AddUniv());
    }


    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void homeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LoadPage(new Home());
    }

    private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void universitiesToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void showUniversitiesToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void addCollegToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LoadPage(new AddCol());
    }
}
