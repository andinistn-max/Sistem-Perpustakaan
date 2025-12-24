namespace Sistem_Perpustakaan.View
{
    partial class Dassboard_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dassboard_Admin));
            this.pnl_atas = new System.Windows.Forms.Panel();
            this.lbl_judul = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.pnl_pinggir = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_tp = new System.Windows.Forms.Button();
            this.btn_laporan = new System.Windows.Forms.Button();
            this.btn_datauser = new System.Windows.Forms.Button();
            this.btn_databuku = new System.Windows.Forms.Button();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_logo2 = new System.Windows.Forms.PictureBox();
            this.pnl_atas.SuspendLayout();
            this.pnl_pinggir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_atas
            // 
            this.pnl_atas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnl_atas.Controls.Add(this.lbl_judul);
            this.pnl_atas.Controls.Add(this.lbl_close);
            this.pnl_atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_atas.Location = new System.Drawing.Point(0, 0);
            this.pnl_atas.Name = "pnl_atas";
            this.pnl_atas.Size = new System.Drawing.Size(899, 33);
            this.pnl_atas.TabIndex = 0;
            // 
            // lbl_judul
            // 
            this.lbl_judul.AutoSize = true;
            this.lbl_judul.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_judul.Location = new System.Drawing.Point(12, 9);
            this.lbl_judul.Name = "lbl_judul";
            this.lbl_judul.Size = new System.Drawing.Size(244, 18);
            this.lbl_judul.TabIndex = 22;
            this.lbl_judul.Text = "Library Management Sysytem";
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
            // pnl_pinggir
            // 
            this.pnl_pinggir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_pinggir.Controls.Add(this.btn_logout);
            this.pnl_pinggir.Controls.Add(this.btn_tp);
            this.pnl_pinggir.Controls.Add(this.btn_laporan);
            this.pnl_pinggir.Controls.Add(this.btn_datauser);
            this.pnl_pinggir.Controls.Add(this.btn_databuku);
            this.pnl_pinggir.Controls.Add(this.lbl_admin);
            this.pnl_pinggir.Controls.Add(this.label3);
            this.pnl_pinggir.Controls.Add(this.label2);
            this.pnl_pinggir.Controls.Add(this.pictureBox_logo2);
            this.pnl_pinggir.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_pinggir.Location = new System.Drawing.Point(0, 33);
            this.pnl_pinggir.Name = "pnl_pinggir";
            this.pnl_pinggir.Size = new System.Drawing.Size(200, 492);
            this.pnl_pinggir.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(6, 442);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(182, 32);
            this.btn_logout.TabIndex = 30;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_tp
            // 
            this.btn_tp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tp.ForeColor = System.Drawing.Color.White;
            this.btn_tp.Location = new System.Drawing.Point(6, 271);
            this.btn_tp.Name = "btn_tp";
            this.btn_tp.Size = new System.Drawing.Size(182, 31);
            this.btn_tp.TabIndex = 29;
            this.btn_tp.Text = "Transaksi Peminjaman";
            this.btn_tp.UseVisualStyleBackColor = true;
            this.btn_tp.Click += new System.EventHandler(this.btn_tp_Click);
            // 
            // btn_laporan
            // 
            this.btn_laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_laporan.ForeColor = System.Drawing.Color.White;
            this.btn_laporan.Location = new System.Drawing.Point(6, 308);
            this.btn_laporan.Name = "btn_laporan";
            this.btn_laporan.Size = new System.Drawing.Size(182, 27);
            this.btn_laporan.TabIndex = 28;
            this.btn_laporan.Text = "Laporan";
            this.btn_laporan.UseVisualStyleBackColor = true;
            this.btn_laporan.Click += new System.EventHandler(this.btn_laporan_Click);
            // 
            // btn_datauser
            // 
            this.btn_datauser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datauser.ForeColor = System.Drawing.Color.White;
            this.btn_datauser.Location = new System.Drawing.Point(6, 237);
            this.btn_datauser.Name = "btn_datauser";
            this.btn_datauser.Size = new System.Drawing.Size(182, 28);
            this.btn_datauser.TabIndex = 27;
            this.btn_datauser.Text = "Data User";
            this.btn_datauser.UseVisualStyleBackColor = true;
            this.btn_datauser.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_databuku
            // 
            this.btn_databuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_databuku.ForeColor = System.Drawing.Color.White;
            this.btn_databuku.Location = new System.Drawing.Point(6, 203);
            this.btn_databuku.Name = "btn_databuku";
            this.btn_databuku.Size = new System.Drawing.Size(182, 28);
            this.btn_databuku.TabIndex = 26;
            this.btn_databuku.Text = "Kelola Buku";
            this.btn_databuku.UseVisualStyleBackColor = true;
            this.btn_databuku.Click += new System.EventHandler(this.btn_databuku_Click);
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.White;
            this.lbl_admin.Location = new System.Drawing.Point(106, 131);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(48, 15);
            this.lbl_admin.TabIndex = 25;
            this.lbl_admin.Text = "Admin";
            this.lbl_admin.Click += new System.EventHandler(this.label4_Click);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Admin\'s Portal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox_logo2
            // 
            this.pictureBox_logo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo2.BackgroundImage")));
            this.pictureBox_logo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logo2.Location = new System.Drawing.Point(64, 29);
            this.pictureBox_logo2.Name = "pictureBox_logo2";
            this.pictureBox_logo2.Size = new System.Drawing.Size(64, 62);
            this.pictureBox_logo2.TabIndex = 12;
            this.pictureBox_logo2.TabStop = false;
            this.pictureBox_logo2.Click += new System.EventHandler(this.pictureBox_logo2_Click);
            // 
            // Dassboard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 525);
            this.Controls.Add(this.pnl_pinggir);
            this.Controls.Add(this.pnl_atas);
            this.Name = "Dassboard_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dassboard_Admin";
            this.Load += new System.EventHandler(this.Dassboard_Admin_Load);
            this.pnl_atas.ResumeLayout(false);
            this.pnl_atas.PerformLayout();
            this.pnl_pinggir.ResumeLayout(false);
            this.pnl_pinggir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_atas;
        private System.Windows.Forms.Panel pnl_pinggir;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_judul;
        private System.Windows.Forms.PictureBox pictureBox_logo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tp;
        private System.Windows.Forms.Button btn_laporan;
        private System.Windows.Forms.Button btn_datauser;
        private System.Windows.Forms.Button btn_databuku;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Button btn_logout;
    }
}