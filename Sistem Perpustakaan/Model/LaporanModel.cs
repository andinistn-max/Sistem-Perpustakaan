using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Perpustakaan.Model
{
    internal class LaporanModel
    {
        public int TotalPeminjaman { get; set; }
        public int BukuDipinjam { get; set; }
        public int TotalDenda { get; set; }
    }
}
