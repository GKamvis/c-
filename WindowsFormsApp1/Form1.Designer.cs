
namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.toolStripMenuItem1,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 29);
            this.toolStripMenuItem1.Text = "Teacher";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.TeacherToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.StudentToolStripMenuItem_Click);
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fname,
            this.Lname,
            this.Age,
            this.Sub});
            this.dataGridView1.Location = new System.Drawing.Point(70, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(695, 168);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Fname
            // 
            this.Fname.HeaderText = "First name";
            this.Fname.MinimumWidth = 8;
            this.Fname.Name = "Fname";
            this.Fname.Width = 150;
            // 
            // Lname
            // 
            this.Lname.HeaderText = "Last name";
            this.Lname.MinimumWidth = 8;
            this.Lname.Name = "Lname";
            this.Lname.Width = 150;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.Width = 180;
            // 
            // Sub
            // 
            this.Sub.HeaderText = "Sub";
            this.Sub.MinimumWidth = 8;
            this.Sub.Name = "Sub";
            this.Sub.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SFname,
            this.SLname,
            this.Sage,
            this.SFac});
            this.dataGridView2.Location = new System.Drawing.Point(70, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(695, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // SFname
            // 
            this.SFname.HeaderText = "First name";
            this.SFname.MinimumWidth = 8;
            this.SFname.Name = "SFname";
            this.SFname.Width = 150;
            // 
            // SLname
            // 
            this.SLname.HeaderText = "Last name";
            this.SLname.MinimumWidth = 8;
            this.SLname.Name = "SLname";
            this.SLname.Width = 150;
            // 
            // Sage
            // 
            this.Sage.HeaderText = "age";
            this.Sage.MinimumWidth = 8;
            this.Sage.Name = "Sage";
            this.Sage.Width = 150;
            // 
            // SFac
            // 
            this.SFac.HeaderText = "Fac";
            this.SFac.MinimumWidth = 8;
            this.SFac.Name = "SFac";
            this.SFac.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SFac;
    }
}

