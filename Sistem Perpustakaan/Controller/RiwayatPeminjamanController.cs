using MySql.Data.MySqlClient;
using Sistem_Perpustakaan.Model;
using System;
using System.Collections.Generic;

namespace Sistem_Perpustakaan.Controller
{
    internal class RiwayatPeminjamanController
    {
        Connection koneksi = new Connection();

        // Ambil riwayat peminjaman user login
        public List<Riwayat> GetByUser(int idUser)
        {
            List<Riwayat> list = new List<Riwayat>();
            var conn = koneksi.GetConn();
            if (conn == null) return list;

            string query = @"
                SELECT b.id_borrow, bk.title, b.borrow_date, b.due_date, b.status, b.fine
                FROM borrowings b
                JOIN books bk ON b.id_book = bk.id_book
                WHERE b.id_user = @id_user
                ORDER BY b.borrow_date DESC";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_user", idUser);

            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Riwayat
                {
                    IdBorrow = rd.GetInt32("id_borrow"),
                    Title = rd.GetString("title"),
                    BorrowDate = rd.GetDateTime("borrow_date").ToString("yyyy-MM-dd"),
                    DueDate = rd.GetDateTime("due_date").ToString("yyyy-MM-dd"),
                    Status = rd.GetString("status"),
                    Fine = rd.GetInt32("fine")
                });
            }

            conn.Close();
            return list;
        }

        // Proses pengembalian buku
        public bool KembalikanBuku(int idBorrow)
        {
            var conn = koneksi.GetConn();
            if (conn == null) return false;

            string query = @"
                UPDATE borrowings
                SET return_date = CURDATE(),
                    status = 'dikembalikan'
                WHERE id_borrow = @id";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", idBorrow);

            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result > 0;
        }
    }
}
