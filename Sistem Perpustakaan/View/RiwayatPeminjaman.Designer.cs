namespace Sistem_Perpustakaan.View
{
    partial class RiwayatPeminjaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatPeminjaman));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_rwypjm = new System.Windows.Forms.Button();
            this.btn_pinjambuku = new System.Windows.Forms.Button();
            this.btn_daftarbuku = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_logo2 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_kembalikan = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_riwayat = new System.Windows.Forms.DataGridView();
            this.btn_dasboard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_riwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 38);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Library Management Sysytem";
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.Location = new System.Drawing.Point(961, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(18, 18);
            this.lbl_close.TabIndex = 21;
            this.lbl_close.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_dasboard);
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.btn_rwypjm);
            this.panel2.Controls.Add(this.btn_pinjambuku);
            this.panel2.Controls.Add(this.btn_daftarbuku);
            this.panel2.Controls.Add(this.lbl_user);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox_logo2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 505);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(15, 461);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(170, 32);
            this.btn_logout.TabIndex = 30;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_rwypjm
            // 
            this.btn_rwypjm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rwypjm.ForeColor = System.Drawing.Color.White;
            this.btn_rwypjm.Location = new System.Drawing.Point(15, 330);
            this.btn_rwypjm.Name = "btn_rwypjm";
            this.btn_rwypjm.Size = new System.Drawing.Size(170, 32);
            this.btn_rwypjm.TabIndex = 29;
            this.btn_rwypjm.Text = "Riwayat Peminjaman";
            this.btn_rwypjm.UseVisualStyleBackColor = true;
            // 
            // btn_pinjambuku
            // 
            this.btn_pinjambuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pinjambuku.ForeColor = System.Drawing.Color.White;
            this.btn_pinjambuku.Location = new System.Drawing.Point(12, 283);
            this.btn_pinjambuku.Name = "btn_pinjambuku";
            this.btn_pinjambuku.Size = new System.Drawing.Size(170, 32);
            this.btn_pinjambuku.TabIndex = 27;
            this.btn_pinjambuku.Text = "Pinjam Buku";
            this.btn_pinjambuku.UseVisualStyleBackColor = true;
            // 
            // btn_daftarbuku
            // 
            this.btn_daftarbuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_daftarbuku.ForeColor = System.Drawing.Color.White;
            this.btn_daftarbuku.Location = new System.Drawing.Point(12, 235);
            this.btn_daftarbuku.Name = "btn_daftarbuku";
            this.btn_daftarbuku.Size = new System.Drawing.Size(170, 32);
            this.btn_daftarbuku.TabIndex = 26;
            this.btn_daftarbuku.Text = "Daftar Buku";
            this.btn_daftarbuku.UseVisualStyleBackColor = true;
            this.btn_daftarbuku.Click += new System.EventHandler(this.btn_daftarbuku_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(106, 131);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(38, 15);
            this.lbl_user.TabIndex = 25;
            this.lbl_user.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ussername :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Users Portal";
            // 
            // pictureBox_logo2
            // 
            this.pictureBox_logo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo2.BackgroundImage")));
            this.pictureBox_logo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logo2.Location = new System.Drawing.Point(55, 31);
            this.pictureBox_logo2.Name = "pictureBox_logo2";
            this.pictureBox_logo2.Size = new System.Drawing.Size(70, 60);
            this.pictureBox_logo2.TabIndex = 12;
            this.pictureBox_logo2.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.btn_kembalikan);
            this.guna2Panel1.Controls.Add(this.dgv_riwayat);
            this.guna2Panel1.Location = new System.Drawing.Point(219, 62);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(618, 431);
            this.guna2Panel1.TabIndex = 6;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Location = new System.Drawing.Point(17, 19);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(582, 40);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btn_kembalikan
            // 
            this.btn_kembalikan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_kembalikan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_kembalikan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_kembalikan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_kembalikan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kembalikan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_kembalikan.ForeColor = System.Drawing.Color.White;
            this.btn_kembalikan.Location = new System.Drawing.Point(17, 381);
            this.btn_kembalikan.Name = "btn_kembalikan";
            this.btn_kembalikan.Size = new System.Drawing.Size(124, 38);
            this.btn_kembalikan.TabIndex = 1;
            this.btn_kembalikan.Text = "Kembalikan";
            this.btn_kembalikan.Click += new System.EventHandler(this.btn_kembalikan_Click);
            // 
            // dgv_riwayat
            // 
            this.dgv_riwayat.BackgroundColor = System.Drawing.Color.White;
            this.dgv_riwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_riwayat.Location = new System.Drawing.Point(17, 79);
            this.dgv_riwayat.Name = "dgv_riwayat";
            this.dgv_riwayat.Size = new System.Drawing.Size(582, 281);
            this.dgv_riwayat.TabIndex = 0;
            this.dgv_riwayat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_dasboard
            // 
            this.btn_dasboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dasboard.ForeColor = System.Drawing.Color.White;
            this.btn_dasboard.Location = new System.Drawing.Point(12, 188);
            this.btn_dasboard.Name = "btn_dasboard";
            this.btn_dasboard.Size = new System.Drawing.Size(170, 31);
            this.btn_dasboard.TabIndex = 32;
            this.btn_dasboard.Text = "Dashboard";
            this.btn_dasboard.UseVisualStyleBackColor = true;
            this.btn_dasboard.Click += new System.EventHandler(this.btn_dasboard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Riwayat Peminjaman";
            // 
            // RiwayatPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 505);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "RiwayatPeminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RiwayatPeminjaman";
            this.Load += new System.EventHandler(this.RiwayatPeminjaman_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_riwayat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_rwypjm;
        private System.Windows.Forms.Button btn_pinjambuku;
        private System.Windows.Forms.Button btn_daftarbuku;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_logo2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dgv_riwayat;
        private Guna.UI2.WinForms.Guna2Button btn_kembalikan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Button btn_dasboard;
        private System.Windows.Forms.Label label4;
    }
}