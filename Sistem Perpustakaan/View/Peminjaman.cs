using Sistem_Perpustakaan.Controller;
using Sistem_Perpustakaan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.View
{
    public partial class Peminjaman : Form
    {
        PeminjamanController controller = new PeminjamanController();

        public Peminjaman()
        {
            InitializeComponent();
        }

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            comboBox_status.Items.Clear();
            comboBox_status.Items.Add("Semua");
            comboBox_status.Items.Add("dipinjam");
            comboBox_status.Items.Add("dikembalikan");
            comboBox_status.SelectedIndex = 0;

            // set admin label from session if designer has one
            try
            {
                string name = Model.Session.CurrentFullName;
                if (string.IsNullOrEmpty(name)) name = Model.Session.CurrentUsername ?? "Admin";
                var lbl = this.Controls.Find("lbl_admin", true).FirstOrDefault() as Label;
                if (lbl != null) lbl.Text = name;
            }
            catch { }

            // wire events (designer may not wire these)
            comboBox_status.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            txt_search.TextChanged += txtSearch_TextChanged;

            LoadData();
        }

        private void LoadData()
        {
            string status = comboBox_status.SelectedItem?.ToString() ?? "Semua";
            string keyword = txt_search?.Text?.Trim() ?? string.Empty;

            List<PeminjamanModel> data = controller.GetAll(status, keyword);

            // Ensure columns exist (9 columns expected)
            if (dgv_peminjaman.ColumnCount == 0)
            {
                dgv_peminjaman.Columns.Add("id_borrow", "ID");
                dgv_peminjaman.Columns.Add("username", "Username");
                dgv_peminjaman.Columns.Add("full_name", "Nama Lengkap");
                dgv_peminjaman.Columns.Add("title", "Judul");
                dgv_peminjaman.Columns.Add("borrow_date", "Tanggal Pinjam");
                dgv_peminjaman.Columns.Add("due_date", "Tanggal Jatuh Tempo");
                dgv_peminjaman.Columns.Add("return_date", "Tanggal Kembali");
                dgv_peminjaman.Columns.Add("status", "Status");
                dgv_peminjaman.Columns.Add("fine", "Denda");

                dgv_peminjaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_peminjaman.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_peminjaman.MultiSelect = false;
                dgv_peminjaman.AllowUserToAddRows = false;
            }

            dgv_peminjaman.Rows.Clear();
            foreach (var p in data)
            {
                dgv_peminjaman.Rows.Add(
                    p.IdBorrow,
                    p.Username,
                    p.FullName,
                    p.Title,
                    p.BorrowDate,
                    p.DueDate,
                    p.ReturnDate,
                    p.Status,
                    p.Fine
                );
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        // Designer wired handlers (stubs)
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            // no-op
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // no-op
        }

        private void btn_databuku_Click(object sender, EventArgs e)
        {
            DataBuku data_buku = new DataBuku();
            data_buku.Show();
            this.Hide();
        }

        private void btn_datauser_Click(object sender, EventArgs e)
        {
            Data_Usser data_user = new Data_Usser();
            data_user.Show();
            this.Hide();
        }

        private void btn_tp_Click(object sender, EventArgs e)
        {
            Peminjaman pmj = new Peminjaman();
            pmj.Show();
            this.Hide();
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            LaporanAdmin laporan_admin = new LaporanAdmin();
            laporan_admin.Show();
            this.Hide();
        }
    }
}

