namespace Sistem_Perpustakaan.View
{
    partial class Peminjaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peminjaman));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_atas = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox_logo2 = new System.Windows.Forms.PictureBox();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_databuku = new System.Windows.Forms.Button();
            this.btn_datauser = new System.Windows.Forms.Button();
            this.btn_laporan = new System.Windows.Forms.Button();
            this.btn_tp = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pnl_pinggir = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_data = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.dgv_peminjaman = new System.Windows.Forms.DataGridView();
            this.lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo2)).BeginInit();
            this.pnl_pinggir.SuspendLayout();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_atas
            // 
            this.pnl_atas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_atas.Location = new System.Drawing.Point(0, 0);
            this.pnl_atas.Name = "pnl_atas";
            this.pnl_atas.Size = new System.Drawing.Size(925, 30);
            this.pnl_atas.TabIndex = 1;
            // 
            // pictureBox_logo2
            // 
            this.pictureBox_logo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo2.BackgroundImage")));
            this.pictureBox_logo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logo2.Location = new System.Drawing.Point(58, 18);
            this.pictureBox_logo2.Name = "pictureBox_logo2";
            this.pictureBox_logo2.Size = new System.Drawing.Size(80, 54);
            this.pictureBox_logo2.TabIndex = 31;
            this.pictureBox_logo2.TabStop = false;
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.White;
            this.lbl_admin.Location = new System.Drawing.Point(32, 104);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(123, 18);
            this.lbl_admin.TabIndex = 32;
            this.lbl_admin.Text = "Admin\'s Portal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ussername :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Admin";
            // 
            // btn_databuku
            // 
            this.btn_databuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_databuku.ForeColor = System.Drawing.Color.White;
            this.btn_databuku.Location = new System.Drawing.Point(2, 172);
            this.btn_databuku.Name = "btn_databuku";
            this.btn_databuku.Size = new System.Drawing.Size(182, 28);
            this.btn_databuku.TabIndex = 35;
            this.btn_databuku.Text = "Data Buku";
            this.btn_databuku.UseVisualStyleBackColor = true;
            this.btn_databuku.Click += new System.EventHandler(this.btn_databuku_Click);
            // 
            // btn_datauser
            // 
            this.btn_datauser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datauser.ForeColor = System.Drawing.Color.White;
            this.btn_datauser.Location = new System.Drawing.Point(2, 206);
            this.btn_datauser.Name = "btn_datauser";
            this.btn_datauser.Size = new System.Drawing.Size(182, 28);
            this.btn_datauser.TabIndex = 36;
            this.btn_datauser.Text = "Data User";
            this.btn_datauser.UseVisualStyleBackColor = true;
            this.btn_datauser.Click += new System.EventHandler(this.btn_datauser_Click);
            // 
            // btn_laporan
            // 
            this.btn_laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_laporan.ForeColor = System.Drawing.Color.White;
            this.btn_laporan.Location = new System.Drawing.Point(2, 277);
            this.btn_laporan.Name = "btn_laporan";
            this.btn_laporan.Size = new System.Drawing.Size(182, 27);
            this.btn_laporan.TabIndex = 37;
            this.btn_laporan.Text = "Laporan";
            this.btn_laporan.UseVisualStyleBackColor = true;
            this.btn_laporan.Click += new System.EventHandler(this.btn_laporan_Click);
            // 
            // btn_tp
            // 
            this.btn_tp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tp.ForeColor = System.Drawing.Color.White;
            this.btn_tp.Location = new System.Drawing.Point(2, 240);
            this.btn_tp.Name = "btn_tp";
            this.btn_tp.Size = new System.Drawing.Size(182, 31);
            this.btn_tp.TabIndex = 38;
            this.btn_tp.Text = "Transaksi Peminjaman";
            this.btn_tp.UseVisualStyleBackColor = true;
            this.btn_tp.Click += new System.EventHandler(this.btn_tp_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(3, 410);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(179, 32);
            this.btn_logout.TabIndex = 39;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // pnl_pinggir
            // 
            this.pnl_pinggir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_pinggir.Controls.Add(this.btn_logout);
            this.pnl_pinggir.Controls.Add(this.btn_tp);
            this.pnl_pinggir.Controls.Add(this.btn_laporan);
            this.pnl_pinggir.Controls.Add(this.btn_datauser);
            this.pnl_pinggir.Controls.Add(this.btn_databuku);
            this.pnl_pinggir.Controls.Add(this.label4);
            this.pnl_pinggir.Controls.Add(this.label3);
            this.pnl_pinggir.Controls.Add(this.lbl_admin);
            this.pnl_pinggir.Controls.Add(this.pictureBox_logo2);
            this.pnl_pinggir.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_pinggir.Location = new System.Drawing.Point(0, 30);
            this.pnl_pinggir.Name = "pnl_pinggir";
            this.pnl_pinggir.Size = new System.Drawing.Size(186, 454);
            this.pnl_pinggir.TabIndex = 3;
            // 
            // pnl_data
            // 
            this.pnl_data.BackColor = System.Drawing.Color.White;
            this.pnl_data.Controls.Add(this.txt_search);
            this.pnl_data.Controls.Add(this.comboBox_status);
            this.pnl_data.Controls.Add(this.dgv_peminjaman);
            this.pnl_data.Controls.Add(this.lbl_status);
            this.pnl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_data.ForeColor = System.Drawing.Color.Black;
            this.pnl_data.Location = new System.Drawing.Point(203, 48);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(710, 424);
            this.pnl_data.TabIndex = 4;
            this.pnl_data.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // txt_search
            // 
            this.txt_search.BorderColor = System.Drawing.Color.Black;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(376, 32);
            this.txt_search.Name = "txt_search";
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_search.PlaceholderText = "Search";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(309, 22);
            this.txt_search.TabIndex = 37;
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(59, 33);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(200, 21);
            this.comboBox_status.TabIndex = 36;
            // 
            // dgv_peminjaman
            // 
            this.dgv_peminjaman.BackgroundColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_peminjaman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_peminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_peminjaman.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_peminjaman.Location = new System.Drawing.Point(19, 65);
            this.dgv_peminjaman.Name = "dgv_peminjaman";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_peminjaman.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_peminjaman.Size = new System.Drawing.Size(666, 332);
            this.dgv_peminjaman.TabIndex = 35;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.White;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Black;
            this.lbl_status.Location = new System.Drawing.Point(16, 36);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 33;
            this.lbl_status.Text = "Status";
            this.lbl_status.Click += new System.EventHandler(this.label1_Click);
            // 
            // Peminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(925, 484);
            this.Controls.Add(this.pnl_data);
            this.Controls.Add(this.pnl_pinggir);
            this.Controls.Add(this.pnl_atas);
            this.Name = "Peminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peminjaman";
            this.Load += new System.EventHandler(this.Peminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo2)).EndInit();
            this.pnl_pinggir.ResumeLayout(false);
            this.pnl_pinggir.PerformLayout();
            this.pnl_data.ResumeLayout(false);
            this.pnl_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peminjaman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_atas;
        private System.Windows.Forms.PictureBox pictureBox_logo2;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_databuku;
        private System.Windows.Forms.Button btn_datauser;
        private System.Windows.Forms.Button btn_laporan;
        private System.Windows.Forms.Button btn_tp;
        private System.Windows.Forms.Button btn_logout;
        private Guna.UI2.WinForms.Guna2Panel pnl_pinggir;
        private Guna.UI2.WinForms.Guna2Panel pnl_data;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.DataGridView dgv_peminjaman;
        private System.Windows.Forms.ComboBox comboBox_status;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
    }
}