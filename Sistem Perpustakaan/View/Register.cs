using Sistem_Perpustakaan.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.View
{
    public partial class Register : Form
    {
        AuthController auth = new AuthController();

        public Register()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateRegisterInputs(out string error)
        {
            error = null;
            var username = (txt_regisussername.Text ?? string.Empty).Trim();
            var password = (txt_regispassword.Text ?? string.Empty);
            var email = (txt_regiscomfirm.Text ?? string.Empty).Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                error = "Semua field harus diisi";
                return false;
            }

            if (username.Length < 2)
            {
                error = "Username minimal 2 karakter";
                return false;
            }

            // username must be letters only
            if (!Regex.IsMatch(username, "^[A-Za-z]+$"))
            {
                error = "Username hanya boleh berisi huruf (tanpa angka atau simbol)";
                return false;
            }

            if (password.Length < 6)
            {
                error = "Password minimal 6 karakter";
                return false;
            }

            // simple email validation: must end with @gmail.com
            if (!email.EndsWith("@gmail.com", StringComparison.InvariantCultureIgnoreCase))
            {
                error = "Email harus berformat dan menggunakan domain '@gmail.com'";
                return false;
            }

            // basic overall email format check
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                {
                    error = "Format email tidak valid";
                    return false;
                }
            }
            catch
            {
                error = "Format email tidak valid";
                return false;
            }

            return true;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string validationError;
            if (!ValidateRegisterInputs(out validationError))
            {
                MessageBox.Show(validationError, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = auth.Register(
                txt_regisussername.Text.Trim(),
                txt_regispassword.Text,
                txt_regiscomfirm.Text.Trim()
            );

            if (result)
            {
                MessageBox.Show("Registrasi berhasil, silakan login");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void checkBox_regisshow_CheckedChanged(object sender, EventArgs e)
        {
            txt_regispassword.UseSystemPasswordChar = !checkBox_regisshow.Checked;
        }
    }
}
