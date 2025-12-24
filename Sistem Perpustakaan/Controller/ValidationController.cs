using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.Controller
{
    internal class ValidationController
    {
        public bool ValidationLogin(string username, string password)
        {
            // Username tidak boleh kosong
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username tidak boleh kosong!");
                return false;
            }

            // Password tidak boleh kosong
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password tidak boleh kosong!");
                return false;
            }

            // Username tidak boleh mengandung spasi
            if (username.Contains(" "))
            {
                MessageBox.Show("Username tidak boleh mengandung spasi!");
                return false;
            }

            // Password tidak boleh mengandung spasi
            if (password.Contains(" "))
            {
                MessageBox.Show("Password tidak boleh mengandung spasi!");
                return false;
            }

            // Minimal 3 karakter
            if (username.Length < 3)
            {
                MessageBox.Show("Username minimal 3 karakter!");
                return false;
            }

            if (password.Length < 3)
            {
                MessageBox.Show("Password minimal 3 karakter!");
                return false;
            }

            return true; // Valid
        }

        // VALIDASI ID BUKU (angka saja, max 5 digit)
        public bool ValidationID(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("ID buku tidak boleh kosong!");
                return false;
            }

            if (id.Contains(" "))
            {
                MessageBox.Show("ID tidak boleh mengandung spasi!");
                return false;
            }

            if (id.Length > 5)
            {
                MessageBox.Show("ID maksimal 5 digit!");
                return false;
            }

            foreach (char c in id)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("ID hanya boleh berisi angka!");
                    return false;
                }
            }

            return true;
        }

        // VALIDASI TITLE (huruf + spasi, minimal 2 huruf)
        public bool ValidationTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Judul buku tidak boleh kosong!");
                return false;
            }

            if (title.Length < 2)
            {
                MessageBox.Show("Judul buku minimal 2 huruf!");
                return false;
            }

            foreach (char c in title)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Judul hanya boleh berisi huruf dan spasi!");
                    return false;
                }
            }

            return true;
        }

        // VALIDASI AUTHOR
        public bool ValidationAuthor(string author)
        {
            if (string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Nama penulis tidak boleh kosong!");
                return false;
            }

            foreach (char c in author)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Penulis hanya boleh berisi huruf dan spasi!");
                    return false;
                }
            }

            return true;
        }

        // VALIDASI CATEGORY
        public bool ValidationCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Kategori tidak boleh kosong!");
                return false;
            }

            foreach (char c in category)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Kategori hanya boleh berisi huruf dan spasi!");
                    return false;
                }
            }

            return true;
        }

        // VALIDASI STOCK (angka)
        public bool ValidationStock(string stock)
        {
            if (string.IsNullOrWhiteSpace(stock))
            {
                MessageBox.Show("Stok tidak boleh kosong!");
                return false;
            }

            foreach (char c in stock)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Stok hanya boleh berisi angka!");
                    return false;
                }
            }

            return true;
        }

    }
}
