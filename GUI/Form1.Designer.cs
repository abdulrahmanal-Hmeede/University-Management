namespace GUI;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip1 = new MenuStrip();
        homeToolStripMenuItem = new ToolStripMenuItem();
        universitiesToolStripMenuItem = new ToolStripMenuItem();
        addUniversityToolStripMenuItem = new ToolStripMenuItem();
        showUniversitiesToolStripMenuItem = new ToolStripMenuItem();
        collegsToolStripMenuItem = new ToolStripMenuItem();
        addCollegToolStripMenuItem = new ToolStripMenuItem();
        showCollegsToolStripMenuItem = new ToolStripMenuItem();
        teachersToolStripMenuItem = new ToolStripMenuItem();
        addTeacherToolStripMenuItem = new ToolStripMenuItem();
        showTeachersToolStripMenuItem = new ToolStripMenuItem();
        panel1 = new Panel();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = Color.Teal;
        menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, universitiesToolStripMenuItem, collegsToolStripMenuItem, teachersToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 26);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // homeToolStripMenuItem
        // 
        homeToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        homeToolStripMenuItem.ForeColor = Color.White;
        homeToolStripMenuItem.Name = "homeToolStripMenuItem";
        homeToolStripMenuItem.Size = new Size(66, 22);
        homeToolStripMenuItem.Text = "Home";
        homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
        // 
        // universitiesToolStripMenuItem
        // 
        universitiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUniversityToolStripMenuItem, showUniversitiesToolStripMenuItem });
        universitiesToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
        universitiesToolStripMenuItem.ForeColor = Color.White;
        universitiesToolStripMenuItem.ImageTransparentColor = Color.FromArgb(255, 192, 192);
        universitiesToolStripMenuItem.Name = "universitiesToolStripMenuItem";
        universitiesToolStripMenuItem.Size = new Size(114, 22);
        universitiesToolStripMenuItem.Text = "Universities";
        universitiesToolStripMenuItem.Click += universitiesToolStripMenuItem_Click;
        // 
        // addUniversityToolStripMenuItem
        // 
        addUniversityToolStripMenuItem.Name = "addUniversityToolStripMenuItem";
        addUniversityToolStripMenuItem.Size = new Size(218, 22);
        addUniversityToolStripMenuItem.Text = "Add University";
        addUniversityToolStripMenuItem.Click += addUniversityToolStripMenuItem_Click;
        // 
        // showUniversitiesToolStripMenuItem
        // 
        showUniversitiesToolStripMenuItem.Name = "showUniversitiesToolStripMenuItem";
        showUniversitiesToolStripMenuItem.Size = new Size(218, 22);
        showUniversitiesToolStripMenuItem.Text = "Show Universities";
        showUniversitiesToolStripMenuItem.Click += showUniversitiesToolStripMenuItem_Click;
        // 
        // collegsToolStripMenuItem
        // 
        collegsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCollegToolStripMenuItem, showCollegsToolStripMenuItem });
        collegsToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
        collegsToolStripMenuItem.ForeColor = Color.White;
        collegsToolStripMenuItem.Name = "collegsToolStripMenuItem";
        collegsToolStripMenuItem.Size = new Size(79, 22);
        collegsToolStripMenuItem.Text = "Collegs";
        // 
        // addCollegToolStripMenuItem
        // 
        addCollegToolStripMenuItem.Name = "addCollegToolStripMenuItem";
        addCollegToolStripMenuItem.Size = new Size(183, 22);
        addCollegToolStripMenuItem.Text = "Add Colleg";
        addCollegToolStripMenuItem.Click += addCollegToolStripMenuItem_Click;
        // 
        // showCollegsToolStripMenuItem
        // 
        showCollegsToolStripMenuItem.Name = "showCollegsToolStripMenuItem";
        showCollegsToolStripMenuItem.Size = new Size(183, 22);
        showCollegsToolStripMenuItem.Text = "Show Collegs";
        // 
        // teachersToolStripMenuItem
        // 
        teachersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTeacherToolStripMenuItem, showTeachersToolStripMenuItem });
        teachersToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
        teachersToolStripMenuItem.ForeColor = Color.White;
        teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
        teachersToolStripMenuItem.Size = new Size(96, 22);
        teachersToolStripMenuItem.Text = "Teachers";
        teachersToolStripMenuItem.Click += teachersToolStripMenuItem_Click;
        // 
        // addTeacherToolStripMenuItem
        // 
        addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem";
        addTeacherToolStripMenuItem.Size = new Size(200, 22);
        addTeacherToolStripMenuItem.Text = "Add Teacher";
        // 
        // showTeachersToolStripMenuItem
        // 
        showTeachersToolStripMenuItem.Name = "showTeachersToolStripMenuItem";
        showTeachersToolStripMenuItem.Size = new Size(200, 22);
        showTeachersToolStripMenuItem.Text = "Show Teachers";
        // 
        // panel1
        // 
        panel1.BackColor = Color.White;
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 26);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 424);
        panel1.TabIndex = 1;
        panel1.Paint += panel1_Paint;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem homeToolStripMenuItem;
    private ToolStripMenuItem universitiesToolStripMenuItem;
    private ToolStripMenuItem addUniversityToolStripMenuItem;
    private ToolStripMenuItem showUniversitiesToolStripMenuItem;
    private ToolStripMenuItem collegsToolStripMenuItem;
    private ToolStripMenuItem addCollegToolStripMenuItem;
    private ToolStripMenuItem showCollegsToolStripMenuItem;
    private ToolStripMenuItem teachersToolStripMenuItem;
    private ToolStripMenuItem addTeacherToolStripMenuItem;
    private ToolStripMenuItem showTeachersToolStripMenuItem;
    private Panel panel1;
}
