using System;
using System.Timers;
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
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Interval = 50000; // 20 saniye
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                goster();
            });
        }

        void goster()
        {
            dataGridView1.DataSource = BLtelebel.konsertList();
            txtad.Text = "";
            txtID.Text = "";
            txtqiymet.Text = "";
            txtyer.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            goster();
        }

        private void btnelaveet_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "")
            {
                MessageBox.Show("Tələbəninin adını daxil edin");
            }
            else
            {
                Entitytel konsert = new Entitytel();
                konsert.ad_soyad = txtad.Text;
                konsert.telebe_nomresi = int.Parse(txtqiymet.Text);
                konsert.ortalamsi = int.Parse(txtyer.Text);

                BLtelebel.konsertElaveEt(konsert);
                MessageBox.Show("Qeydiyat uğurlu oldu");
            }
            goster();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show(" Silinəcək Tələbəni seçin");
            }
            else
            {
                Entitytel konsert = new Entitytel();
                konsert.id = int.Parse(txtID.Text);

                BLtelebel.konsertsil(konsert);
                MessageBox.Show("Silmə əməliyatı uğurlu oldu");
            }
            goster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtqiymet.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtyer.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "")
            {
                MessageBox.Show("Tələbənin adını daxil edin");
            }
            else
            {
                Entitytel telebe = new Entitytel();
                telebe.id = int.Parse(txtID.Text);
                telebe.ad_soyad = txtad.Text;
                telebe.telebe_nomresi = int.Parse(txtqiymet.Text);
                telebe.ortalamsi = int.Parse(txtyer.Text);
                BLtelebel.konsertGuncelle(telebe);
                MessageBox.Show("Güncəlləmə uğurlu oldu");
            }
            goster();
        }

        private void qeydiyyatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
