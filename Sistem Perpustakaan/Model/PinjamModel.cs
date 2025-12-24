using System;

namespace Sistem_Perpustakaan.Model
{
    internal class PinjamModel
    {
        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public int Qty { get; set; }

        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}

