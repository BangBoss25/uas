using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Models;

namespace uas.Repositories.Barang_Repository
{
    public interface IBarangRepository
    {
        Task<List<Barang>> AmbilSemuaBarangAsync();
        Task<bool> BuatBarangAsync(Barang Data);
    }
}
