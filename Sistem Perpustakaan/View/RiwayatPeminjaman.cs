using Sistem_Perpustakaan.Controller;
using Sistem_Perpustakaan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.View
{
    public partial class RiwayatPeminjaman : Form
    {
        RiwayatPeminjamanController controller = new RiwayatPeminjamanController();
        int idUserLogin;

        // Parameterless overload to satisfy designer and callers that don't pass id
        public RiwayatPeminjaman() : this(0)
        {
        }

        public RiwayatPeminjaman(int idUser)
        {
            InitializeComponent();
            idUserLogin = idUser;
        }

        private void RiwayatPeminjaman_Load(object sender, EventArgs e)
        {
            // wire kembalikan button if designer didn't
            if (btn_kembalikan != null)
                btn_kembalikan.Click += btnKembalikan_Click;

            // wire navigation buttons if needed
            if (btn_daftarbuku != null)
                btn_daftarbuku.Click += btn_daftarbuku_Click;
            if (btn_pinjambuku != null)
                btn_pinjambuku.Click += btn_pinjambuku_Click;
            if (btn_rwypjm != null)
                btn_rwypjm.Click += btn_rwypjm_Click;
            if (btn_logout != null)
                btn_logout.Click += btn_logout_Click;

            // set user label from session
            try
            {
                string name = Session.CurrentFullName;
                if (string.IsNullOrEmpty(name)) name = Session.CurrentUsername ?? "User";
                var lbl = this.Controls.Find("lbl_user", true).FirstOrDefault() as Label;
                if (lbl != null) lbl.Text = name;
            }
            catch { }

            LoadData();
        }

        private void LoadData()
        {
            List<Riwayat> data = controller.GetByUser(idUserLogin);
            dgv_riwayat.DataSource = data;

            if (dgv_riwayat.Columns.Contains("IdBorrow"))
                dgv_riwayat.Columns["IdBorrow"].Visible = false;

            if (dgv_riwayat.Columns.Contains("Title"))
                dgv_riwayat.Columns["Title"].HeaderText = "Judul Buku";
            if (dgv_riwayat.Columns.Contains("BorrowDate"))
                dgv_riwayat.Columns["BorrowDate"].HeaderText = "Tanggal Pinjam";
            if (dgv_riwayat.Columns.Contains("DueDate"))
                dgv_riwayat.Columns["DueDate"].HeaderText = "Batas Kembali";
            if (dgv_riwayat.Columns.Contains("Status"))
                dgv_riwayat.Columns["Status"].HeaderText = "Status";
            if (dgv_riwayat.Columns.Contains("Fine"))
                dgv_riwayat.Columns["Fine"].HeaderText = "Denda";
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            if (dgv_riwayat.CurrentRow == null)
            {
                MessageBox.Show("Pilih data terlebih dahulu");
                return;
            }

            string status = dgv_riwayat.CurrentRow.Cells["Status"].Value?.ToString() ?? "";
            if (status == "dikembalikan")
            {
                MessageBox.Show("Buku sudah dikembalikan");
                return;
            }

            int idBorrow = Convert.ToInt32(dgv_riwayat.CurrentRow.Cells["IdBorrow"].Value);

            DialogResult confirm = MessageBox.Show(
                "Yakin ingin mengembalikan buku?",
                "Konfirmasi",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                bool sukses = controller.KembalikanBuku(idBorrow);
                if (sukses)
                {
                    MessageBox.Show("Buku berhasil dikembalikan");
                    LoadData(); // refresh grid
                }
                else
                {
                    MessageBox.Show("Gagal mengembalikan buku");
                }
            }
        }

        // Designer referenced handlers that were missing
        private void btn_daftarbuku_Click(object sender, EventArgs e)
        {
            try
            {
                DftarBuku daftar = new DftarBuku();
                daftar.Show();
                this.Hide();
            }
            catch
            {
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_riwayat.Rows.Count > e.RowIndex)
            {
                dgv_riwayat.ClearSelection();
                dgv_riwayat.Rows[e.RowIndex].Selected = true;
            }
        }

        // Additional small navigation handlers
        private void btn_pinjambuku_Click(object sender, EventArgs e)
        {
            try
            {
                PinjamBuku p = new PinjamBuku();
                p.Show();
                this.Hide();
            }
            catch
            {
            }
        }

        private void btn_rwypjm_Click(object sender, EventArgs e)
        {
            // already on this page
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                Login l = new Login();
                l.Show();
                this.Hide();
            }
            catch
            {
            }
        }

        private void btn_kembalikan_Click(object sender, EventArgs e)
        {

        }

        private void btn_dasboard_Click(object sender, EventArgs e)
        {
            Dasboard_User d = new Dasboard_User();
            d.Show();
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}