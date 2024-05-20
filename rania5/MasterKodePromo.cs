using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rania5
{
    public partial class MasterKodePromo : Form
    {
        public MasterKodePromo()
        {
            InitializeComponent();
        }

        private void MasterKodePromo_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("BROMOAJAYUK", "15", "100000", "09-09-2023", "Yuk pakai diskonnya");
            dataGridView1.Rows.Add("NAIBROMOAIRLINES", "10", "150000", "09-09-2023", "Bromo Airlines");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, dateTimePicker1.Text, numericUpDown2.Text, numericUpDown3.Text, textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterJadwalPenerbangan form = new MasterJadwalPenerbangan();
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
