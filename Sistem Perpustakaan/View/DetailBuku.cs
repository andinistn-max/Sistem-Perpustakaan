using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.View
{
    public partial class DetailBuku : Form
    {
        private string photoPath;

        public DetailBuku()
        {
            InitializeComponent();
        }

        // Constructor to populate detail fields
        public DetailBuku(string title, string author, string category, string stock, string photoPath) : this()
        {
            try
            {
                textBox1.Text = title ?? string.Empty;   // Judul
                textBox2.Text = author ?? string.Empty;  // Penulis
                textBox3.Text = category ?? string.Empty; // Kategori
                textBox4.Text = stock ?? string.Empty;    // Stok

                // make textboxes readonly so this is purely a detail view
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;

                this.photoPath = photoPath;

                if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                {
                    try
                    {
                        using (var fs = new FileStream(photoPath, FileMode.Open, FileAccess.Read))
                        {
                            var img = Image.FromStream(fs);
                            pictureBox_buku.Image = new Bitmap(img);
                        }
                        pictureBox_buku.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch
                    {
                        pictureBox_buku.Image = null;
                    }
                }
                else
                {
                    pictureBox_buku.Image = null;
                }

                // wire buttons if not wired by designer
                btn_back.Click -= Btn_back_Click;
                btn_back.Click += Btn_back_Click;

                btn_pjm.Click -= Btn_pjm_Click;
                btn_pjm.Click += Btn_pjm_Click;
            }
            catch
            {
                // ignore initialization errors
            }
        }

        private void DetailBuku_Load(object sender, EventArgs e)
        {
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            // go back to daftar buku
            var list = new DftarBuku();
            list.Show();
            this.Close();
        }

        private void Btn_pjm_Click(object sender, EventArgs e)
        {
            try
            {
                var pinjam = new PinjamBuku();
                pinjam.Show();
                this.Close();
            }
            catch
            {
            }
        }
    }
}
