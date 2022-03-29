using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Models;

namespace uas.Services.BarangService
{
    public interface IBarangService
    {
        List<Barang> AmbilSemuaBarang();
        bool BuatBarang(Barang data, IFormFile Image);

    }
}
