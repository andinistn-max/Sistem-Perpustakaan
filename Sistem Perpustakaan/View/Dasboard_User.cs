using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Perpustakaan.Model;

namespace Sistem_Perpustakaan.View
{
    public partial class Dasboard_User : Form
    {
        public Dasboard_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DftarBuku daftar_buku = new DftarBuku();
            daftar_buku.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dasboard_User_Load(object sender, EventArgs e)
        {
            // set user label from session
            try
            {
                string name = Session.CurrentFullName;
                if (string.IsNullOrEmpty(name)) name = Session.CurrentUsername ?? "User";
                string[] lblNames = new[] { "lbl_user", "lbl_portal_user", "lbl_user_display", "lbl_username" };
                foreach (var n in lblNames)
                {
                    var lbl = this.Controls.Find(n, true).FirstOrDefault() as Label;
                    if (lbl != null)
                    {
                        lbl.Text = name;
                        break;
                    }
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Membuka Riwayat UserId = " + Session.CurrentUserId);
            // Kirim ID user dari session ke form RiwayatPeminjaman
            RiwayatPeminjaman rp = new RiwayatPeminjaman(Session.CurrentUserId);
            rp.Show();
            this.Hide();
        }

        private void btn_pinjambuku_Click(object sender, EventArgs e)
        {
            PinjamBuku pinjam_buku = new PinjamBuku();
            pinjam_buku.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // logout -> clear session and show login
            try
            {
                Session.CurrentUserId = 0;
                Session.CurrentUsername = null;
                Session.CurrentFullName = null;
                Session.CurrentRole = null;
            }
            catch { }

            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void pcb_profiel_Click(object sender, EventArgs e)
        {
            try
            {
                Profiel_Usser pp = new Profiel_Usser();
                pp.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka profil: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
