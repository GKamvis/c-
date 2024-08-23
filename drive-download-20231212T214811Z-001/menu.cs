using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Buissnes_layer;
using Data_access_layer;

namespace bilet_satishi
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        void goster()
        {
           // dataGridView1.DataSource = BLtelebel.konsertList();


        }

        private void qeydiyyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void satişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet5.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter1.Fill(this.dataSet5.Table_1);
            // TODO: This line of code loads data into the 'dataSet4.Table_1' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet2.Tbl_bilet' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet1.Tbl_bilet' table. You can move, or remove it, as needed.
            //this.tbl_biletTableAdapter.Fill(this.dataSet1.Tbl_bilet);

            // SQL Server-ə qoşulmaq üçün SqlConnection obyekti yaradın
            // SqlConnection conn = new SqlConnection("Server=WINDOWS-72BBIO9\\SQLEXPRESS01;Database=DBbiletsatishi1;Trusted_Connection=True;");

            // SQL Server-dən məlumatları oxumaq üçün SqlCommand obyekti yaradın
            // SqlCommand cmd = new SqlCommand("SELECT bilet_sayi FROM Tbl_bilet", conn);

            try
            {
                // Qoşulmanı açın
               // conn.Open();

                // SQL sorğusunu icra edin və nəticəni oxuyun
               // SqlDataReader reader = cmd.ExecuteReader();

                // Nəticəni DataTable-a çevirin
               // DataTable dt = new DataTable();
               // dt.Load(reader);

                // DataTable-ı DataGridView2-ə təyin edin
               // dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Xəta baş verərsə, xəta məlumatlarını konsola yazın
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                // Qoşulmanı bağlayın
             //   conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            table1BindingSource1.EndEdit();
            table_1TableAdapter1.Update(dataSet5.Table_1);


            string tableName = textBox1.Text;  // TextBox'dan alınan məlumat

            using (SqlConnection connection = new SqlConnection("server =  WINDOWS-72BBIO9\\SQLEXPRESS01; initial catalog = DBbiletsatishi1; integrated security = true  "))
            {
                connection.Open();

                string query = $@"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='{tableName}' AND xtype='U')
            CREATE TABLE {tableName}
            (
                id INT,
                ad_soyad NVARCHAR(50),
                telebe_nomresi INT,
                ortalama INT
            )";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //command.ExecuteNonQuery();
                }
            }

            //  SqlCommand comand = new SqlCommand("Create table newtable(id int, ad_soyad nvarchar(50), telebe_nomresi int, ortalama int)", sqlbaglan.baglan);

        }

        private void btnremove1_Click(object sender, EventArgs e)
        {
            table1BindingSource1.RemoveCurrent();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
