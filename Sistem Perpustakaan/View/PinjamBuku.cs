using Sistem_Perpustakaan.Controller;
using Sistem_Perpustakaan.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistem_Perpustakaan.View
{
    public partial class PinjamBuku : Form
    {
        PinjamController controller = new PinjamController();
        UserController userController = new UserController();

        // Use session user id
        int idUserLogin = 0;

        public PinjamBuku()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // get current user from session
            try
            {
                idUserLogin = Model.Session.CurrentUserId;
            }
            catch { idUserLogin = 0; }
        }

        private void PinjamBuku_Load(object sender, EventArgs e)
        {
            LoadBooks();

            // set user label from session (if designer has lbl_user)
            try
            {
                string name = Session.CurrentFullName;
                if (string.IsNullOrEmpty(name)) name = Session.CurrentUsername ?? "User";
                var lbl = this.Controls.Find("lbl_user", true).FirstOrDefault() as Label;
                if (lbl != null) lbl.Text = name;
            }
            catch { }

            // Try to load user's full name from database; fallback to username placeholder
            try
            {
                if (idUserLogin <= 0)
                {
                    txt_peminjam.Text = "User belum login";
                }
                else
                {
                    var dt = userController.GetUserByIdFromDatabase(idUserLogin);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        txt_peminjam.Text = dt.Rows[0]["full_name"].ToString();
                    }
                    else
                    {
                        txt_peminjam.Text = "User";
                    }
                }
            }
            catch
            {
                txt_peminjam.Text = "User";
            }

            // Allow editing the peminjam name if user wants to change it
            txt_peminjam.ReadOnly = false;

            // Make borrow date editable
            dtm_pjm.Value = DateTime.Now;
            dtm_pjm.Enabled = true;
            dtm_pjm.ValueChanged -= dtm_pjm_ValueChanged;
            dtm_pjm.ValueChanged += dtm_pjm_ValueChanged;

            // Return date auto-calculated 3 days after borrow date and not editable
            dtm_kembali.Value = dtm_pjm.Value.AddDays(3);
            dtm_kembali.Enabled = false;

            // wire designer button events if not set in designer
            if (btn_pinjam != null)
                btn_pinjam.Click += btnPinjam_Click;

            if (btn_rwypjm != null)
                btn_rwypjm.Click += btn_rwypjm_Click;

            if (btn_pinjambuku != null)
                btn_pinjambuku.Click += btn_pinjambuku_Click;

            if (btn_daftarbuku != null)
                btn_daftarbuku.Click += btn_daftarbuku_Click;

            if (btn_logout != null)
                btn_logout.Click += btn_logout_Click;
        }

        private void dtm_pjm_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtm_kembali.Value = dtm_pjm.Value.AddDays(3);
            }
            catch
            {
                // ignore invalid value changes
            }
        }

        private void LoadBooks()
        {
            cmb_pilihbuku.Items.Clear();
            var books = controller.GetAvailableBooks();

            foreach (var book in books)
            {
                cmb_pilihbuku.Items.Add(new ComboBoxItem(book.Value, book.Key));
            }

            if (cmb_pilihbuku.Items.Count > 0)
                cmb_pilihbuku.SelectedIndex = 0;
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            if (cmb_pilihbuku.SelectedItem == null)
            {
                MessageBox.Show("Pilih buku terlebih dahulu!");
                return;
            }

            if (idUserLogin <= 0)
            {
                MessageBox.Show("User belum login. Silakan login terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboBoxItem selectedBook = (ComboBoxItem)cmb_pilihbuku.SelectedItem;

            PinjamModel model = new PinjamModel
            {
                IdUser = idUserLogin,
                IdBook = selectedBook.Value,
                Qty = (int)num_qty.Value,   
                BorrowDate = dtm_pjm.Value,
                DueDate = dtm_kembali.Value
            };

            bool success = controller.InsertBorrow(model);

            if (success)
            {
                MessageBox.Show("Peminjaman berhasil!");
                LoadBooks(); // refresh stok
            }
        }

        // Navigation button handlers referenced by designer
        private void btn_rwypjm_Click(object sender, EventArgs e)
        {
            try
            {
                RiwayatPeminjaman r = new RiwayatPeminjaman(idUserLogin);
                r.Show();
                this.Close();
            }
            catch
            {
                // ignore if form not available
            }
        }

        private void btn_pinjambuku_Click(object sender, EventArgs e)
        {
            // already on PinjamBuku, do nothing
        }

        private void btn_daftarbuku_Click(object sender, EventArgs e)
        {
            try
            {
                DftarBuku d = new DftarBuku();
                d.Show();
                this.Close();
            }
            catch
            {
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                Login l = new Login();
                l.Show();
                this.Hide();
            }
            catch
            {
            }
        }

        private void btn_pinjam_Click(object sender, EventArgs e)
        {

        }

        private void btn_dasboard_Click(object sender, EventArgs e)
        {
            Dasboard_User d = new Dasboard_User();
            d.Show();
            this.Hide();

        }
    }

    // Helper untuk ComboBox
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
