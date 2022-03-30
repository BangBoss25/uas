using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Data;
using uas.Models;

namespace uas.Repositories.Repository
{
    public class StuffRepository : IStuffRepository
    {
        private readonly AppDbContext _context;
        public StuffRepository(AppDbContext db)
        {
            _context = db;
        }
        public async Task<List<Stuff>> AmbilSemuaBarang()
        {
            return await _context.Tb_Barang.ToListAsync(); 
        }

        public async Task<bool> BuatBarangBaruAsync(Stuff baru)
        {
            _context.Add(baru);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
