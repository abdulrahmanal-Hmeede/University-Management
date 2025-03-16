namespace GUI
{
    partial class Home
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            not = new Label();
            noc = new Label();
            nou = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.building;
            pictureBox1.Location = new Point(94, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 318);
            label1.Name = "label1";
            label1.Size = new Size(444, 40);
            label1.TabIndex = 1;
            label1.Text = "University Administration";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(not);
            panel1.Controls.Add(noc);
            panel1.Controls.Add(nou);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(461, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 426);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // not
            // 
            not.Font = new Font("Arial Rounded MT Bold", 14.25F);
            not.ForeColor = Color.White;
            not.Location = new Point(257, 232);
            not.Name = "not";
            not.Size = new Size(63, 28);
            not.TabIndex = 8;
            not.Click += not_Click;
            // 
            // noc
            // 
            noc.Font = new Font("Arial Rounded MT Bold", 14.25F);
            noc.ForeColor = Color.White;
            noc.Location = new Point(257, 174);
            noc.Name = "noc";
            noc.Size = new Size(63, 28);
            noc.TabIndex = 7;
            noc.Click += noc_Click;
            // 
            // nou
            // 
            nou.Font = new Font("Arial Rounded MT Bold", 14.25F);
            nou.ForeColor = Color.White;
            nou.Location = new Point(257, 109);
            nou.Name = "nou";
            nou.Size = new Size(63, 23);
            nou.TabIndex = 6;
            nou.Click += nou_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.school1;
            pictureBox4.Location = new Point(13, 231);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.building1;
            pictureBox3.Location = new Point(13, 167);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.school__1_;
            pictureBox2.Location = new Point(13, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 238);
            label4.Name = "label4";
            label4.Size = new Size(195, 22);
            label4.TabIndex = 2;
            label4.Text = "Number Of Teacher:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 174);
            label3.Name = "label3";
            label3.Size = new Size(189, 22);
            label3.TabIndex = 1;
            label3.Text = "Number Of College:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 109);
            label2.Name = "label2";
            label2.Size = new Size(211, 22);
            label2.TabIndex = 0;
            label2.Text = "Number Of University:";
            label2.Click += label2_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Home";
            Size = new Size(800, 426);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        public Label nou;
        public PictureBox pictureBox3;
        public Label not;
        public Label noc;
    }
}
