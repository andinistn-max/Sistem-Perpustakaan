using Guna.UI2.AnimatorNS;
using Sistem_Perpustakaan.Controller;
using Sistem_Perpustakaan.Model;
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
    public partial class Login : Form
    {
        AuthController auth = new AuthController();
        public Login()
        {
            InitializeComponent();
        }

        private void DoLogin()
        {
            string username = txt_loginussername.Text.Trim();
            string password = txt_loginpassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password harus diisi");
                return;
            }

            DataTable dt = auth.Login(username, password);

            if (dt != null && dt.Rows.Count > 0)
            {
                SIMPAN KE SESSION
                Session.CurrentUserId = Convert.ToInt32(dt.Rows[0]["id_user"]);
                Session.CurrentUsername = dt.Rows[0]["username"].ToString();
                Session.CurrentFullName = dt.Columns.Contains("full_name")
                    ? dt.Rows[0]["full_name"].ToString()
                    : "";

                string role = dt.Rows[0]["role"].ToString();

                MessageBox.Show("Login Berhasil");

                this.Hide();

                if (role == "admin")
                    new Dassboard_Admin().Show();
                else
                    new Dasboard_User().Show();
            }
            else
            {
                MessageBox.Show("Username atau Password salah");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();

            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lbl_judul_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void checkBox_loginshow_CheckedChanged(object sender, EventArgs e)
        {
            // toggle password visibility
            txt_loginpassword.UseSystemPasswordChar = !checkBox_loginshow.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}