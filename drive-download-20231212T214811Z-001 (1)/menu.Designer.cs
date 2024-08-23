
namespace bilet_satishi
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qeydiyyatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qrupƏlavəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblbiletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new bilet_satishi.DataSet1();
            this.tbl_biletTableAdapter = new bilet_satishi.DataSet1TableAdapters.Tbl_biletTableAdapter();
            this.dataSet2 = new bilet_satishi.DataSet2();
            this.tblbiletBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_biletTableAdapter1 = new bilet_satishi.DataSet2TableAdapters.Tbl_biletTableAdapter();
            this.dataSet4 = new bilet_satishi.DataSet4();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter = new bilet_satishi.DataSet4TableAdapters.Table_1TableAdapter();
            this.dataSet5 = new bilet_satishi.DataSet5();
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter1 = new bilet_satishi.DataSet5TableAdapters.Table_1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qrupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnremove1 = new System.Windows.Forms.Button();
            this.btnadd1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblbiletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbiletBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qeydiyyatToolStripMenuItem,
            this.satişToolStripMenuItem,
            this.qrupƏlavəEtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qeydiyyatToolStripMenuItem
            // 
            this.qeydiyyatToolStripMenuItem.Name = "qeydiyyatToolStripMenuItem";
            this.qeydiyyatToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.qeydiyyatToolStripMenuItem.Text = "Qeydiyyat";
            this.qeydiyyatToolStripMenuItem.Click += new System.EventHandler(this.qeydiyyatToolStripMenuItem_Click);
            // 
            // satişToolStripMenuItem
            // 
            this.satişToolStripMenuItem.Name = "satişToolStripMenuItem";
            this.satişToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.satişToolStripMenuItem.Text = "Tələbə";
            this.satişToolStripMenuItem.Click += new System.EventHandler(this.satişToolStripMenuItem_Click);
            // 
            // qrupƏlavəEtToolStripMenuItem
            // 
            this.qrupƏlavəEtToolStripMenuItem.Name = "qrupƏlavəEtToolStripMenuItem";
            this.qrupƏlavəEtToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.qrupƏlavəEtToolStripMenuItem.Text = "Qrup əlavə et";
            // 
            // tblbiletBindingSource
            // 
            this.tblbiletBindingSource.DataMember = "Tbl_bilet";
            this.tblbiletBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_biletTableAdapter
            // 
            this.tbl_biletTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblbiletBindingSource1
            // 
            this.tblbiletBindingSource1.DataMember = "Tbl_bilet";
            this.tblbiletBindingSource1.DataSource = this.dataSet2;
            // 
            // tbl_biletTableAdapter1
            // 
            this.tbl_biletTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.dataSet4;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource1
            // 
            this.table1BindingSource1.DataMember = "Table_1";
            this.table1BindingSource1.DataSource = this.dataSet5;
            // 
            // table_1TableAdapter1
            // 
            this.table_1TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.qrupDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(131, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(391, 149);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // qrupDataGridViewTextBoxColumn
            // 
            this.qrupDataGridViewTextBoxColumn.DataPropertyName = "qrup";
            this.qrupDataGridViewTextBoxColumn.HeaderText = "qrup";
            this.qrupDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qrupDataGridViewTextBoxColumn.Name = "qrupDataGridViewTextBoxColumn";
            this.qrupDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnremove1
            // 
            this.btnremove1.Location = new System.Drawing.Point(191, 381);
            this.btnremove1.Name = "btnremove1";
            this.btnremove1.Size = new System.Drawing.Size(83, 38);
            this.btnremove1.TabIndex = 2;
            this.btnremove1.Text = "Sil";
            this.btnremove1.UseVisualStyleBackColor = true;
            this.btnremove1.Click += new System.EventHandler(this.btnremove1_Click);
            // 
            // btnadd1
            // 
            this.btnadd1.Location = new System.Drawing.Point(78, 381);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(75, 38);
            this.btnadd1.TabIndex = 3;
            this.btnadd1.Text = "əlavə et";
            this.btnadd1.UseVisualStyleBackColor = true;
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "qrup əlavə edin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = " \r\n\r\n";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd1);
            this.Controls.Add(this.btnremove1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblbiletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbiletBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qeydiyyatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satişToolStripMenuItem;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblbiletBindingSource;
        private DataSet1TableAdapters.Tbl_biletTableAdapter tbl_biletTableAdapter;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource tblbiletBindingSource1;
        private DataSet2TableAdapters.Tbl_biletTableAdapter tbl_biletTableAdapter1;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private DataSet4TableAdapters.Table_1TableAdapter table_1TableAdapter;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private DataSet5TableAdapters.Table_1TableAdapter table_1TableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem qrupƏlavəEtToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qrupDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnremove1;
        private System.Windows.Forms.Button btnadd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}