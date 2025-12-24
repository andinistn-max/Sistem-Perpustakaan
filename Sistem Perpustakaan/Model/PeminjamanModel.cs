namespace Sistem_Perpustakaan.Model
{
    internal class PeminjamanModel
    {
        public int IdBorrow { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }  
        public string Title { get; set; }
        public string BorrowDate { get; set; }
        public string DueDate { get; set; }
        public string ReturnDate { get; set; }
        public string Status { get; set; }
        public int Fine { get; set; }
    }
}
