using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Perpustakaan.Model
{
    internal class BookModel
        {
        public int IdBook { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public string Photo { get; set; }
    }
    
}

