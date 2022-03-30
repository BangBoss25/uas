using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Models;
using uas.Repositories.Repository;

namespace uas.Services.Service
{
    public class StuffService : IStuffService
    {
        private readonly IStuffRepository _repo;
        private readonly FileService _file;
        public StuffService(IStuffRepository r, FileService f)
        {
            _repo = r;
            _file = f;
        }

        public List<Stuff> AmbilSemuaBarang()
        {
            return _repo.AmbilSemuaBarang().Result;
        }

        public bool BuatBarangNew(Stuff data, IFormFile Image)
        {
            data.Gambar = _file.SaveFile(Image).Result;
            data.Terjual = 0;

            return _repo.BuatBarangBaruAsync(data).Result;
        }
    }
}
