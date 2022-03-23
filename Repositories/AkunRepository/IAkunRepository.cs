using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Models;

namespace uas.Repositories.AkunRepository
{
    public interface IAkunRepository
    {
        Task<bool> DaftarUserAsync(User datanya);

        // USER
        Task<List<User>> AmbilSemuaUserAsync();
        Task<User> AmbilUserByUsernameAsync(string usernamenya);

        // ROLES
        Task<List<Roles>> AmbilSemuaRolesAsync();
        Task<Roles> AmbilRolesByIdAsync(string id);
    }
}
