
namespace WindowsFormsApp2
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
            this.ttextBox = new System.Windows.Forms.TextBox();
            this.tButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ttextBox
            // 
            this.ttextBox.Location = new System.Drawing.Point(205, 126);
            this.ttextBox.Name = "ttextBox";
            this.ttextBox.Size = new System.Drawing.Size(159, 26);
            this.ttextBox.TabIndex = 0;
            // 
            // tButton
            // 
            this.tButton.Location = new System.Drawing.Point(468, 129);
            this.tButton.Name = "tButton";
            this.tButton.Size = new System.Drawing.Size(92, 40);
            this.tButton.TabIndex = 1;
            this.tButton.Text = "button1";
            this.tButton.UseVisualStyleBackColor = true;
            this.tButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tButton);
            this.Controls.Add(this.ttextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ttextBox;
        private System.Windows.Forms.Button tButton;
    }
}