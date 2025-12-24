using Sistem_Perpustakaan.Controller;
using Sistem_Perpustakaan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.View
{
    public partial class DftarBuku : Form
    {
        BukuController controller = new BukuController();
        public DftarBuku()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Designer wires Load to DftarBuku_Load
        private void DftarBuku_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadKategori();
            LoadBooksFiltered();

            // set user label from session if exists
            try
            {
                string name = Session.CurrentFullName;
                if (string.IsNullOrEmpty(name)) name = Session.CurrentUsername ?? "User";
                var lbl = this.Controls.Find("lbl_user", true).FirstOrDefault() as Label;
                if (lbl != null) lbl.Text = name;
            }
            catch { }

            // wire events to designer control names
            if (txt_search != null)
                txt_search.TextChanged += txt_search_TextChanged;

            if (bnt_detailbuku != null)
                bnt_detailbuku.Click += btnDetail_Click;

            if (cmb_kategori != null)
                cmb_kategori.SelectedIndexChanged += cmb_kategori_SelectedIndexChanged;

            // wire navigation buttons (designer expects these handlers)
            if (btn_logout != null) btn_logout.Click += btn_logout_Click;
            if (btn_pinjambuku != null) btn_pinjambuku.Click += btn_pinjambuku_Click;
            if (btn_rwypjm != null) btn_rwypjm.Click += btn_rwypjm_Click;
            if (btn_daftarbuku != null) btn_daftarbuku.Click += btn_daftarbuku_Click;
            if (lbl_close != null) lbl_close.Click += lbl_close_Click;
        }

        private void LoadBooks()
        {
            dgv_daftabuku.Rows.Clear();
            dgv_daftabuku.Columns.Clear();

            // Kolom Foto
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "Foto";
            imgCol.HeaderText = "Foto Buku";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.Width = 100;
            dgv_daftabuku.Columns.Add(imgCol);

            dgv_daftabuku.Columns.Add("Judul", "Judul");
            dgv_daftabuku.Columns.Add("Penulis", "Penulis");
            dgv_daftabuku.Columns.Add("Kategori", "Kategori");
            dgv_daftabuku.Columns.Add("Stok", "Stok");

            // hidden column to keep photo path so DetailBuku can load image
            dgv_daftabuku.Columns.Add("photo", "photo");
            dgv_daftabuku.Columns["photo"].Visible = false;
             
             // 🔥 AMBIL LANGSUNG DARI BukuController
             DataTable dt = controller.GetAllBooks();

             foreach (DataRow row in dt.Rows)
             {
                 Image img = null;
                 string photoPath = row["photo"] == DBNull.Value ? null : row["photo"].ToString();

                 if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                 {
                     using (var fs = new FileStream(photoPath, FileMode.Open, FileAccess.Read))
                     {
                         img = Image.FromStream(fs);
                     }
                 }

                dgv_daftabuku.Rows.Add(
                    img,
                    row["title"].ToString(),
                    row["author"].ToString(),
                    row["category"].ToString(),
                    row["stock"].ToString(),
                    photoPath
                );
             }

            dgv_daftabuku.ReadOnly = true;
            dgv_daftabuku.AllowUserToAddRows = false;
            dgv_daftabuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // search textbox handler (matches designer name txt_search)
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_daftabuku.Rows.Clear();

            string kategori = cmb_kategori.SelectedItem?.ToString() ?? "Semua";
            DataTable dt = controller.SearchBooks(txt_search.Text.Trim(), kategori);

            foreach (DataRow row in dt.Rows)
            {
                Image img = null;
                string photoPath = row["photo"] == DBNull.Value ? null : row["photo"].ToString();

                if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                {
                    using (var fs = new FileStream(photoPath, FileMode.Open, FileAccess.Read))
                    {
                        img = Image.FromStream(fs);
                    }
                }

                dgv_daftabuku.Rows.Add(
                    img,
                    row["title"].ToString(),
                    row["author"].ToString(),
                    row["category"].ToString(),
                    row["stock"].ToString(),
                    photoPath
                );
            }
        }
        private void LoadKategori()
        {
            cmb_kategori.Items.Clear();
            cmb_kategori.Items.Add("Semua");

            DataTable dt = controller.GetAllBooks();

            var kategori = dt.AsEnumerable()
                             .Select(r => r["category"].ToString())
                             .Distinct();

            foreach (var k in kategori)
                cmb_kategori.Items.Add(k);

            cmb_kategori.SelectedIndex = 0;
        }


        private void cmb_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBooksFiltered();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgv_daftabuku.CurrentRow == null)
            {
                MessageBox.Show("Pilih buku terlebih dahulu!");
                return;
            }

            var cells = dgv_daftabuku.CurrentRow.Cells;
            string title = cells.Count > 1 && cells[1].Value != null ? cells[1].Value.ToString() : "-";
            string author = cells.Count > 2 && cells[2].Value != null ? cells[2].Value.ToString() : "-";
            string category = cells.Count > 3 && cells[3].Value != null ? cells[3].Value.ToString() : "-";
            string stock = cells.Count > 4 && cells[4].Value != null ? cells[4].Value.ToString() : "-";
            string photoPath = null;
            if (cells.Count > 5 && cells[5].Value != null)
                photoPath = cells[5].Value.ToString();

            // open detail form with selected data
            var detailForm = new DetailBuku(title, author, category, stock, photoPath);
            detailForm.Show();
            this.Hide();
        }

        private void LoadBooksFiltered()
        {
            dgv_daftabuku.Rows.Clear();

            string keyword = txt_search.Text.Trim();
            string kategori = cmb_kategori.SelectedItem == null
                                ? "Semua"
                                : cmb_kategori.SelectedItem.ToString();

            DataTable dt = controller.SearchBooks(keyword, kategori);

            foreach (DataRow row in dt.Rows)
            {
                Image img = null;
                string photoPath = row["photo"] == DBNull.Value ? null : row["photo"].ToString();

                if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                {
                    using (var fs = new FileStream(photoPath, FileMode.Open, FileAccess.Read))
                    {
                        img = Image.FromStream(fs);
                    }
                }

                dgv_daftabuku.Rows.Add(
                    img,
                    row["title"].ToString(),
                    row["author"].ToString(),
                    row["category"].ToString(),
                    row["stock"].ToString(),
                    photoPath
                );
            }
        }


        // Navigation / designer handlers
        private void btn_logout_Click(object sender, EventArgs e)
        {
            // go back to login
            new Login().Show();
            this.Hide();
        }

        private void btn_pinjambuku_Click(object sender, EventArgs e)
        {
            new PinjamBuku().Show();
            this.Hide();
        }

        private void btn_rwypjm_Click(object sender, EventArgs e)
        {
            new RiwayatPeminjaman().Show();
            this.Hide();
        }

        private void btn_daftarbuku_Click(object sender, EventArgs e)
        {
            // already here
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_rwypjm_Click_1(object sender, EventArgs e)
        {

        }

        private void dgv_daftabuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {

            LoadBooksFiltered();
        }

        private void btn_daftarbuku_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_dasboard_Click(object sender, EventArgs e)
        {
            Dasboard_User d = new Dasboard_User();
            d.Show();
            this.Hide();

        }
    }
}
