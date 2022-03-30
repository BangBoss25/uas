using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Models;

namespace uas.Services.Service
{
    public interface IStuffService
    {
        List<Stuff> AmbilSemuaBarang();
        bool BuatBarangNew(Stuff data, IFormFile file);
    }
}
