using MySql.Data.MySqlClient;
using Sistem_Perpustakaan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Perpustakaan.Controller
{
    internal class PeminjamanController
    {
        Connection koneksi = new Connection();

        public List<PeminjamanModel> GetAll(string status, string keyword)
        {
            List<PeminjamanModel> list = new List<PeminjamanModel>();

            MySqlConnection conn = koneksi.GetConn();
            if (conn == null) return list;

            string query = @"
                SELECT * FROM v_peminjaman_admin
                WHERE (@status = 'Semua' OR status = @status)
                AND (username LIKE @key OR title LIKE @key)
                ORDER BY borrow_date DESC";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");

            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new PeminjamanModel
                {
                    IdBorrow = rd.GetInt32("id_borrow"),
                    Username = rd.GetString("username"),
                    FullName = rd["full_name"].ToString(),
                    Title = rd.GetString("title"),
                    BorrowDate = rd.GetDateTime("borrow_date").ToString("yyyy-MM-dd"),
                    DueDate = rd.GetDateTime("due_date").ToString("yyyy-MM-dd"),
                    ReturnDate = rd["return_date"] == System.DBNull.Value ? "-" :
                        ((System.DateTime)rd["return_date"]).ToString("yyyy-MM-dd"),
                    Status = rd.GetString("status"),
                    Fine = rd.GetInt32("fine")
                });
            }

            conn.Close();
            return list;
        }
    }
}
