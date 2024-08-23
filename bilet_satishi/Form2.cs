using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_layer;
using Data_access_layer;
using Buissnes_layer;

namespace bilet_satishi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
            void goster()
            {
                dataGridView2.DataSource = BLmesaj.mesajList();
                txtmesaj.Text = "";

            }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmesaj.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnal_Click(object sender, EventArgs e)
        {
            if (txtmesaj.Text == "")
            {
                MessageBox.Show("mesajı düzgün daxil edin");
            }
            else
            {
                entitymesaj mesaj = new entitymesaj();
                mesaj.mesajlar = txtmesaj.Text;


                BLmesaj.mesajElaveEt(mesaj);
                MessageBox.Show("mesajj  uğurla göndərildi");
            }
            goster();

        }

    }
}
