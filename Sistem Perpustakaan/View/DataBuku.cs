using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Sistem_Perpustakaan.Controller;

namespace Sistem_Perpustakaan.View
{
    public partial class DataBuku : Form
    {
        // ===== GLOBAL =====
        BukuController bukuController;
        int selectedId = 0;
        string selectedPhotoPath = null;
        public DataBuku()
        {
            InitializeComponent();
        }

        // ===== LOAD FORM =====
        private void DataBuku_Load(object sender, EventArgs e)
        {
            bukuController = new BukuController();

            // set admin label from session if designer has one
            try
            {
                string name = Model.Session.CurrentFullName;
                if (string.IsNullOrEmpty(name)) name = Model.Session.CurrentUsername ?? "Admin";
                var lbl = this.Controls.Find("lbl_admin", true).FirstOrDefault() as Label;
                if (lbl != null) lbl.Text = name;
            }
            catch { }

            // wire events (designer wires some but ensure all)
            if (btn_add != null)
            {
                btn_add.Click -= btn_add_Click;
                btn_add.Click += btn_add_Click;
            }
            if (btn_update != null)
            {
                btn_update.Click -= btn_update_Click_1;
                btn_update.Click += btn_update_Click_1;
            }
            if (btn_delete != null)
            {
                btn_delete.Click -= btn_delete_Click_1;
                btn_delete.Click += btn_delete_Click_1;
            }
            if (btn_upload != null)
            {
                btn_upload.Click -= btn_upload_Click_1;
                btn_upload.Click += btn_upload_Click_1;
            }
            if (dgv_databuku != null)
            {
                dgv_databuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_databuku.MultiSelect = false;
                dgv_databuku.ReadOnly = true;
                dgv_databuku.AllowUserToAddRows = false;

                // ensure click handlers wired to populate form
                dgv_databuku.CellClick -= dgv_databuku_CellClick;
                dgv_databuku.CellClick += dgv_databuku_CellClick;
                dgv_databuku.CellContentClick -= dgv_databuku_CellContentClick;
                dgv_databuku.CellContentClick += dgv_databuku_CellContentClick;
                dgv_databuku.SelectionChanged -= dgv_databuku_SelectionChanged;
                dgv_databuku.SelectionChanged += dgv_databuku_SelectionChanged;
            }

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Get raw data from controller (contains 'photo' path column)
                DataTable raw = bukuController.GetAllBooks();

                // Build a display datatable with an Image column first
                DataTable display = new DataTable();
                display.Columns.Add("Foto", typeof(Image));

                // Copy remaining columns from raw into display (keep photo path as string so we can still use it)
                foreach (DataColumn c in raw.Columns)
                {
                    // avoid duplicating Foto
                    if (string.Equals(c.ColumnName, "photo", StringComparison.OrdinalIgnoreCase))
                    {
                        display.Columns.Add("photo", typeof(string));
                    }
                    else
                    {
                        display.Columns.Add(c.ColumnName, c.DataType);
                    }
                }

                // Fill display rows, loading images from file paths safely
                foreach (DataRow r in raw.Rows)
                {
                    var newRow = display.NewRow();

                    // load image
                    Image img = null;
                    string path = null;
                    if (raw.Columns.Contains("photo"))
                        path = r["photo"] == DBNull.Value ? null : r["photo"].ToString();

                    if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
                    {
                        try
                        {
                            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                            {
                                using (var tmp = Image.FromStream(fs))
                                {
                                    img = new Bitmap(tmp); // copy so file lock can be released
                                }
                            }
                        }
                        catch
                        {
                            img = null;
                        }
                    }

                    newRow["Foto"] = img;

                    // copy other columns
                    foreach (DataColumn c in raw.Columns)
                    {
                        var colName = c.ColumnName;
                        if (display.Columns.Contains(colName))
                            newRow[colName] = r[colName] == DBNull.Value ? null : r[colName];
                        else if (display.Columns.Contains("photo") && string.Equals(colName, "photo", StringComparison.OrdinalIgnoreCase))
                            newRow["photo"] = r[colName] == DBNull.Value ? null : r[colName];
                    }

                    display.Rows.Add(newRow);
                }

                // Bind to grid
                dgv_databuku.Columns.Clear();
                dgv_databuku.DataSource = display;

                // Make Foto column an image column (DataGridView will create it since type is Image)
                if (dgv_databuku.Columns.Contains("Foto"))
                {
                    var fotoCol = dgv_databuku.Columns["Foto"] as DataGridViewImageColumn;
                    if (fotoCol != null)
                    {
                        fotoCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        fotoCol.HeaderText = "Foto Buku";
                        fotoCol.Width = 100;
                    }
                }

                // Hide raw photo path column if present
                if (dgv_databuku.Columns.Contains("photo"))
                    dgv_databuku.Columns["photo"].Visible = false;

                dgv_databuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_databuku.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Central selection when selection changes
        private void dgv_databuku_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_databuku?.SelectedRows.Count > 0)
            {
                PopulateFormFromRow(dgv_databuku.SelectedRows[0].Index);
            }
        }

        // ===== KLIK GRID =====
        private void dgv_databuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            PopulateFormFromRow(e.RowIndex);
        }

        private void dgv_databuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            PopulateFormFromRow(e.RowIndex);
        }

        private void PopulateFormFromRow(int rowIndex)
        {
            var row = dgv_databuku.Rows[rowIndex];

            // read by column name to be robust
            object idVal = null;
            object titleVal = null;
            object authorVal = null;
            object categoryVal = null;
            object stockVal = null;

            if (dgv_databuku.Columns.Contains("id_book")) idVal = row.Cells[dgv_databuku.Columns["id_book"].Index].Value;
            else if (row.Cells.Count > 0) idVal = row.Cells[0].Value;

            if (dgv_databuku.Columns.Contains("title")) titleVal = row.Cells[dgv_databuku.Columns["title"].Index].Value;
            else if (row.Cells.Count > 1) titleVal = row.Cells[1].Value;

            if (dgv_databuku.Columns.Contains("author")) authorVal = row.Cells[dgv_databuku.Columns["author"].Index].Value;
            else if (row.Cells.Count > 2) authorVal = row.Cells[2].Value;

            if (dgv_databuku.Columns.Contains("category")) categoryVal = row.Cells[dgv_databuku.Columns["category"].Index].Value;
            else if (row.Cells.Count > 3) categoryVal = row.Cells[3].Value;

            if (dgv_databuku.Columns.Contains("stock")) stockVal = row.Cells[dgv_databuku.Columns["stock"].Index].Value;
            else if (row.Cells.Count > 4) stockVal = row.Cells[4].Value;

            selectedId = 0;
            if (idVal != null && int.TryParse(idVal.ToString(), out int id))
            {
                selectedId = id;
                txt_idbuku.Text = id.ToString();
            }
            else txt_idbuku.Clear();

            txt_judulbuku.Text = titleVal?.ToString() ?? string.Empty;
            txt_penulis.Text = authorVal?.ToString() ?? string.Empty;
            txt_kategori.Text = categoryVal?.ToString() ?? string.Empty;
            txt_stok.Text = stockVal?.ToString() ?? string.Empty;

            // try get photo path from hidden column
            if (dgv_databuku.Columns.Contains("photo"))
            {
                var photoCell = row.Cells[dgv_databuku.Columns["photo"].Index].Value;
                selectedPhotoPath = photoCell?.ToString();
            }
            else selectedPhotoPath = null;

            if (!string.IsNullOrEmpty(selectedPhotoPath) && File.Exists(selectedPhotoPath))
            {
                pictureBox_buku.ImageLocation = selectedPhotoPath;
                pictureBox_buku.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox_buku.Image = null;
            }
        }

        // ===== VALIDATION =====
        private bool ValidateBookInputs(out string error)
        {
            error = null;
            string title = (txt_judulbuku.Text ?? string.Empty).Trim();
            string author = (txt_penulis.Text ?? string.Empty).Trim();
            string category = (txt_kategori.Text ?? string.Empty).Trim();
            string stockStr = (txt_stok.Text ?? string.Empty).Trim();

            // Judul: tidak boleh kosong, minimal 3 karakter
            if (string.IsNullOrEmpty(title))
            {
                error = "Judul buku tidak boleh kosong.";
                return false;
            }
            if (title.Length < 3)
            {
                error = "Judul buku harus minimal 3 karakter.";
                return false;
            }

            // Penulis: tidak boleh kosong, tidak boleh angka semua
            if (string.IsNullOrEmpty(author))
            {
                error = "Penulis tidak boleh kosong.";
                return false;
            }
            bool allDigits = true;
            foreach (char c in author)
            {
                if (!char.IsDigit(c) && !char.IsWhiteSpace(c))
                {
                    allDigits = false;
                    break;
                }
            }
            if (allDigits)
            {
                error = "Penulis tidak boleh hanya berisi angka.";
                return false;
            }

            // Kategori: tidak boleh kosong
            if (string.IsNullOrEmpty(category))
            {
                error = "Kategori tidak boleh kosong.";
                return false;
            }

            // Stok: tidak boleh kosong, harus angka, tidak boleh minus
            if (string.IsNullOrEmpty(stockStr))
            {
                error = "Stok tidak boleh kosong.";
                return false;
            }

            if (!int.TryParse(stockStr, out int stok))
            {
                error = "Stok harus berupa angka.";
                return false;
            }

            if (stok < 0)
            {
                error = "Stok tidak boleh negatif.";
                return false;
            }

            // Foto: wajib upload, file harus exist, ekstensi valid
            if (string.IsNullOrEmpty(selectedPhotoPath))
            {
                error = "Foto buku wajib di-upload.";
                return false;
            }

            if (!File.Exists(selectedPhotoPath))
            {
                error = "File foto tidak ditemukan di path yang dipilih.";
                return false;
            }

            string ext = Path.GetExtension(selectedPhotoPath)?.ToLowerInvariant();
            if (ext != ".jpg" && ext != ".jpeg" && ext != ".png")
            {
                error = "Format foto hanya boleh jpg, jpeg, atau png.";
                return false;
            }

            return true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateBookInputs(out string vk))
            {
                MessageBox.Show(vk, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int stok = int.Parse(txt_stok.Text.Trim());
            try
            {
                bukuController.InsertBook(txt_judulbuku.Text.Trim(), txt_penulis.Text.Trim(), txt_kategori.Text.Trim(), stok, selectedPhotoPath);
                MessageBox.Show("Buku berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan buku: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Pilih buku terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateBookInputs(out string vk))
            {
                MessageBox.Show(vk, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int stok = int.Parse(txt_stok.Text.Trim());
            try
            {
                bukuController.UpdateBook(selectedId, txt_judulbuku.Text.Trim(), txt_penulis.Text.Trim(), txt_kategori.Text.Trim(), stok, selectedPhotoPath);
                MessageBox.Show("Data buku berhasil diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate buku: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Pilih buku terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (bukuController.IsBookBorrowed(selectedId))
                {
                    MessageBox.Show("Buku sedang dipinjam, tidak bisa dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show("Yakin ingin menghapus buku ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                bukuController.DeleteBook(selectedId);
                MessageBox.Show("Buku berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus buku: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_upload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png", Title = "Pilih Foto Buku" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedPhotoPath = ofd.FileName;
                pictureBox_buku.ImageLocation = selectedPhotoPath;
                pictureBox_buku.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ClearForm()
        {
            txt_idbuku.Clear();
            txt_judulbuku.Clear();
            txt_penulis.Clear();
            txt_kategori.Clear();
            txt_stok.Clear();
            pictureBox_buku.Image = null;
            selectedPhotoPath = null;
            selectedId = 0;
            dgv_databuku.ClearSelection();
        }

        // navigation handlers already present in designer; keep stubs
        private void btn_datauser_Click(object sender, EventArgs e)
        {
            new Data_Usser().Show();
            this.Hide();
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            new LaporanAdmin().Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btn_databuku_Click(object sender, EventArgs e)
        {
            // already here
        }

        private void pnl_data2_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}
