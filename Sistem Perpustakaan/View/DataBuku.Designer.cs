namespace Sistem_Perpustakaan.View
{
    partial class DataBuku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBuku));
            this.pnl_atas = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_kiri = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_tp = new System.Windows.Forms.Button();
            this.btn_laporan = new System.Windows.Forms.Button();
            this.btn_datauser = new System.Windows.Forms.Button();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox_logo2 = new System.Windows.Forms.PictureBox();
            this.pnl_data = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_dataofbook = new System.Windows.Forms.Label();
            this.dgv_databuku = new System.Windows.Forms.DataGridView();
            this.pnl_data2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_upload = new System.Windows.Forms.Button();
            this.pictureBox_buku = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kategori = new System.Windows.Forms.TextBox();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.txt_penulis = new System.Windows.Forms.TextBox();
            this.lbl_penulis = new System.Windows.Forms.Label();
            this.txt_judulbuku = new System.Windows.Forms.TextBox();
            this.lbl_judul = new System.Windows.Forms.Label();
            this.txt_idbuku = new System.Windows.Forms.TextBox();
            this.lbl_idbuku = new System.Windows.Forms.Label();
            this.btn_dsb = new System.Windows.Forms.Button();
            this.pnl_kiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo2)).BeginInit();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_databuku)).BeginInit();
            this.pnl_data2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_buku)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_atas
            // 
            this.pnl_atas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnl_atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_atas.Location = new System.Drawing.Point(0, 0);
            this.pnl_atas.Name = "pnl_atas";
            this.pnl_atas.Size = new System.Drawing.Size(980, 29);
            this.pnl_atas.TabIndex = 0;
            // 
            // pnl_kiri
            // 
            this.pnl_kiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_kiri.Controls.Add(this.btn_dsb);
            this.pnl_kiri.Controls.Add(this.btn_logout);
            this.pnl_kiri.Controls.Add(this.btn_tp);
            this.pnl_kiri.Controls.Add(this.btn_laporan);
            this.pnl_kiri.Controls.Add(this.btn_datauser);
            this.pnl_kiri.Controls.Add(this.lbl_admin);
            this.pnl_kiri.Controls.Add(this.label7);
            this.pnl_kiri.Controls.Add(this.label8);
            this.pnl_kiri.Controls.Add(this.pictureBox_logo2);
            this.pnl_kiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_kiri.Location = new System.Drawing.Point(0, 29);
            this.pnl_kiri.Name = "pnl_kiri";
            this.pnl_kiri.Size = new System.Drawing.Size(181, 472);
            this.pnl_kiri.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(12, 429);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(153, 25);
            this.btn_logout.TabIndex = 39;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_tp
            // 
            this.btn_tp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tp.ForeColor = System.Drawing.Color.White;
            this.btn_tp.Location = new System.Drawing.Point(12, 243);
            this.btn_tp.Name = "btn_tp";
            this.btn_tp.Size = new System.Drawing.Size(153, 26);
            this.btn_tp.TabIndex = 38;
            this.btn_tp.Text = "Transaksi Peminjaman";
            this.btn_tp.UseVisualStyleBackColor = true;
            // 
            // btn_laporan
            // 
            this.btn_laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_laporan.ForeColor = System.Drawing.Color.White;
            this.btn_laporan.Location = new System.Drawing.Point(12, 285);
            this.btn_laporan.Name = "btn_laporan";
            this.btn_laporan.Size = new System.Drawing.Size(153, 27);
            this.btn_laporan.TabIndex = 37;
            this.btn_laporan.Text = "Laporan";
            this.btn_laporan.UseVisualStyleBackColor = true;
            this.btn_laporan.Click += new System.EventHandler(this.btn_laporan_Click);
            // 
            // btn_datauser
            // 
            this.btn_datauser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datauser.ForeColor = System.Drawing.Color.White;
            this.btn_datauser.Location = new System.Drawing.Point(12, 204);
            this.btn_datauser.Name = "btn_datauser";
            this.btn_datauser.Size = new System.Drawing.Size(153, 27);
            this.btn_datauser.TabIndex = 36;
            this.btn_datauser.Text = "Data User";
            this.btn_datauser.UseVisualStyleBackColor = true;
            this.btn_datauser.Click += new System.EventHandler(this.btn_datauser_Click);
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.White;
            this.lbl_admin.Location = new System.Drawing.Point(104, 108);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(45, 14);
            this.lbl_admin.TabIndex = 34;
            this.lbl_admin.Text = "Admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ussername :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Admin\'s Portal";
            // 
            // pictureBox_logo2
            // 
            this.pictureBox_logo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo2.BackgroundImage")));
            this.pictureBox_logo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logo2.Location = new System.Drawing.Point(54, 12);
            this.pictureBox_logo2.Name = "pictureBox_logo2";
            this.pictureBox_logo2.Size = new System.Drawing.Size(65, 66);
            this.pictureBox_logo2.TabIndex = 31;
            this.pictureBox_logo2.TabStop = false;
            // 
            // pnl_data
            // 
            this.pnl_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_data.Controls.Add(this.lbl_dataofbook);
            this.pnl_data.Controls.Add(this.dgv_databuku);
            this.pnl_data.Location = new System.Drawing.Point(198, 41);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(770, 263);
            this.pnl_data.TabIndex = 2;
            // 
            // lbl_dataofbook
            // 
            this.lbl_dataofbook.AutoSize = true;
            this.lbl_dataofbook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataofbook.ForeColor = System.Drawing.Color.White;
            this.lbl_dataofbook.Location = new System.Drawing.Point(14, 16);
            this.lbl_dataofbook.Name = "lbl_dataofbook";
            this.lbl_dataofbook.Size = new System.Drawing.Size(103, 18);
            this.lbl_dataofbook.TabIndex = 0;
            this.lbl_dataofbook.Text = "Kelola Buku";
            // 
            // dgv_databuku
            // 
            this.dgv_databuku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_databuku.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_databuku.BackgroundColor = System.Drawing.Color.White;
            this.dgv_databuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_databuku.Location = new System.Drawing.Point(17, 37);
            this.dgv_databuku.Name = "dgv_databuku";
            this.dgv_databuku.Size = new System.Drawing.Size(737, 208);
            this.dgv_databuku.TabIndex = 0;
            this.dgv_databuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_databuku_CellContentClick);
            // 
            // pnl_data2
            // 
            this.pnl_data2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnl_data2.Controls.Add(this.btn_upload);
            this.pnl_data2.Controls.Add(this.pictureBox_buku);
            this.pnl_data2.Controls.Add(this.btn_delete);
            this.pnl_data2.Controls.Add(this.btn_update);
            this.pnl_data2.Controls.Add(this.btn_add);
            this.pnl_data2.Controls.Add(this.txt_stok);
            this.pnl_data2.Controls.Add(this.lbl_stok);
            this.pnl_data2.Controls.Add(this.label4);
            this.pnl_data2.Controls.Add(this.txt_kategori);
            this.pnl_data2.Controls.Add(this.lbl_kategori);
            this.pnl_data2.Controls.Add(this.txt_penulis);
            this.pnl_data2.Controls.Add(this.lbl_penulis);
            this.pnl_data2.Controls.Add(this.txt_judulbuku);
            this.pnl_data2.Controls.Add(this.lbl_judul);
            this.pnl_data2.Controls.Add(this.txt_idbuku);
            this.pnl_data2.Controls.Add(this.lbl_idbuku);
            this.pnl_data2.Location = new System.Drawing.Point(198, 314);
            this.pnl_data2.Name = "pnl_data2";
            this.pnl_data2.Size = new System.Drawing.Size(770, 175);
            this.pnl_data2.TabIndex = 3;
            this.pnl_data2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_data2_Paint);
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upload.ForeColor = System.Drawing.Color.White;
            this.btn_upload.Location = new System.Drawing.Point(666, 115);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(79, 23);
            this.btn_upload.TabIndex = 16;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click_1);
            // 
            // pictureBox_buku
            // 
            this.pictureBox_buku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_buku.Location = new System.Drawing.Point(666, 18);
            this.pictureBox_buku.Name = "pictureBox_buku";
            this.pictureBox_buku.Size = new System.Drawing.Size(79, 86);
            this.pictureBox_buku.TabIndex = 15;
            this.pictureBox_buku.TabStop = false;
            this.pictureBox_buku.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(433, 115);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 39);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(297, 115);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(71, 39);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(128, 115);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(73, 39);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_stok
            // 
            this.txt_stok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stok.Location = new System.Drawing.Point(388, 54);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(180, 20);
            this.txt_stok.TabIndex = 11;
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_stok.Location = new System.Drawing.Point(308, 54);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(43, 15);
            this.lbl_stok.TabIndex = 10;
            this.lbl_stok.Text = "Stok :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(316, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 9;
            // 
            // txt_kategori
            // 
            this.txt_kategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kategori.Location = new System.Drawing.Point(388, 21);
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(180, 20);
            this.txt_kategori.TabIndex = 8;
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_kategori.Location = new System.Drawing.Point(308, 22);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(74, 15);
            this.lbl_kategori.TabIndex = 7;
            this.lbl_kategori.Text = "Kategori : ";
            // 
            // txt_penulis
            // 
            this.txt_penulis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_penulis.Location = new System.Drawing.Point(111, 89);
            this.txt_penulis.Name = "txt_penulis";
            this.txt_penulis.Size = new System.Drawing.Size(180, 20);
            this.txt_penulis.TabIndex = 6;
            // 
            // lbl_penulis
            // 
            this.lbl_penulis.AutoSize = true;
            this.lbl_penulis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_penulis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_penulis.Location = new System.Drawing.Point(14, 89);
            this.lbl_penulis.Name = "lbl_penulis";
            this.lbl_penulis.Size = new System.Drawing.Size(65, 15);
            this.lbl_penulis.TabIndex = 5;
            this.lbl_penulis.Text = "Penulis : ";
            // 
            // txt_judulbuku
            // 
            this.txt_judulbuku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_judulbuku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_judulbuku.Location = new System.Drawing.Point(111, 58);
            this.txt_judulbuku.Name = "txt_judulbuku";
            this.txt_judulbuku.Size = new System.Drawing.Size(180, 20);
            this.txt_judulbuku.TabIndex = 4;
            // 
            // lbl_judul
            // 
            this.lbl_judul.AutoSize = true;
            this.lbl_judul.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_judul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_judul.Location = new System.Drawing.Point(14, 59);
            this.lbl_judul.Name = "lbl_judul";
            this.lbl_judul.Size = new System.Drawing.Size(87, 15);
            this.lbl_judul.TabIndex = 3;
            this.lbl_judul.Text = "Judul Buku : ";
            // 
            // txt_idbuku
            // 
            this.txt_idbuku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idbuku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_idbuku.Location = new System.Drawing.Point(111, 22);
            this.txt_idbuku.Name = "txt_idbuku";
            this.txt_idbuku.Size = new System.Drawing.Size(180, 20);
            this.txt_idbuku.TabIndex = 2;
            // 
            // lbl_idbuku
            // 
            this.lbl_idbuku.AutoSize = true;
            this.lbl_idbuku.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idbuku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_idbuku.Location = new System.Drawing.Point(14, 27);
            this.lbl_idbuku.Name = "lbl_idbuku";
            this.lbl_idbuku.Size = new System.Drawing.Size(64, 15);
            this.lbl_idbuku.TabIndex = 1;
            this.lbl_idbuku.Text = "Id Buku : ";
            // 
            // btn_dsb
            // 
            this.btn_dsb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsb.ForeColor = System.Drawing.Color.White;
            this.btn_dsb.Location = new System.Drawing.Point(12, 160);
            this.btn_dsb.Name = "btn_dsb";
            this.btn_dsb.Size = new System.Drawing.Size(156, 27);
            this.btn_dsb.TabIndex = 50;
            this.btn_dsb.Text = "Dasboard";
            this.btn_dsb.UseVisualStyleBackColor = true;
            // 
            // DataBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 501);
            this.Controls.Add(this.pnl_data2);
            this.Controls.Add(this.pnl_data);
            this.Controls.Add(this.pnl_kiri);
            this.Controls.Add(this.pnl_atas);
            this.Name = "DataBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBuku";
            this.Load += new System.EventHandler(this.DataBuku_Load);
            this.pnl_kiri.ResumeLayout(false);
            this.pnl_kiri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo2)).EndInit();
            this.pnl_data.ResumeLayout(false);
            this.pnl_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_databuku)).EndInit();
            this.pnl_data2.ResumeLayout(false);
            this.pnl_data2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_buku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_atas;
        private Guna.UI2.WinForms.Guna2Panel pnl_kiri;
        private Guna.UI2.WinForms.Guna2Panel pnl_data;
        private System.Windows.Forms.DataGridView dgv_databuku;
        private Guna.UI2.WinForms.Guna2Panel pnl_data2;
        private System.Windows.Forms.Label lbl_dataofbook;
        private System.Windows.Forms.Label lbl_idbuku;
        private System.Windows.Forms.TextBox txt_judulbuku;
        private System.Windows.Forms.Label lbl_judul;
        private System.Windows.Forms.TextBox txt_idbuku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kategori;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.TextBox txt_penulis;
        private System.Windows.Forms.Label lbl_penulis;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.PictureBox pictureBox_buku;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_tp;
        private System.Windows.Forms.Button btn_laporan;
        private System.Windows.Forms.Button btn_datauser;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox_logo2;
        private System.Windows.Forms.Button btn_dsb;
    }
}