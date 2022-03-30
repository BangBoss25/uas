using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uas.Models
{
    public class Stuff
    {
        public int Id { get; set; }
        [Required]
        public string NamaBarang { get; set; }
        [Required]
        public string Gambar { get; set; }
        [Required]
        public int Stok { get; set; }
        [Required]
        public int Harga { get; set; }
        [Required]
        public int Terjual { get; set; }
        [Required]
        public string Deskripsi { get; set; }
    }
}
