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
    public partial class ListPenerbangan : Form
    {
        public ListPenerbangan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerMainForm form = new CustomerMainForm();
            form.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ListPenerbangan_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("IP-0209", "Pelita Air Seru", "Juanda", "Soekarno-Hatta", "634000", "24-05-2023", "15:10 - 16:45");
            dataGridView1.Rows.Add("IP-0203", "Pelita Air Seru", "Juanda", "Soekarno-Hatta", "684000", "24-05-2023", "19:50 - 21:25");
            dataGridView1.Rows.Add("IU-0333", "Super Air Jet", "Juanda", "Soekarno-Hatta", "725966", "24-05-2023", "06:00 - 07:25");
            dataGridView1.Rows.Add("IU-0331", "Super Air Jet", "Juanda", "Soekarno-Hatta", "725966", "24-05-2023", "08:00 - 09:25");
            dataGridView1.Rows.Add("IU-0343", "Super Air Jet", "Juanda", "Soekarno-Hatta", "725966", "24-05-2023", "16:00 - 17:30");
            dataGridView1.Rows.Add("IU-0341", "Super Air Jet", "Juanda", "Soekarno-Hatta", "725966", "24-05-2023", "17:00 - 18:30");
            dataGridView1.Rows.Add("JT-0591", "Lion Air", "Juanda", "Soekarno-Hatta", "726331", "24-05-2023", "06:15 - 07:40");
            dataGridView1.Rows.Add("JT-0573", "Lion Air", "Juanda", "Soekarno-Hatta", "726331", "24-05-2023", "07:40 - 09:05");
            dataGridView1.Rows.Add("JT-0693", "Lion Air", "Juanda", "Soekarno-Hatta", "726331", "24-05-2023", "07:55 - 09:20");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            BeliTiketForm form = new BeliTiketForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
