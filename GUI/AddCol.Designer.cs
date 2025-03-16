namespace GUI
{
    partial class AddCol
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Tnumber = new TextBox();
            Tname = new TextBox();
            btnAdd = new Button();
            bindingSource1 = new BindingSource(components);
            comboBox1 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = Color.Teal;
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 426);
            panel1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(82, 325);
            label5.Name = "label5";
            label5.Size = new Size(223, 33);
            label5.TabIndex = 1;
            label5.Text = "Add University";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.addon;
            pictureBox1.Location = new Point(39, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(496, 130);
            label3.Name = "label3";
            label3.Size = new Size(186, 22);
            label3.TabIndex = 15;
            label3.Text = "Number Of Student";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(496, 204);
            label2.Name = "label2";
            label2.Size = new Size(164, 22);
            label2.TabIndex = 14;
            label2.Text = "Select University";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(496, 62);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // Tnumber
            // 
            Tnumber.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tnumber.Location = new Point(496, 155);
            Tnumber.Name = "Tnumber";
            Tnumber.Size = new Size(216, 26);
            Tnumber.TabIndex = 11;
            // 
            // Tname
            // 
            Tname.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tname.Location = new Point(496, 87);
            Tname.Name = "Tname";
            Tname.Size = new Size(216, 29);
            Tname.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Teal;
            btnAdd.Location = new Point(479, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(248, 40);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add Collage";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "univ";
            comboBox1.Font = new Font("Arial Rounded MT Bold", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(496, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 26);
            comboBox1.TabIndex = 18;
            comboBox1.ValueMember = "awd";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(496, 360);
            label8.Name = "label8";
            label8.Size = new Size(216, 18);
            label8.TabIndex = 20;
            label8.Text = " ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(496, 378);
            label7.Name = "label7";
            label7.Size = new Size(216, 18);
            label7.TabIndex = 19;
            label7.Text = " ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddCol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Tnumber);
            Controls.Add(Tname);
            Controls.Add(btnAdd);
            Name = "AddCol";
            Size = new Size(800, 426);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Tnumber;
        private TextBox Tname;
        private Button btnAdd;
        private BindingSource bindingSource1;
        private ComboBox comboBox1;
        private Label label8;
        private Label label7;
    }
}
