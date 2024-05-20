namespace rania5
{
    partial class StatusPenerbangan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterBandaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMaskapaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterJadwalPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskerKodePromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahStatusPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 64);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(64, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dashboard";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.BackgroundImage = global::rania5.Properties.Resources.menu_alt_72;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(-1, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 390);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterBandaraToolStripMenuItem,
            this.masterMaskapaiToolStripMenuItem,
            this.masterJadwalPenerbanganToolStripMenuItem,
            this.maskerKodePromoToolStripMenuItem,
            this.ubahStatusPenerbanganToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(185, 390);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterBandaraToolStripMenuItem
            // 
            this.masterBandaraToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.masterBandaraToolStripMenuItem.Image = global::rania5.Properties.Resources.map_unselected_72;
            this.masterBandaraToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.masterBandaraToolStripMenuItem.Name = "masterBandaraToolStripMenuItem";
            this.masterBandaraToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterBandaraToolStripMenuItem.Text = "Master Bandara";
            this.masterBandaraToolStripMenuItem.Click += new System.EventHandler(this.masterBandaraToolStripMenuItem_Click);
            // 
            // masterMaskapaiToolStripMenuItem
            // 
            this.masterMaskapaiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.masterMaskapaiToolStripMenuItem.Image = global::rania5.Properties.Resources.plane_take_off_unselected_72;
            this.masterMaskapaiToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.masterMaskapaiToolStripMenuItem.Name = "masterMaskapaiToolStripMenuItem";
            this.masterMaskapaiToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterMaskapaiToolStripMenuItem.Text = "Master Maskapai";
            this.masterMaskapaiToolStripMenuItem.Click += new System.EventHandler(this.masterMaskapaiToolStripMenuItem_Click);
            // 
            // masterJadwalPenerbanganToolStripMenuItem
            // 
            this.masterJadwalPenerbanganToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.masterJadwalPenerbanganToolStripMenuItem.Image = global::rania5.Properties.Resources.calendar_unselected_72;
            this.masterJadwalPenerbanganToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.masterJadwalPenerbanganToolStripMenuItem.Name = "masterJadwalPenerbanganToolStripMenuItem";
            this.masterJadwalPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterJadwalPenerbanganToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            this.masterJadwalPenerbanganToolStripMenuItem.Click += new System.EventHandler(this.masterJadwalPenerbanganToolStripMenuItem_Click);
            // 
            // maskerKodePromoToolStripMenuItem
            // 
            this.maskerKodePromoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.maskerKodePromoToolStripMenuItem.Image = global::rania5.Properties.Resources.purchase_tag_alt_unselected_72;
            this.maskerKodePromoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.maskerKodePromoToolStripMenuItem.Name = "maskerKodePromoToolStripMenuItem";
            this.maskerKodePromoToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.maskerKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            this.maskerKodePromoToolStripMenuItem.Click += new System.EventHandler(this.maskerKodePromoToolStripMenuItem_Click);
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            this.ubahStatusPenerbanganToolStripMenuItem.Image = global::rania5.Properties.Resources.notepad_selected_72;
            this.ubahStatusPenerbanganToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            this.ubahStatusPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah Status Penerbangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Anda bisa mengubah status jadwal penerbangan di sni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ubah Status Penerbangan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(205, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1013, 262);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sesuai Jadwal"});
            this.comboBox1.Location = new System.Drawing.Point(264, 415);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1132, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Simpan";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1042, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Batal";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(50, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Logout";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::rania5.Properties.Resources.log_out_unselected_72;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(11, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 32);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode Penerbangan";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Maskapai";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bandara Keberangkatan";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bandara Tujuan";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tanggal Keberangkatan";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Waktu Keberangkatan";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Durasi Penerbangan";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Status Terakhir";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Terakhir Diubah";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column10.Text = "Ubah";
            this.Column10.UseColumnTextForButtonValue = true;
            // 
            // StatusPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StatusPenerbangan";
            this.Text = "StatusPenerbangan";
            this.Load += new System.EventHandler(this.StatusPenerbangan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterBandaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMaskapaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskerKodePromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
    }
}