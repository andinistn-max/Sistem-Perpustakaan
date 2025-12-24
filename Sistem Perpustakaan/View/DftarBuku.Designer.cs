namespace Sistem_Perpustakaan.View
{
    partial class DftarBuku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DftarBuku));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_jdl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_dasboard = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_rwypjm = new System.Windows.Forms.Button();
            this.btn_pinjambuku = new System.Windows.Forms.Button();
            this.btn_daftarbuku = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_logo2 = new System.Windows.Forms.PictureBox();
            this.dgv_dftarbuku = new Guna.UI2.WinForms.Guna2Panel();
            this.bnt_detailbuku = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_daftabuku = new System.Windows.Forms.DataGridView();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo2)).BeginInit();
            this.dgv_dftarbuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_daftabuku)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbl_close);
            this.panel1.Controls.Add(this.lbl_jdl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 32);
            this.panel1.TabIndex = 4;
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
            // lbl_jdl
            // 
            this.lbl_jdl.AutoSize = true;
            this.lbl_jdl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_jdl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jdl.ForeColor = System.Drawing.Color.White;
            this.lbl_jdl.Location = new System.Drawing.Point(229, 9);
            this.lbl_jdl.Name = "lbl_jdl";
            this.lbl_jdl.Size = new System.Drawing.Size(103, 18);
            this.lbl_jdl.TabIndex = 22;
            this.lbl_jdl.Text = "Daftar Buku";
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
            this.panel2.Size = new System.Drawing.Size(200, 507);
            this.panel2.TabIndex = 5;
            // 
            // btn_dasboard
            // 
            this.btn_dasboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dasboard.ForeColor = System.Drawing.Color.White;
            this.btn_dasboard.Location = new System.Drawing.Point(15, 195);
            this.btn_dasboard.Name = "btn_dasboard";
            this.btn_dasboard.Size = new System.Drawing.Size(176, 31);
            this.btn_dasboard.TabIndex = 32;
            this.btn_dasboard.Text = "Dashboard";
            this.btn_dasboard.UseVisualStyleBackColor = true;
            this.btn_dasboard.Click += new System.EventHandler(this.btn_dasboard_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(12, 464);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(182, 32);
            this.btn_logout.TabIndex = 30;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_rwypjm
            // 
            this.btn_rwypjm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rwypjm.ForeColor = System.Drawing.Color.White;
            this.btn_rwypjm.Location = new System.Drawing.Point(12, 336);
            this.btn_rwypjm.Name = "btn_rwypjm";
            this.btn_rwypjm.Size = new System.Drawing.Size(182, 32);
            this.btn_rwypjm.TabIndex = 29;
            this.btn_rwypjm.Text = "Riwayat Peminjaman";
            this.btn_rwypjm.UseVisualStyleBackColor = true;
            this.btn_rwypjm.Click += new System.EventHandler(this.btn_rwypjm_Click_1);
            // 
            // btn_pinjambuku
            // 
            this.btn_pinjambuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pinjambuku.ForeColor = System.Drawing.Color.White;
            this.btn_pinjambuku.Location = new System.Drawing.Point(12, 281);
            this.btn_pinjambuku.Name = "btn_pinjambuku";
            this.btn_pinjambuku.Size = new System.Drawing.Size(182, 32);
            this.btn_pinjambuku.TabIndex = 27;
            this.btn_pinjambuku.Text = "Pinjam Buku";
            this.btn_pinjambuku.UseVisualStyleBackColor = true;
            // 
            // btn_daftarbuku
            // 
            this.btn_daftarbuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_daftarbuku.ForeColor = System.Drawing.Color.White;
            this.btn_daftarbuku.Location = new System.Drawing.Point(12, 243);
            this.btn_daftarbuku.Name = "btn_daftarbuku";
            this.btn_daftarbuku.Size = new System.Drawing.Size(182, 32);
            this.btn_daftarbuku.TabIndex = 26;
            this.btn_daftarbuku.Text = "Daftar Buku";
            this.btn_daftarbuku.UseVisualStyleBackColor = true;
            this.btn_daftarbuku.Click += new System.EventHandler(this.btn_daftarbuku_Click_1);
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
            this.pictureBox_logo2.Location = new System.Drawing.Point(46, 21);
            this.pictureBox_logo2.Name = "pictureBox_logo2";
            this.pictureBox_logo2.Size = new System.Drawing.Size(88, 70);
            this.pictureBox_logo2.TabIndex = 12;
            this.pictureBox_logo2.TabStop = false;
            // 
            // dgv_dftarbuku
            // 
            this.dgv_dftarbuku.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.dgv_dftarbuku.Controls.Add(this.bnt_detailbuku);
            this.dgv_dftarbuku.Controls.Add(this.dgv_daftabuku);
            this.dgv_dftarbuku.Controls.Add(this.cmb_kategori);
            this.dgv_dftarbuku.Controls.Add(this.lbl_kategori);
            this.dgv_dftarbuku.Controls.Add(this.txt_search);
            this.dgv_dftarbuku.Location = new System.Drawing.Point(206, 51);
            this.dgv_dftarbuku.Name = "dgv_dftarbuku";
            this.dgv_dftarbuku.Size = new System.Drawing.Size(652, 460);
            this.dgv_dftarbuku.TabIndex = 6;
            // 
            // bnt_detailbuku
            // 
            this.bnt_detailbuku.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bnt_detailbuku.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bnt_detailbuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bnt_detailbuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bnt_detailbuku.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnt_detailbuku.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnt_detailbuku.ForeColor = System.Drawing.Color.White;
            this.bnt_detailbuku.Location = new System.Drawing.Point(17, 398);
            this.bnt_detailbuku.Name = "bnt_detailbuku";
            this.bnt_detailbuku.Size = new System.Drawing.Size(101, 37);
            this.bnt_detailbuku.TabIndex = 27;
            this.bnt_detailbuku.Text = "Detail Buku";
            // 
            // dgv_daftabuku
            // 
            this.dgv_daftabuku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_daftabuku.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_daftabuku.BackgroundColor = System.Drawing.Color.White;
            this.dgv_daftabuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_daftabuku.Location = new System.Drawing.Point(17, 53);
            this.dgv_daftabuku.Name = "dgv_daftabuku";
            this.dgv_daftabuku.Size = new System.Drawing.Size(614, 326);
            this.dgv_daftabuku.TabIndex = 26;
            this.dgv_daftabuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_daftabuku_CellContentClick);
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Location = new System.Drawing.Point(417, 18);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(232, 21);
            this.cmb_kategori.TabIndex = 25;
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kategori.Location = new System.Drawing.Point(337, 20);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(74, 15);
            this.lbl_kategori.TabIndex = 24;
            this.lbl_kategori.Text = "Kategori : ";
            // 
            // txt_search
            // 
            this.txt_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.ForeColor = System.Drawing.Color.Gray;
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(17, 18);
            this.txt_search.Name = "txt_search";
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_search.PlaceholderText = "Search";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(242, 22);
            this.txt_search.TabIndex = 23;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged_1);
            // 
            // DftarBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 507);
            this.Controls.Add(this.dgv_dftarbuku);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DftarBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DftarBuku";
            this.Load += new System.EventHandler(this.DftarBuku_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo2)).EndInit();
            this.dgv_dftarbuku.ResumeLayout(false);
            this.dgv_dftarbuku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_daftabuku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_jdl;
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
        private Guna.UI2.WinForms.Guna2Panel dgv_dftarbuku;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.Label lbl_kategori;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_daftabuku;
        private Guna.UI2.WinForms.Guna2Button bnt_detailbuku;
        private System.Windows.Forms.Button btn_dasboard;
    }
}