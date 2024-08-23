
namespace WindowsFormsApp2
{
    partial class Form3
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
            this.sbutton1 = new System.Windows.Forms.Button();
            this.stextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sbutton1
            // 
            this.sbutton1.Location = new System.Drawing.Point(569, 148);
            this.sbutton1.Name = "sbutton1";
            this.sbutton1.Size = new System.Drawing.Size(75, 38);
            this.sbutton1.TabIndex = 0;
            this.sbutton1.Text = "button";
            this.sbutton1.UseVisualStyleBackColor = true;
            this.sbutton1.Click += new System.EventHandler(this.sbutton1_Click);
            // 
            // stextBox1
            // 
            this.stextBox1.Location = new System.Drawing.Point(316, 148);
            this.stextBox1.Name = "stextBox1";
            this.stextBox1.Size = new System.Drawing.Size(185, 26);
            this.stextBox1.TabIndex = 1;
            this.stextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stextBox1);
            this.Controls.Add(this.sbutton1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sbutton1;
        private System.Windows.Forms.TextBox stextBox1;
    }
}