using MySql.Data.MySqlClient;
using Sistem_Perpustakaan.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.Controller
{
    internal class PinjamController
    {
        Connection conn = new Connection();

        // Ambil buku yang stok masih ada
        public Dictionary<int, string> GetAvailableBooks()
        {
            Dictionary<int, string> books = new Dictionary<int, string>();
            var connection = conn.GetConn();
            if (connection == null) return books;

            string query = "SELECT id_book, title FROM books WHERE stock > 0";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                books.Add(rd.GetInt32("id_book"), rd.GetString("title"));
            }

            rd.Close();
            connection.Close();
            return books;
        }

        // Simpan peminjaman
        public bool InsertBorrow(PinjamModel model)
        {
            MySqlConnection connection = conn.GetConn();
            if (connection == null) return false;

            try
            {
                // Validate user exists
                string qUser = "SELECT COUNT(*) FROM users WHERE id_user = @id";
                using (var cmdUser = new MySqlCommand(qUser, connection))
                {
                    cmdUser.Parameters.AddWithValue("@id", model.IdUser);
                    int userCount = Convert.ToInt32(cmdUser.ExecuteScalar() ?? 0);
                    if (userCount == 0)
                    {
                        MessageBox.Show($"User dengan id {model.IdUser} tidak ditemukan. Silakan login dengan akun yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                        return false;
                    }
                }

                // Validate book exists and has stock
                string qStock = "SELECT stock FROM books WHERE id_book = @id";
                using (var cmdStock = new MySqlCommand(qStock, connection))
                {
                    cmdStock.Parameters.AddWithValue("@id", model.IdBook);
                    object stockObj = cmdStock.ExecuteScalar();
                    if (stockObj == null)
                    {
                        MessageBox.Show($"Buku dengan id {model.IdBook} tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                        return false;
                    }

                    int stock = Convert.ToInt32(stockObj);
                    if (stock <= 0)
                    {
                        MessageBox.Show("Stok buku habis.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        return false;
                    }
                }

                // Insert peminjaman and let DB trigger reduce stock
                string query = @"INSERT INTO borrowings 
                            (id_user, id_book, borrow_date, due_date, status) 
                            VALUES (@user, @book, @borrow, @due, 'dipinjam')";

                using (var trans = connection.BeginTransaction())
                using (var cmd = new MySqlCommand(query, connection, trans))
                {
                    cmd.Parameters.AddWithValue("@user", model.IdUser);
                    cmd.Parameters.AddWithValue("@book", model.IdBook);
                    cmd.Parameters.AddWithValue("@borrow", model.BorrowDate);
                    cmd.Parameters.AddWithValue("@due", model.DueDate);

                    cmd.ExecuteNonQuery();
                    trans.Commit();
                }

                connection.Close();
                return true;
            }
            catch (MySqlException mex)
            {
                MessageBox.Show("Database error saat memproses peminjaman: " + mex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try { if (connection.State == System.Data.ConnectionState.Open) connection.Close(); } catch { }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memproses peminjaman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try { if (connection.State == System.Data.ConnectionState.Open) connection.Close(); } catch { }
                return false;
            }
        }
    }
}
