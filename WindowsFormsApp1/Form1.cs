using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Muellim və Telebe sinifləri
        public class Muellim
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Sub { get; set; }
        }

        public class Telebe
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Fac { get; set; }
        }

        // Muellim və Telebe siyahıları
        private List<Muellim> muellimler = new List<Muellim>();
        private List<Telebe> telebeler = new List<Telebe>();

        // Muellim və Telebe eventləri
        public event EventHandler<Muellim> MuellimElaveEdildi;
        public event EventHandler<Telebe> TelebeElaveEdildi;

        // Cədvəlləri yeniləmək üçün metodlar
        private void UpdateDataGridView1()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = muellimler;
        }

        private void UpdateDataGridView2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = telebeler;
        }

        // Yeni formaları açmaq üçün buttonlar
        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            // Ötürmüş olduğumuz MuellimElaveEdildi eventini Form2-dan çağıracağıq.
            var form2 = new Form2(MuellimElaveEdildi);
            form2.Show();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            // Ötürmüş olduğumuz TelebeElaveEdildi eventini Form3-dan çağıracağıq.
            var form3 = new Form3(TelebeElaveEdildi);
            form3.Show();
        }

        // MenuStrip komponentinin event handler-ləri
        private void TeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Burada müəllim əlavə etmək üçün Form2-ni açmaq lazımdır.
            var form2 = new Form2(MuellimElaveEdildi);
            form2.Show();
        }

        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Burada tələbə əlavə etmək üçün Form3-nü açmaq lazımdır.
            var form3 = new Form3(TelebeElaveEdildi);
            form3.Show();
        }

        // DataGridView komponentlərinin event handler-ləri
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Burada dataGridView1-də hüceyrələr kliklendi zaman nə etmək lazımdır.
            // Məsələn, seçilmiş müəllimin məlumatlarını göstərmek vë ya silmëk.
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Burada dataGridView2-dë hüceyrëler kliklendi zaman në etmëk lazımdır.
            // Mësëlen, seçilmiş tëlëbënin mëlumatlarını göstërmëk vë ya silmëk.
        }

    }
}