using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Sistem_Perpustakaan.Model;

namespace Sistem_Perpustakaan.Controller
{
    public class UserController
    {
        private Connection dbConn;

        public UserController()
        {
            dbConn = new Connection();
        }

        // ============== METHOD UNTUK OPERASI DATABASE ==============

        // READ - Ambil semua user dari database
        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = dbConn.GetConn())
                {
                    if (conn == null) return dt;

                    string query = @"SELECT 
                                        id_user AS 'ID User',
                                        username AS 'Username', 
                                        password AS 'Password',
                                        full_name AS 'Nama Lengkap', 
                                        email AS 'Email', 
                                        role AS 'Role',
                                        photo AS 'Photo',
                                        created_at AS 'Tanggal Daftar'
                                    FROM users 
                                    ORDER BY id_user DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting users: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        // CREATE - Tambah user baru ke database (ROLE OTOMATIS "user")
        public bool AddUserToDatabase(string username, string password, string fullName, string email, string photoPath = null)
        {
            try
            {
                using (MySqlConnection conn = dbConn.GetConn())
                {
                    if (conn == null) return false;

                    // Role otomatis "user" (tidak bisa pilih admin)
                    string query = @"INSERT INTO users 
                                    (username, password, full_name, email, role, photo) 
                                    VALUES (@username, @password, @full_name, @email, 'user', @photo)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@full_name", fullName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@photo", photoPath ?? (object)DBNull.Value);

                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry error
                {
                    MessageBox.Show("Username sudah digunakan!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error adding user: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

        // UPDATE - Update data user di database (TIDAK BISA UBAH ROLE)
        public bool UpdateUserInDatabase(int userId, string username, string fullName, string email, string photoPath = null)
        {
            try
            {
                using (MySqlConnection conn = dbConn.GetConn())
                {
                    if (conn == null) return false;

                    // Query tidak update role (dan tidak mengubah password)
                    string query;

                    if (!string.IsNullOrEmpty(photoPath))
                    {
                        query = @"UPDATE users 
                                    SET username = @username, 
                                        full_name = @full_name, 
                                        email = @email,
                                        photo = @photo
                                    WHERE id_user = @id_user";
                    }
                    else
                    {
                        query = @"UPDATE users 
                                    SET username = @username, 
                                        full_name = @full_name, 
                                        email = @email
                                    WHERE id_user = @id_user";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_user", userId);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@full_name", fullName);
                    cmd.Parameters.AddWithValue("@email", email);

                    if (!string.IsNullOrEmpty(photoPath))
                        cmd.Parameters.AddWithValue("@photo", photoPath);

                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry
                {
                    MessageBox.Show("Username sudah digunakan!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error updating user: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

        // DELETE - Hapus user dari database (sama seperti sebelumnya)
        public bool DeleteUserFromDatabase(int userId)
        {
            try
            {
                using (MySqlConnection conn = dbConn.GetConn())
                {
                    if (conn == null) return false;

                    // Cek apakah ada riwayat peminjaman
                    string checkQuery = "SELECT COUNT(*) FROM borrowings WHERE id_user = @id_user";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@id_user", userId);

                    int borrowCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (borrowCount > 0)
                    {
                        MessageBox.Show("User tidak dapat dihapus karena memiliki riwayat peminjaman!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                        return false;
                    }

                    // Cek role admin
                    string checkRoleQuery = "SELECT role FROM users WHERE id_user = @id_user";
                    MySqlCommand checkRoleCmd = new MySqlCommand(checkRoleQuery, conn);
                    checkRoleCmd.Parameters.AddWithValue("@id_user", userId);

                    string role = checkRoleCmd.ExecuteScalar()?.ToString();

                    if (role == "admin")
                    {
                        MessageBox.Show("Tidak dapat menghapus user dengan role admin!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                        return false;
                    }

                    // Hapus user
                    string deleteQuery = "DELETE FROM users WHERE id_user = @id_user";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@id_user", userId);

                    int result = deleteCmd.ExecuteNonQuery();
                    conn.Close();

                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // SEARCH - Cari user berdasarkan keyword
        public DataTable SearchUsersInDatabase(string keyword)
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = dbConn.GetConn())
                {
                    if (conn == null) return dt;

                    string query = @"SELECT 
                                        id_user AS 'ID User',
                                        username AS 'Username',
                                        password AS 'Password',
                                        full_name AS 'Nama Lengkap', 
                                        email AS 'Email', 
                                        role AS 'Role',
                                        photo AS 'Photo',
                                        created_at AS 'Tanggal Daftar'
                                    FROM users 
                                    WHERE username LIKE @keyword 
                                       OR full_name LIKE @keyword 
                                       OR email LIKE @keyword
                                    ORDER BY id_user DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching users: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        // GET - Ambil data user berdasarkan ID untuk form edit (TERMASUK PASSWORD)
        public DataTable GetUserByIdFromDatabase(int userId)
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = dbConn.GetConn())
                {
                    if (conn == null) return dt;

                    string query = @"SELECT id_user, username, password, full_name, email, photo FROM users WHERE id_user = @id_user";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_user", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        // CHECK - Cek apakah username sudah ada di database
        public bool IsUsernameExistsInDatabase(string username, int excludeId = 0)
        {
            try
            {
                using (MySqlConnection conn = dbConn.GetConn())
                {
                    if (conn == null) return false;

                    string query = "SELECT COUNT(*) FROM users WHERE username = @username";
                    if (excludeId > 0)
                        query += " AND id_user != @excludeId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    if (excludeId > 0)
                        cmd.Parameters.AddWithValue("@excludeId", excludeId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ============== METHOD UNTUK LOGIKA BISNIS ==============

        // Load data ke DataGridView
        public void LoadUsersToGrid(DataGridView dataGridView, string searchKeyword = "")
        {
            try
            {
                DataTable dt;

                if (string.IsNullOrWhiteSpace(searchKeyword))
                    dt = GetAllUsers();
                else
                    dt = SearchUsersInDatabase(searchKeyword);

                dataGridView.DataSource = dt;

                // Format kolom jika ada data
                if (dataGridView.Columns.Count > 0)
                {
                    // Format tanggal
                    if (dataGridView.Columns.Contains("Tanggal Daftar"))
                    {
                        dataGridView.Columns["Tanggal Daftar"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                        dataGridView.Columns["Tanggal Daftar"].Width = 150;
                    }

                    // Atur lebar kolom
                    if (dataGridView.Columns.Contains("Nama Lengkap"))
                        dataGridView.Columns["Nama Lengkap"].Width = 200;

                    if (dataGridView.Columns.Contains("Email"))
                        dataGridView.Columns["Email"].Width = 200;

                    // Warna bedakan role
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells["Role"].Value?.ToString() == "admin")
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCyan;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validasi input user (TANPA VALIDASI ROLE)
        private bool ValidateUserInput(string username, string password, string fullName, string email, bool isUpdate = false)
        {
            // Cek field wajib
            if (string.IsNullOrWhiteSpace(username) ||
                (!isUpdate && string.IsNullOrWhiteSpace(password)) ||
                string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Semua field harus diisi!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validasi username
            if (username.Contains(" "))
            {
                MessageBox.Show("Username tidak boleh mengandung spasi!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validasi panjang password untuk tambah user baru
            if (!isUpdate && password.Length < 3)
            {
                MessageBox.Show("Password minimal 3 karakter!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validasi format email
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Format email tidak valid!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Tambah user baru (gabungan validasi + database) - ROLE OTOMATIS "user"
        public bool AddUser(string username, string password, string fullName, string email, string photoPath = null)
        {
            try
            {
                // Validasi input
                if (!ValidateUserInput(username, password, fullName, email, false))
                    return false;

                // Cek duplikasi username
                if (IsUsernameExistsInDatabase(username))
                {
                    MessageBox.Show("Username sudah digunakan!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Simpan ke database (role otomatis "user")
                bool result = AddUserToDatabase(username, password, fullName, email, photoPath);

                if (result)
                {
                    MessageBox.Show("User berhasil ditambahkan dengan role 'user'!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Update data user (TIDAK BISA UBAH ROLE)
        public bool UpdateUser(int userId, string username, string fullName, string email, string photoPath = null)
        {
            try
            {
                // Validasi input (password tidak wajib untuk update)
                if (!ValidateUserInput(username, "", fullName, email, true))
                    return false;

                // Cek duplikasi username (kecuali user ini sendiri)
                if (IsUsernameExistsInDatabase(username, userId))
                {
                    MessageBox.Show("Username sudah digunakan!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Update ke database (role tetap)
                bool result = UpdateUserInDatabase(userId, username, fullName, email, photoPath);

                if (result)
                {
                    MessageBox.Show("Data user berhasil diupdate! (Role tidak dapat diubah)", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Hapus user
        public bool DeleteUser(int userId)
        {
            try
            {
                // Konfirmasi penghapusan
                DialogResult confirm = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus user ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return false;

                // Hapus dari database
                bool result = DeleteUserFromDatabase(userId);

                if (result)
                {
                    MessageBox.Show("User berhasil dihapus!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Isi form dengan data user yang dipilih (TERMASUK PASSWORD)
        public void FillFormWithUserData(int userId, TextBox txtUsername, TextBox txtFullName, TextBox txtEmail, TextBox txtPassword)
        {
            try
            {
                DataTable dt = GetUserByIdFromDatabase(userId);

                if (dt.Rows.Count > 0)
                {
                    txtUsername.Text = dt.Rows[0]["username"].ToString();
                    txtFullName.Text = dt.Rows[0]["full_name"].ToString();
                    txtEmail.Text = dt.Rows[0]["email"].ToString();
                    if (txtPassword != null)
                        txtPassword.Text = dt.Rows[0]["password"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}