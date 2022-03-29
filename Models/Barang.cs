using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uas.Models
{
    public class Barang
    {
        public int Id { get; set; }
        public string NamaBarang { get; set; }
        public string Gambar { get; set; }
        public int Stok { get; set; }
        public int Harga { get; set; }
        public int Terjual { get; set; }
        public string Deskripsi { get; set; }
    }
}
