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
    public partial class StatusPenerbangan : Form
    {
        public StatusPenerbangan()
        {
            InitializeComponent();
        }

        private void StatusPenerbangan_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("IU-0696", "Super Ai...", "Soekarn...", "Supadio", "21-04-2...", "07:25", "01 jam 3...", "Sesuai J...", "-", "Ubah");
            dataGridView1.Rows.Add("IU-0697", "Super Ai...", "Supadio...", "Soekarn", "27-04-2...", "09:40", "01 jam 2...", "Sesuai J...", "-", "Ubah");
            dataGridView1.Rows.Add("ID-7508", "Batik Air..", "Juanda    ", "Halim P", "22-05-....", "05:00", "01 jam 1...", "Sesuai J...", "-", "Ubah");
            dataGridView1.Rows.Add("ID-6589", "Batik Air..", "Juanda    ", "Soekarn", "22-05-....", "05:00", "01 jam 2...", "Sesuai J...", "-", "Ubah");
            dataGridView1.Rows.Add("JT-0786", "Lion Air...", "Juanda    ", "Soekarn", "22-05-....", "05:00", "01 jam 3...", "Sesuai J...", "-", "Ubah");
            dataGridView1.Rows.Add("JT-0646", "Lion Air...", "Juanda    ", "Soekarn", "22-05-....", "05:55", "01 jam 0...", "Sesuai J...", "-", "Ubah");
            dataGridView1.Rows.Add("QG-0725", "Citilink   ", "Juanda    ", "Soekarn", "22-05-....", "06:00", "01 jam 3...", "Sesuai J...", "-", "Ubah");
            dataGridView1.Rows.Add("IU-0706", "Super Ai...", "Juanda    ", "Soekarn", "22-05-....", "06:00", "00 jam ....", "Sesuai J...", "-", "Ubah");
            dataGridView1.Rows.Add("IU-0333", "Super Ai...", "Juanda    ", "Soekarn", "22-05-....", "06:00", "01 jam 2...", "Sesuai J...", "-", "Ubah");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void maskerKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterKodePromo form = new MasterKodePromo();
            form.ShowDialog();
        }
    }
}
