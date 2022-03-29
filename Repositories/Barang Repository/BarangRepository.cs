using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Data;
using uas.Models;

namespace uas.Repositories.Barang_Repository
{
    public class BarangRepository : IBarangRepository
    {
        private readonly AppDbContext _db;
        public BarangRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task<List<Barang>> AmbilSemuaBarangAsync()
        {
            return await _db.Tb_Barang.ToListAsync();
        }

        public async Task<bool> BuatBarangAsync(Barang Data)
        {
            _db.Add(Data);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
