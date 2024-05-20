using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rania5
{
    public partial class MasterJadwalPenerbangan : Form
    {
        public MasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("ID-7518", "Juanda", "Halim Pras", "Batik Air", "30-05-2024", "19:55", "01 jam 1 menit", "829891");
            dataGridView1.Rows.Add("IP-0203", "Juanda", "Soekarno Hatta", "Pelita Air", "30-05-...", "19:50", "01 jam 1 menit", "684000");
            dataGridView1.Rows.Add("QG-0719", "Juanda", "Soekarno Hatta", "Citilink", "30-05-...", "19:30", "01 jam 1 menit", "1317538");
            dataGridView1.Rows.Add("QG-0173", "Juanda", "Halim Pras", "Citilink", "30-05-...", "19:00", "01 jam 1 menit", "772601");
            dataGridView1.Rows.Add("GA-0325", "Juanda", "Soekarno Hatta", "Garuda Indonesia", "30-05-...", "18:40", "01 jam 1 menit", "1536880");
            dataGridView1.Rows.Add("QG-0737", "Juanda", "Halim Pras", "Citilink", "30-05-...", "18:40", "01 jam 1 menit", "1317538");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, comboBox2, comboBox3, dateTimePicker1, textBox2, textBox3, numericUpDown1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void masterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterBandaraForm form = new MasterBandaraForm();
            form.ShowDialog();
        }

        private void masterMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterMaskapai form = new MasterMaskapai();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterKodePromo form = new MasterKodePromo();
            form.ShowDialog();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UbahStatusPenerbangan form = new UbahStatusPenerbangan();
            form.ShowDialog();
        }
    }
}
