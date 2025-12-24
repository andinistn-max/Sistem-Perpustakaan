using Sistem_Perpustakaan.Controller;
using Sistem_Perpustakaan.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.View
{
    public partial class LaporanAdmin : Form
    {
        LaporanController controller = new LaporanController();

        public LaporanAdmin()
        {
            InitializeComponent();
        }

        private void LaporanAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                string name = Model.Session.CurrentFullName;
                if (string.IsNullOrEmpty(name)) name = Model.Session.CurrentUsername ?? "Admin";
                var lbl = this.Controls.Find("lbl_admin", true).FirstOrDefault() as Label;
                if (lbl != null) lbl.Text = name;
            }
            catch { }

            LoadSummary();
            LoadComboLaporan();

            if (cmb_jenis != null)
                cmb_jenis.SelectedIndexChanged += cmbJenisLaporan_SelectedIndexChanged;

            cmbJenisLaporan_SelectedIndexChanged(this, EventArgs.Empty);
        }

        // ================= PANEL ATAS =================
        private void LoadSummary()
        {
            LaporanModel laporan = null;
            try
            {
                laporan = controller.GetSummary();
            }
            catch (Exception)
            {
                laporan = null;
            }

            if (laporan != null)
            {
                lbl_totalpmj.Text = laporan.TotalPeminjaman.ToString();
                lbl_bukupjm.Text = laporan.BukuDipinjam.ToString();
                lbl_denda.Text = "Rp " + laporan.TotalDenda.ToString("N0");
            }
            else
            {
                lbl_totalpmj.Text = "0";
                lbl_bukupjm.Text = "0";
                lbl_denda.Text = "Rp 0";
            }
        }

        // ================= COMBO LAPORAN =================
        private void LoadComboLaporan()
        {
            cmb_jenis.Items.Clear();
            cmb_jenis.Items.Add("Laporan Peminjaman");
            cmb_jenis.Items.Add("Laporan Buku");
            cmb_jenis.Items.Add("Laporan Denda");
            cmb_jenis.SelectedIndex = 0;
        }

        private void cmbJenisLaporan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = controller.GetLaporan(cmb_jenis.Text) ?? new System.Data.DataTable();
                dgv_laporan.DataSource = dt;

                dgv_laporan.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading laporan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgv_laporan.DataSource = new System.Data.DataTable();
            }
        }

        // Designer event stubs
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        // ================= NAVIGASI =================
        private void btn_logout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btn_databuku_Click(object sender, EventArgs e)
        {
            new DataBuku().Show();
            this.Hide();
        }

        private void btn_datauser_Click(object sender, EventArgs e)
        {
            new Data_Usser().Show();
            this.Hide();
        }

        private void btn_tp_Click(object sender, EventArgs e)
        {
            new Peminjaman().Show();
            this.Hide();
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            // sudah di halaman ini
        }
    }
}
