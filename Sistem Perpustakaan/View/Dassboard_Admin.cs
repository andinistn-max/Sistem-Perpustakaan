using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.View
{
    public partial class Dassboard_Admin : Form
    {
        public Dassboard_Admin()
        {
            InitializeComponent();
        }

        private void Dassboard_Admin_Load(object sender, EventArgs e)
        {
            // set admin label from session
            try
            {
                string name = Model.Session.CurrentFullName;
                if (string.IsNullOrEmpty(name)) name = Model.Session.CurrentUsername ?? "Admin";
                // common label names used in designers
                string[] lblNames = new[] { "lbl_admin", "lbl_username", "lbl_user" };
                foreach (var n in lblNames)
                {
                    var matches = this.Controls.Find(n, true);
                    if (matches != null && matches.Length > 0 && matches[0] is Label)
                    {
                        ((Label)matches[0]).Text = name;
                        break;
                    }
                }
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_Usser data_usser = new Data_Usser();
            data_usser.Show();
            this.Hide();
        }

        private void btn_databuku_Click(object sender, EventArgs e)
        {
            DataBuku data_buku = new DataBuku();
            data_buku.Show();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_logo2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
