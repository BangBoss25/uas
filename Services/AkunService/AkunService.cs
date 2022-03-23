using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Models;
using uas.Repositories.AkunRepository;

namespace uas.Services.AkunService
{
    public class AkunService : IAkunService
    {
        private readonly IAkunRepository _ar;

        public AkunService(IAkunRepository ar)
        {
            _ar = ar;
        }

        public bool DaftarUser(User datanya)
        {
            datanya.Roles = _ar.AmbilRolesByIdAsync("2").Result;
            return _ar.DaftarUserAsync(datanya).Result;
        }

        // User
        public List<User> AmbilSemuaUser()
        {
            return _ar.AmbilSemuaUserAsync().Result;
        }

        public User AmbilUserByUsername(string usernamenya)
        {
            return _ar.AmbilUserByUsernameAsync(usernamenya).Result;
        }

        // Roles
        public List<Roles> AmbilSemuaRoles()
        {
            return _ar.AmbilSemuaRolesAsync().Result;
        }

        public Roles AmbilRolesById(string id)
        {
            return _ar.AmbilRolesByIdAsync(id).Result;
        }
    }
}
