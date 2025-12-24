using System;
using System.Windows.Forms;
using Sistem_Perpustakaan.Controller;
using Sistem_Perpustakaan.Model;
using System.Drawing;
using System.IO;

namespace Sistem_Perpustakaan.View
{
    public partial class Profiel_Usser : Form
    {
        private UserController userController;
        private int currentUserId = 0;
        private string selectedPhotoPath = null;

        public Profiel_Usser()
        {
            InitializeComponent();
            userController = new UserController();

            // wire events in case designer didn't
            this.Load += Profiel_Usser_Load;
            if (brn_save != null)
            {
                brn_save.Click -= brn_save_Click;
                brn_save.Click += brn_save_Click;
            }
            if (button1 != null)
            {
                button1.Click -= button1_Click;
                button1.Click += button1_Click;
            }
        }

        private void Profiel_Usser_Load(object sender, EventArgs e)
        {
            try
            {
                currentUserId = Model.Session.CurrentUserId;
            }
            catch
            {
                currentUserId = 0;
            }

            if (currentUserId <= 0)
            {
                MessageBox.Show("User belum login.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var dt = userController.GetUserByIdFromDatabase(currentUserId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txt_email.Text = dt.Rows[0]["email"]?.ToString() ?? string.Empty;
                    txt_fullname.Text = dt.Rows[0]["full_name"]?.ToString() ?? string.Empty;
                    // designer uses txt_alamat to show username
                    txt_alamat.Text = dt.Rows[0]["username"]?.ToString() ?? string.Empty;
                    // txt_nohp used to show password in designer (not secure) — display masked
                    txt_nohp.Text = dt.Rows[0]["password"]?.ToString() ?? string.Empty;

                    // load photo path and preview if available
                    selectedPhotoPath = dt.Rows[0]["photo"]?.ToString();
                    if (!string.IsNullOrEmpty(selectedPhotoPath) && File.Exists(selectedPhotoPath))
                    {
                        try
                        {
                            using (var fs = new FileStream(selectedPhotoPath, FileMode.Open, FileAccess.Read))
                            {
                                var img = Image.FromStream(fs);
                                pictureBox_user.Image = new Bitmap(img);
                            }
                            pictureBox_user.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        catch { pictureBox_user.Image = null; }
                    }
                    else
                    {
                        pictureBox_user.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat profil: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brn_save_Click(object sender, EventArgs e)
        {
            if (currentUserId <= 0) return;

            string username = txt_alamat.Text.Trim();
            string fullName = txt_fullname.Text.Trim();
            string email = txt_email.Text.Trim();

            // basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Semua field harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // include photo path so profile and admin view stay in sync
            bool ok = userController.UpdateUserInDatabase(currentUserId, username, fullName, email, selectedPhotoPath);
             if (ok)
             {
                 // update session so dashboard shows latest username/fullname
                 try
                 {
                     Session.CurrentUsername = username;
                     Session.CurrentFullName = fullName;
                 }
                 catch { }

                 MessageBox.Show("Profil berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 // Kembali ke dashboard user
                 try
                 {
                     var dashboard = new Dasboard_User();
                     dashboard.Show();
                     this.Close();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Gagal kembali ke dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
             else
             {
                 // UpdateUserInDatabase already shows messages for errors
             }
         }

         private void button1_Click(object sender, EventArgs e)
         {
             // upload picture
             try
             {
                 OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png", Title = "Pilih Foto Profil" };
                 if (ofd.ShowDialog() == DialogResult.OK)
                 {
                    selectedPhotoPath = ofd.FileName;
                    if (!string.IsNullOrEmpty(selectedPhotoPath) && File.Exists(selectedPhotoPath))
                    {
                        try
                        {
                            using (var fs = new FileStream(selectedPhotoPath, FileMode.Open, FileAccess.Read))
                            {
                                var img = Image.FromStream(fs);
                                pictureBox_user.Image = new Bitmap(img);
                            }
                            pictureBox_user.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        catch { pictureBox_user.Image = null; }
                    }
                 }
             }
             catch
             {
             }
         }
     }
 }
