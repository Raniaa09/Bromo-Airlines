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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (menuStrip1.Visible == false)
            {
                menuStrip1.Visible = true;
            }
            else
            {
                menuStrip1.Visible = false;
            }
        }

        private void masterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterBandaraForm masterBandaraForm = new MasterBandaraForm();
            masterBandaraForm.ShowDialog();
        }

        private void masterMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterMaskapai masterMaskapaiForm = new MasterMaskapai();
            masterMaskapaiForm.ShowDialog();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterJadwalPenerbangan masterJadwalPenerbangan = new MasterJadwalPenerbangan();
            masterJadwalPenerbangan.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterKodePromo masterKodePromoForm = new MasterKodePromo();
            masterKodePromoForm.ShowDialog();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusPenerbangan obj = new StatusPenerbangan();
            obj.Show();
            this.Hide();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
