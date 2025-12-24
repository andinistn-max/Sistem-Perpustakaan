using MySql.Data.MySqlClient;
using Sistem_Perpustakaan.Model;
using System.Collections.Generic;

namespace Sistem_Perpustakaan.Controller
{
    internal class BookController
    {
        Connection conn = new Connection();

        // Ambil semua buku
        public List<BookModel> GetAllBooks()
        {
            List<BookModel> list = new List<BookModel>();
            var connection = conn.GetConn();
            if (connection == null) return list;

            string query = "SELECT title, author, category, stock FROM books";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new BookModel
                {
                    Title = reader.GetString("title"),
                    Author = reader.GetString("author"),
                    Category = reader.IsDBNull(reader.GetOrdinal("category")) ? "-" : reader.GetString("category"),
                    Stock = reader.GetInt32("stock")
                });
            }

            reader.Close();
            connection.Close();

            return list;
        }

        // Search buku
        public List<BookModel> SearchBooks(string keyword)
        {
            List<BookModel> list = new List<BookModel>();
            var connection = conn.GetConn();
            if (connection == null) return list;

            string query = @"SELECT title, author, category, stock 
                             FROM books 
                             WHERE title LIKE @key OR author LIKE @key";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new BookModel
                {
                    Title = reader.GetString("title"),
                    Author = reader.GetString("author"),
                    Category = reader.IsDBNull(reader.GetOrdinal("category")) ? "-" : reader.GetString("category"),
                    Stock = reader.GetInt32("stock")
                });
            }

            reader.Close();
            connection.Close();

            return list;
        }
    }
}
