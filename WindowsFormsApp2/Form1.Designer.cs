
namespace WindowsFormsApp2
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
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.allData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.teacherMenu,
            this.studentMenu,
            this.allData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // teacherMenu
            // 
            this.teacherMenu.Name = "teacherMenu";
            this.teacherMenu.Size = new System.Drawing.Size(86, 29);
            this.teacherMenu.Text = "Teacher";
            this.teacherMenu.Click += new System.EventHandler(this.teacherMenu_Click);
            // 
            // studentMenu
            // 
            this.studentMenu.Name = "studentMenu";
            this.studentMenu.Size = new System.Drawing.Size(89, 32);
            this.studentMenu.Text = "Student";
            this.studentMenu.Click += new System.EventHandler(this.studentMenu_Click);
            // 
            // allData
            // 
            this.allData.Name = "allData";
            this.allData.Size = new System.Drawing.Size(88, 32);
            this.allData.Text = "All data";
            this.allData.Click += new System.EventHandler(this.allData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherMenu;
        private System.Windows.Forms.ToolStripMenuItem studentMenu;
        private System.Windows.Forms.ToolStripMenuItem allData;
    }
}

