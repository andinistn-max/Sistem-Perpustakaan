using MySql.Data.MySqlClient;
using Sistem_Perpustakaan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.Controller
{
    internal class AuthController : Connection
    {
        public DataTable Login(string username, string password)
        {
            var dt = new DataTable();
            try
            {
                username = (username ?? string.Empty).Trim();
                password = (password ?? string.Empty).Trim();

                MySqlConnection conn = GetConn();

                if (conn == null)
                {
                    System.Windows.Forms.MessageBox.Show("Gagal koneksi ke database. Periksa pengaturan koneksi.", "Connection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return dt;
                }

                string query = @"SELECT id_user, username, role, full_name 
                                 FROM users 
                                 WHERE username = @username 
                                 AND password = @password";

                using (var cmdLocal = new MySqlCommand(query, conn))
                {
                    cmdLocal.Parameters.AddWithValue("@username", username);
                    cmdLocal.Parameters.AddWithValue("@password", password);

                    using (var daLocal = new MySqlDataAdapter(cmdLocal))
                    {
                        daLocal.Fill(dt);
                    }
                }

                // close connection if still open
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                if (dt.Rows.Count == 0)
                {
                    // provide helpful debug info
                    System.Windows.Forms.MessageBox.Show("Login gagal: tidak ditemukan user dengan username/password yang diberikan.\n\nPeriksa: 1) Data users di database; 2) Apakah Anda sudah menambahkan akun admin.\n\nContoh SQL untuk menambah admin:\nINSERT INTO users (username, password, email, role) VALUES ('admin','admin123','admin@mail.com','admin');", "Login Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                else
                {
                    // store session info
                    try
                    {
                        Session.CurrentUserId = Convert.ToInt32(dt.Rows[0]["id_user"]);
                        Session.CurrentUsername = dt.Rows[0]["username"]?.ToString() ?? string.Empty;
                        Session.CurrentFullName = dt.Rows[0]["full_name"]?.ToString() ?? Session.CurrentUsername;
                        Session.CurrentRole = dt.Rows[0]["role"].ToString();

                    }
                    catch { }
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Login error: " + ex.Message);
            }

            return dt;
        }



        //public DataTable Login(string username, string password)
        //{
        //    DataTable dt = new DataTable();
        //    MySqlConnection conn = GetConn();
        //    if (conn == null) return dt;

        //    string query = @"SELECT id_user, username, role, full_name 
        //             FROM users 
        //             WHERE username = @username AND password = @password";

        //    using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@username", username.Trim());
        //        cmd.Parameters.AddWithValue("@password", password.Trim());

        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //        da.Fill(dt);
        //    }

        //    conn.Close();

        //    if (dt.Rows.Count > 0)
        //    {
        //        Session.CurrentUserId = Convert.ToInt32(dt.Rows[0]["id_user"]);
        //        Session.CurrentUsername = dt.Rows[0]["username"].ToString();
        //        Session.CurrentFullName = dt.Rows[0]["full_name"]?.ToString();
        //        Session.CurrentRole = dt.Rows[0]["role"].ToString();
        //    }

        //    return dt;
        //}


        public bool Register(string username, string password, string email)
        {
            try
            {
                MySqlConnection conn = GetConn();

                string query = @"INSERT INTO users (username, password, email, role) 
                         VALUES (@username, @password, @email, 'user')";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Register gagal: " + ex.Message);
                return false;
            }
        }


        // Tambahkan method ini di class AuthController:

        // Cek apakah username sudah ada
        public bool IsUsernameExists(string username)
        {
            try
            {
                MySqlConnection conn = GetConn();
                if (conn == null) return false;

                string query = "SELECT COUNT(*) FROM users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username: " + ex.Message);
                return false;
            }
        }

    }
}
