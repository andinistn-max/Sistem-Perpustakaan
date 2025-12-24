namespace Sistem_Perpustakaan.Model
{
    internal class Riwayat
    {
        public int IdBorrow { get; set; }
        public string Title { get; set; }
        public string BorrowDate { get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }
        public int Fine { get; set; }
    }
}
