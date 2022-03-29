using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Models;
using uas.Repositories.Barang_Repository;

namespace uas.Services.BarangService
{
    public class BarangService : IBarangService
    {
        private readonly IBarangRepository _repo;
        private readonly FileService _file;
        
        public BarangService(IBarangRepository r, FileService f)
        {
            _repo = r;
            _file = f;
        }

        public List<Barang> AmbilSemuaBarang()
        {
            return _repo.AmbilSemuaBarangAsync().Result; 
        }

        public bool BuatBarang(Barang data, IFormFile Image)
        {
            data.Gambar = _file.SaveFile(Image).Result;

            return _repo.BuatBarangAsync(data).Result;
        }
    }
}
