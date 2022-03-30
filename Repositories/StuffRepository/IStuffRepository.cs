using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Models;

namespace uas.Repositories.Repository
{
    public interface IStuffRepository
    {
        Task<List<Stuff>> AmbilSemuaBarang();
        Task<bool> BuatBarangBaruAsync(Stuff baru);
    }
}
