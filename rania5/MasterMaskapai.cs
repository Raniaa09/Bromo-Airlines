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
    public partial class MasterMaskapai : Form
    {
        public MasterMaskapai()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MasterMaskapai_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Adam Air", "PT Adam Air", "16", "Adam Air adalah .....", "Ubah", "Hapus");
            dataGridView1.Rows.Add("Aviastar", "PT Aviastar", "12", "Aviastar adalah .....", "Ubah", "Hapus");
            dataGridView1.Rows.Add("Batavia Air", "PT Batavia Air", "6", "Batavia Air adalah ....", "Ubah", "Hapus");
            dataGridView1.Rows.Add("Batik Air", "PT Batik Air", "17", "Batik Air adalah....", "Ubah", "Hapus");
            dataGridView1.Rows.Add("Bouraq Indonesia", "PT Bouraq Indonesia", "19", "Bouraq Indonesia", "Ubah", "Hapus");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, numericUpDown1.Text, textBox3.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
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

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterJadwalPenerbangan form = new MasterJadwalPenerbangan();
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
            StatusPenerbangan form = new StatusPenerbangan();
            form.ShowDialog();
        }
    }
}
