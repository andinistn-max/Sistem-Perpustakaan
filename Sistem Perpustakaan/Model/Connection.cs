using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.Model
{
    internal class Connection
    {
        public MySqlCommand cmd; //Untuk menjalankan perintah SQL (SELECT, INSERT, UPDATE, DELETE).
        public DataSet ds; //Wadah untuk menyimpan data hasil query dari database.
        public MySqlDataAdapter da; //penghubung antara database dan DataTable.

        public MySqlConnection GetConn() //membuat connection ke db
        {
            var connString = "server=localhost;user=root;database=stm_perpustakaan";
            var conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to database: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // return null so caller can handle the failure
                return null;
            }
        }

    }
}
