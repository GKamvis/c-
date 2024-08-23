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
using Entity_layer;

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
            dataGridView1.DataSource = BLqruplar.qrupList();
            txtqrup.Text = "";
          
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

            goster();
            // TODO: This line of code loads data into the 'dataSet5.Table_1' table. You can move, or remove it, as needed.
           // this.table_1TableAdapter1.Fill(this.dataSet5.Table_1);
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

            if (txtqrup.Text == "")
            {
                MessageBox.Show("Qrupun adını daxil edin");
            }
            else
            {
                entityqrup qrup = new entityqrup();
                qrup.qruplar = txtqrup.Text;
              

                BLqruplar.qrupElaveEt(qrup);
                MessageBox.Show("Qeydiyat uğurlu oldu");
            }
            goster();


        }

        private void btnremove1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
    }
}
