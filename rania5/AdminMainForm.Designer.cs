namespace rania5
{
    partial class AdminMainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button2 = new System.Windows.Forms.Button();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMaskapaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterJadwalPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKodePromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahStatusPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 51);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 458);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 471);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(51, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logout";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterDataToolStripMenuItem,
            this.masterMaskapaiToolStripMenuItem,
            this.masterJadwalPenerbanganToolStripMenuItem,
            this.masterKodePromoToolStripMenuItem,
            this.ubahStatusPenerbanganToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(185, 469);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::rania5.Properties.Resources.log_out_unselected_72;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(12, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 32);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.Image = global::rania5.Properties.Resources.map_unselected_72;
            this.masterDataToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterDataToolStripMenuItem.Text = "Master Bandara";
            this.masterDataToolStripMenuItem.Click += new System.EventHandler(this.masterDataToolStripMenuItem_Click);
            // 
            // masterMaskapaiToolStripMenuItem
            // 
            this.masterMaskapaiToolStripMenuItem.Image = global::rania5.Properties.Resources.plane_take_off_unselected_72;
            this.masterMaskapaiToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.masterMaskapaiToolStripMenuItem.Name = "masterMaskapaiToolStripMenuItem";
            this.masterMaskapaiToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterMaskapaiToolStripMenuItem.Text = "Master Maskapai";
            this.masterMaskapaiToolStripMenuItem.Click += new System.EventHandler(this.masterMaskapaiToolStripMenuItem_Click);
            // 
            // masterJadwalPenerbanganToolStripMenuItem
            // 
            this.masterJadwalPenerbanganToolStripMenuItem.Image = global::rania5.Properties.Resources.calendar_unselected_72;
            this.masterJadwalPenerbanganToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.masterJadwalPenerbanganToolStripMenuItem.Name = "masterJadwalPenerbanganToolStripMenuItem";
            this.masterJadwalPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterJadwalPenerbanganToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            this.masterJadwalPenerbanganToolStripMenuItem.Click += new System.EventHandler(this.masterJadwalPenerbanganToolStripMenuItem_Click);
            // 
            // masterKodePromoToolStripMenuItem
            // 
            this.masterKodePromoToolStripMenuItem.Image = global::rania5.Properties.Resources.purchase_tag_alt_unselected_72;
            this.masterKodePromoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            this.masterKodePromoToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            this.masterKodePromoToolStripMenuItem.Click += new System.EventHandler(this.masterKodePromoToolStripMenuItem_Click);
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            this.ubahStatusPenerbanganToolStripMenuItem.Image = global::rania5.Properties.Resources.notepad_unselected_72;
            this.ubahStatusPenerbanganToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            this.ubahStatusPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah Status Penerbangan";
            this.ubahStatusPenerbanganToolStripMenuItem.Click += new System.EventHandler(this.ubahStatusPenerbanganToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.BackgroundImage = global::rania5.Properties.Resources.menu_alt_721;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(15, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 29);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMainForm";
            this.Text = "Bromo Airlines - Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMaskapaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}