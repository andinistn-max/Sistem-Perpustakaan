using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Perpustakaan.Controller
{
    internal class BukuController : Model.Connection
    {
        public DataTable GetAllBooks()

        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConn())
            {
                string query = @"SELECT 
                                id_book,
                                title,
                                author,
                                category,
                                stock,
                                photo
                                FROM books";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // ================= INSERT =================
        public void InsertBook(string title, string author, string category, int stock, string photoPath)
        {
            using (MySqlConnection conn = GetConn())
            {
                string query = @"INSERT INTO books
                                (title, author, category, stock, photo)
                                VALUES (@title,@author,@category,@stock,@photo)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@photo", photoPath ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        // ================= UPDATE =================
        public void UpdateBook(int id, string title, string author, string category, int stock, string photoPath)
        {
            using (MySqlConnection conn = GetConn())
            {
                string query;

                if (!string.IsNullOrEmpty(photoPath))
                {
                    query = @"UPDATE books SET
                            title=@title,
                            author=@author,
                            category=@category,
                            stock=@stock,
                            photo=@photo
                            WHERE id_book=@id";
                }
                else
                {
                    query = @"UPDATE books SET
                            title=@title,
                            author=@author,
                            category=@category,
                            stock=@stock
                            WHERE id_book=@id";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@stock", stock);

                if (!string.IsNullOrEmpty(photoPath))
                    cmd.Parameters.AddWithValue("@photo", photoPath);

                cmd.ExecuteNonQuery();
            }
        }

        // ================= DELETE =================
        public void DeleteBook(int id)
        {
            using (MySqlConnection conn = GetConn())
            {
                string query = "DELETE FROM books WHERE id_book=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ================= CEK DIPINJAM =================
        public bool IsBookBorrowed(int idBook)
        {
            using (MySqlConnection conn = GetConn())
            {
                string query = @"SELECT COUNT(*) FROM borrowings
                                 WHERE id_book=@id AND status='dipinjam'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idBook);
                return System.Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // ================= SEARCH 1 PARAMETER (WAJIB ADA) =================
        public DataTable SearchBooks(string keyword)
        {
            return SearchBooks(keyword, "Semua");
        }

        // ================= SEARCH + FILTER KATEGORI =================
        public DataTable SearchBooks(string keyword, string kategori)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConn())
            {
                string query = @"SELECT id_book, title, author, category, stock, photo
                                 FROM books
                                 WHERE (title LIKE @key OR author LIKE @key)
                                 AND (@kategori = 'Semua' OR category = @kategori)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");
                cmd.Parameters.AddWithValue("@kategori", kategori);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
