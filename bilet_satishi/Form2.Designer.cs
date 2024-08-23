
namespace bilet_satishi
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnal = new System.Windows.Forms.Button();
            this.txtmesaj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(42, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(679, 302);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnal
            // 
            this.btnal.Location = new System.Drawing.Point(612, 340);
            this.btnal.Name = "btnal";
            this.btnal.Size = new System.Drawing.Size(119, 46);
            this.btnal.TabIndex = 1;
            this.btnal.Text = "Göndər";
            this.btnal.UseVisualStyleBackColor = true;
            this.btnal.Click += new System.EventHandler(this.btnal_Click);
            // 
            // txtmesaj
            // 
            this.txtmesaj.Location = new System.Drawing.Point(52, 350);
            this.txtmesaj.Name = "txtmesaj";
            this.txtmesaj.Size = new System.Drawing.Size(554, 26);
            this.txtmesaj.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmesaj);
            this.Controls.Add(this.btnal);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnal;
        private System.Windows.Forms.TextBox txtmesaj;
    }
}