
namespace bilet_satishi
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtqiymet = new System.Windows.Forms.TextBox();
            this.txtyer = new System.Windows.Forms.TextBox();
            this.btnelaveet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btngoster = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.konsertQeydiyyatıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(657, 390);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tələbənin adı və soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tələbə nömrəsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(798, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ortalaması";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(916, 68);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 26);
            this.txtad.TabIndex = 5;
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            // 
            // txtqiymet
            // 
            this.txtqiymet.Location = new System.Drawing.Point(916, 118);
            this.txtqiymet.Name = "txtqiymet";
            this.txtqiymet.Size = new System.Drawing.Size(100, 26);
            this.txtqiymet.TabIndex = 6;
            // 
            // txtyer
            // 
            this.txtyer.Location = new System.Drawing.Point(916, 166);
            this.txtyer.Name = "txtyer";
            this.txtyer.Size = new System.Drawing.Size(100, 26);
            this.txtyer.TabIndex = 7;
            // 
            // btnelaveet
            // 
            this.btnelaveet.Location = new System.Drawing.Point(839, 284);
            this.btnelaveet.Name = "btnelaveet";
            this.btnelaveet.Size = new System.Drawing.Size(82, 36);
            this.btnelaveet.TabIndex = 8;
            this.btnelaveet.Text = "Əlavə et";
            this.btnelaveet.UseVisualStyleBackColor = true;
            this.btnelaveet.Click += new System.EventHandler(this.btnelaveet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(975, 284);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(91, 36);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(839, 366);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(82, 36);
            this.btnguncelle.TabIndex = 10;
            this.btnguncelle.Text = "Güncəllə";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btngoster
            // 
            this.btngoster.Location = new System.Drawing.Point(975, 366);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(91, 36);
            this.btngoster.TabIndex = 11;
            this.btngoster.Text = "Göstər";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(857, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(916, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 13;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konsertQeydiyyatıToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(231, 36);
            // 
            // konsertQeydiyyatıToolStripMenuItem
            // 
            this.konsertQeydiyyatıToolStripMenuItem.Name = "konsertQeydiyyatıToolStripMenuItem";
            this.konsertQeydiyyatıToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.konsertQeydiyyatıToolStripMenuItem.Text = "Konsert qeydiyyatı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 604);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnelaveet);
            this.Controls.Add(this.txtyer);
            this.Controls.Add(this.txtqiymet);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtqiymet;
        private System.Windows.Forms.TextBox txtyer;
        private System.Windows.Forms.Button btnelaveet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem konsertQeydiyyatıToolStripMenuItem;
    }
}

