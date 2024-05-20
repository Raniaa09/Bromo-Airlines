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
    public partial class MasterBandaraForm : Form
    {
        public MasterBandaraForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Adam Air", "PT Adam Air");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MasterBandaraForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Abdul Rachman", "MLG", "Malang", "Indonesia", "2", "Malang", "Ubah", "Hapus");
            dataGridView1.Rows.Add("Abresso", "RSK", "Manokwari", "Indonesia", "2", "Manokwari", "Ubah", "Hapus");
            dataGridView1.Rows.Add("Achmad Yani", "SRG", "Semarang", "Indonesia", "2", "Semarang", "Ubah", "Hapus");
            dataGridView1.Rows.Add("Adi Sucipto", "JOG", "Yogyakarta", "Indonesia", "2", "Yogyakarta", "Ubah", "Hapus");
            dataGridView1.Rows.Add("Adi Sumarno", "SOC", "Solo", "Indonesia", "2", "Solo", "Ubah", "Hapus");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void masterMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterMaskapai form = new MasterMaskapai();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
