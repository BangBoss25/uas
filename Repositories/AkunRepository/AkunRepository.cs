using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Data;
using uas.Models;

namespace uas.Repositories.AkunRepository
{
    public class AkunRepository : IAkunRepository
    {
        private readonly AppDbContext _db;
        public AkunRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<bool> DaftarUserAsync(User datanya)
        {
            _db.Tb_User.Add(datanya);
            await _db.SaveChangesAsync();

            return true;
        }


        // ----------------------------------------------------------------------------
        // ------------------------------- USER ---------------------------------------
        // ----------------------------------------------------------------------------

        public async Task<List<User>> AmbilSemuaUserAsync()
        {
            return await _db.Tb_User.Include(x => x.Roles).ToListAsync();
        }

        public async Task<User> AmbilUserByUsernameAsync(string usernamenya)
        {
            return await _db.Tb_User.FindAsync(usernamenya);
        }

        // ----------------------------------------------------------------------------
        // ------------------------------- ROLES --------------------------------------
        // ----------------------------------------------------------------------------

        public async Task<List<Roles>> AmbilSemuaRolesAsync()
        {
            return await _db.Tb_Roles.ToListAsync();
        }

        public async Task<Roles> AmbilRolesByIdAsync(string idnya)
        {
            return await _db.Tb_Roles.FindAsync(idnya);
        }
    }
}
