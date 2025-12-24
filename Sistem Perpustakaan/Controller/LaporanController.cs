using MySql.Data.MySqlClient;
using Sistem_Perpustakaan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Perpustakaan.Controller
{
    internal class LaporanController
    {
        Connection koneksi = new Connection();

        // ===== PANEL ATAS =====
        public LaporanModel GetSummary()
        {
            MySqlConnection conn = koneksi.GetConn();
            if (conn == null) return null;

            string query = @"
                SELECT
                    (SELECT COUNT(*) FROM borrowings) AS total_peminjaman,
                    (SELECT COUNT(*) FROM borrowings WHERE status='dipinjam') AS buku_dipinjam,
                    (SELECT IFNULL(SUM(fine),0) FROM borrowings) AS total_denda
            ";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            LaporanModel laporan = new LaporanModel();

            if (rd.Read())
            {
                laporan.TotalPeminjaman = rd.GetInt32("total_peminjaman");
                laporan.BukuDipinjam = rd.GetInt32("buku_dipinjam");
                laporan.TotalDenda = rd.GetInt32("total_denda");
            }

            conn.Close();
            return laporan;
        }

        // ===== DATAGRID =====
        public DataTable GetLaporan(string jenis)
        {
            MySqlConnection conn = koneksi.GetConn();
            if (conn == null) return null;

            string query = "";

            if (jenis == "Laporan Peminjaman")
                query = "SELECT * FROM v_peminjaman_admin";

            else if (jenis == "Laporan Buku")
                query = "SELECT * FROM v_laporan_peminjaman";

            else if (jenis == "Laporan Denda")
                query = "SELECT * FROM v_laporan_denda";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();
            return dt;
        }
    }
}
