
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5S = new System.Windows.Forms.TextBox();
            this.textBox4S = new System.Windows.Forms.TextBox();
            this.textBox2S = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox5S
            // 
            this.textBox5S.Location = new System.Drawing.Point(326, 278);
            this.textBox5S.Multiline = true;
            this.textBox5S.Name = "textBox5S";
            this.textBox5S.Size = new System.Drawing.Size(100, 26);
            this.textBox5S.TabIndex = 17;
            // 
            // textBox4S
            // 
            this.textBox4S.Location = new System.Drawing.Point(326, 216);
            this.textBox4S.Multiline = true;
            this.textBox4S.Name = "textBox4S";
            this.textBox4S.Size = new System.Drawing.Size(100, 26);
            this.textBox4S.TabIndex = 16;
            // 
            // textBox2S
            // 
            this.textBox2S.Location = new System.Drawing.Point(326, 159);
            this.textBox2S.Multiline = true;
            this.textBox2S.Name = "textBox2S";
            this.textBox2S.Size = new System.Drawing.Size(100, 26);
            this.textBox2S.TabIndex = 15;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(326, 94);
            this.textBoxS.Multiline = true;
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(100, 26);
            this.textBoxS.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sub";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "First name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5S);
            this.Controls.Add(this.textBox4S);
            this.Controls.Add(this.textBox2S);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5S;
        private System.Windows.Forms.TextBox textBox4S;
        private System.Windows.Forms.TextBox textBox2S;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}