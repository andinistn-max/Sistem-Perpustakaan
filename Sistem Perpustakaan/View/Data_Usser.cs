using Sistem_Perpustakaan.Controller;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.View
{
    public partial class Data_Usser : Form
    {
        private UserController userController;
        private int selectedUserId = 0;
        private bool isEditMode = false;
        private string selectedUserRole = ""; // Simpan role user yang dipilih
        private string selectedPhotoPath = null;

        public Data_Usser()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void Data_Usser_Load(object sender, EventArgs e)
        {
            // set admin username label if present
            try
            {
                string name = Model.Session.CurrentFullName;
                if (string.IsNullOrEmpty(name)) name = Model.Session.CurrentUsername ?? "Admin";
                var lbl = this.Controls.Find("lbl_username", true).FirstOrDefault() as Label;
                if (lbl != null) lbl.Text = name;
            }
            catch { }

            // Load data user ke tabel
            LoadUserData();

            // Setup button states
            UpdateButtonStates();

            // Sembunyikan/hapus label role jika ada
            var lblRole = this.Controls.Find("lbl_role", true).FirstOrDefault() as Label;
            if (lblRole != null) lblRole.Visible = false;

            // Wire button events in case designer didn't wire them
            if (btn_add != null) btn_add.Click += btn_add_Click;
            if (btn_update != null) btn_update.Click += btn_update_Click;
            if (btn_delete != null) btn_delete.Click += btn_delete_Click;
            if (btn_upload != null) btn_upload.Click += btn_upload_Click;

            // Wire search text changed (designer already wired but ensure)
            if (txt_search != null) txt_search.TextChanged += guna2TextBox1_TextChanged;

            // Configure and wire dgv events
            if (dgv_datauser != null)
            {
                dgv_datauser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_datauser.MultiSelect = false;
                dgv_datauser.ReadOnly = true;
                dgv_datauser.AllowUserToAddRows = false;

                dgv_datauser.CellClick += dgv_datauser_CellClick;
                dgv_datauser.CellContentClick += dataGridView1_CellContentClick; // keep compatibility
                dgv_datauser.SelectionChanged += dgv_datauser_SelectionChanged;
            }
        }

        // When selection changes, use first selected row to populate form
        private void dgv_datauser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_datauser?.SelectedRows.Count > 0)
            {
                var row = dgv_datauser.SelectedRows[0];
                SelectUserFromGridRow(row.Index);
            }
        }

        // Method untuk load data user ke DataGridView
        private void LoadUserData(string searchKeyword = "")
        {
            userController.LoadUsersToGrid(dgv_datauser, searchKeyword);

            // setelah data bind, jika kolom Photo ada, ubah tampilannya menjadi image
            if (dgv_datauser.Columns.Contains("Photo"))
            {
                // buat kolom gambar baru jika belum image
                if (!(dgv_datauser.Columns["Photo"] is DataGridViewImageColumn) && !dgv_datauser.Columns.Contains("PhotoImg"))
                {
                    var imgCol = new DataGridViewImageColumn()
                    {
                        Name = "PhotoImg",
                        HeaderText = "Foto",
                        ImageLayout = DataGridViewImageCellLayout.Zoom
                    };

                    // tambahkan sebelum kolom Photo string
                    int idx = dgv_datauser.Columns["Photo"].Index;
                    dgv_datauser.Columns.Insert(idx, imgCol);
                }

                // set tinggi row agar gambar muat dan rapih
                dgv_datauser.RowTemplate.Height = 85;
                dgv_datauser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                // konversi setiap baris ke gambar jika file tersedia
                foreach (DataGridViewRow r in dgv_datauser.Rows)
                {
                    var val = r.Cells["Photo"].Value?.ToString();
                    if (!string.IsNullOrEmpty(val) && File.Exists(val))
                    {
                        try
                        {
                            using (var fs = new FileStream(val, FileMode.Open, FileAccess.Read))
                            {
                                var img = Image.FromStream(fs);
                                r.Cells["PhotoImg"].Value = new Bitmap(img);
                            }
                        }
                        catch { r.Cells["PhotoImg"].Value = null; }
                    }
                    else
                    {
                        r.Cells["PhotoImg"].Value = null;
                    }
                }

                // hide original path column
                dgv_datauser.Columns["Photo"].Visible = false;

                // Hide password column for security if present
                if (dgv_datauser.Columns.Contains("Password"))
                    dgv_datauser.Columns["Password"].Visible = false;

                // Tweak column sizing to ensure fields visible
                dgv_datauser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Prefer reasonable widths for important columns
                if (dgv_datauser.Columns.Contains("PhotoImg"))
                    dgv_datauser.Columns["PhotoImg"].Width = 90;
                if (dgv_datauser.Columns.Contains("Username"))
                    dgv_datauser.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (dgv_datauser.Columns.Contains("Nama Lengkap"))
                    dgv_datauser.Columns["Nama Lengkap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgv_datauser.Columns.Contains("Email"))
                    dgv_datauser.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (dgv_datauser.Columns.Contains("Role"))
                    dgv_datauser.Columns["Role"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (dgv_datauser.Columns.Contains("Tanggal Daftar"))
                {
                    dgv_datauser.Columns["Tanggal Daftar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgv_datauser.Columns["Tanggal Daftar"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }

                // prevent row header from showing (cleaner)
                dgv_datauser.RowHeadersVisible = false;

                // ensure selection mode
                dgv_datauser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        // Update state button berdasarkan mode (edit/tambah)
        private void UpdateButtonStates()
        {
            btn_add.Enabled = !isEditMode;
            btn_update.Enabled = isEditMode;
            btn_delete.Enabled = isEditMode && selectedUserId > 0;


            // Update label status if exists
            var lbl_status = this.Controls.Find("lbl_status", true).FirstOrDefault() as Label;
            if (lbl_status != null)
            {
                lbl_status.Text = isEditMode ? $"Mode: Edit User (Role: {selectedUserRole})" : "Mode: Tambah User Baru";
            }

            var lbl_userid = this.Controls.Find("lbl_userid", true).FirstOrDefault() as Label;
            if (lbl_userid != null)
            {
                lbl_userid.Text = isEditMode ? $"ID User: {selectedUserId}" : "ID User: -";
                lbl_userid.Visible = isEditMode;
            }
        }

        // Central selection logic by row index
        private void SelectUserFromGridRow(int rowIndex)
        {
            if (dgv_datauser == null) return;
            if (rowIndex < 0 || rowIndex >= dgv_datauser.Rows.Count) return;

            var row = dgv_datauser.Rows[rowIndex];

            // Ambil ID User dari kolom pertama
            if (int.TryParse(row.Cells[0].Value?.ToString(), out int userId))
            {
                selectedUserId = userId;
                isEditMode = true;

                // Ambil role dari kolom 'Role' jika ada
                if (dgv_datauser.Columns.Contains("Role") && row.Cells["Role"].Value != null)
                {
                    selectedUserRole = row.Cells["Role"].Value.ToString();
                }
                else if (row.Cells.Count > 4 && row.Cells[4].Value != null)
                {
                    selectedUserRole = row.Cells[4].Value.ToString();
                }

                // Isi form dengan data user yang dipilih (TERMASUK PASSWORD)
                userController.FillFormWithUserData(
                    selectedUserId,
                    txt_ussername,
                    txt_fullname,
                    txt_email,
                    txt_password
                );

                // tampilkan foto jika ada
                if (dgv_datauser.Columns.Contains("Photo"))
                {
                    var path = row.Cells["Photo"].Value?.ToString();
                    if (!string.IsNullOrEmpty(path) && File.Exists(path))
                    {
                        try
                        {
                            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                            {
                                var img = Image.FromStream(fs);
                                picturebox_datauser.Image = new Bitmap(img);
                            }
                            selectedPhotoPath = path;
                        }
                        catch { picturebox_datauser.Image = null; selectedPhotoPath = null; }
                    }
                    else
                    {
                        picturebox_datauser.Image = null;
                        selectedPhotoPath = null;
                    }
                }

                UpdateButtonStates();
            }
            else
            {
                // Jika ID tidak bisa diparse, reset
                ClearForm();
            }
        }

        // Event: CellContentClick handler wired in designer
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectUserFromGridRow(e.RowIndex);
        }

        // Also handle CellClick
        private void dgv_datauser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectUserFromGridRow(e.RowIndex);
        }

        // Event: Button Add Click - Tambah user baru
        private void btn_add_Click(object sender, EventArgs e)
        {
            // Validasi input (TANPA VALIDASI ROLE)
            if (string.IsNullOrWhiteSpace(txt_ussername.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text) ||
                string.IsNullOrWhiteSpace(txt_fullname.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Panggil controller untuk tambah user
            bool success = userController.AddUser(
                txt_ussername.Text.Trim(),
                txt_password.Text,
                txt_fullname.Text.Trim(),
                txt_email.Text.Trim(),
                selectedPhotoPath
            );

            if (success)
            {
                // Clear form dan reload data
                ClearForm();
                LoadUserData();
            }
        }

        // Event: Button Update Click - Update data user
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedUserId <= 0)
            {
                MessageBox.Show("Pilih user terlebih dahulu!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi update
            DialogResult confirm = MessageBox.Show(
                "Apakah Anda yakin ingin mengupdate data user ini?",
                "Konfirmasi Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            // Panggil controller untuk update user (TANPA ROLE)
            bool success = userController.UpdateUser(
                selectedUserId,
                txt_ussername.Text.Trim(),
                txt_fullname.Text.Trim(),
                txt_email.Text.Trim(),
                selectedPhotoPath
            );

            if (success)
            {
                // Clear form dan reload data
                ClearForm();
                LoadUserData();
            }
        }

        // Event: Button Delete Click - Hapus user
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedUserId <= 0)
            {
                MessageBox.Show("Pilih user terlebih dahulu!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Panggil controller untuk hapus user
            bool success = userController.DeleteUser(selectedUserId);

            if (success)
            {
                // Clear form dan reload data
                ClearForm();
                LoadUserData();
            }
        }

        // Event: Button Clear Click - Reset form
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Event: search text changed
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadUserData(txt_search.Text.Trim());
        }

        // Event: Label Close Click - Tutup aplikasi
        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method untuk clear form input
        private void ClearForm()
        {
            if (txt_ussername != null) txt_ussername.Clear();
            if (txt_password != null) { txt_password.Clear(); /* no placeholder available */ }
            if (txt_fullname != null) txt_fullname.Clear();
            if (txt_email != null) txt_email.Clear();

            if (picturebox_datauser != null) picturebox_datauser.Image = null;
            selectedPhotoPath = null;

            selectedUserId = 0;
            isEditMode = false;
            selectedUserRole = "";

            if (dgv_datauser != null && dgv_datauser.SelectedRows.Count > 0)
            {
                dgv_datauser.ClearSelection();
            }

            UpdateButtonStates();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Upload handler now implemented
        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png", Title = "Pilih Foto User" };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedPhotoPath = ofd.FileName;
                    // show preview in picturebox and fit to box
                    if (File.Exists(selectedPhotoPath))
                    {
                        try
                        {
                            using (var fs = new FileStream(selectedPhotoPath, FileMode.Open, FileAccess.Read))
                            {
                                var img = Image.FromStream(fs);
                                picturebox_datauser.Image = new Bitmap(img);
                            }
                        }
                        catch { picturebox_datauser.Image = null; }
                    }
                    picturebox_datauser.SizeMode = PictureBoxSizeMode.Zoom;

                    // if currently editing a user, immediately update DB photo field
                    if (isEditMode && selectedUserId > 0)
                    {
                        bool ok = userController.UpdateUserInDatabase(selectedUserId, txt_ussername.Text.Trim(), txt_fullname.Text.Trim(), txt_email.Text.Trim(), selectedPhotoPath);
                        if (ok)
                        {
                            MessageBox.Show("Foto berhasil di-upload dan disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUserData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menyimpan foto ke database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memilih foto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_databuku_Click(object sender, EventArgs e)
        {
            DataBuku data_buku = new DataBuku();
            data_buku.Show();
            this.Hide();

        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            LaporanAdmin laporan_admin = new LaporanAdmin();
            laporan_admin.Show();
            this.Hide();
        }

        private void btn_tp_Click(object sender, EventArgs e)
        {
            Peminjaman pmj = new Peminjaman();
            pmj.Show();
            this.Hide();
        }
    }
}