using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Models;

namespace uas.Services.AkunService
{
    public interface IAkunService
    {
        bool DaftarUser(User datanya);

        // user
        List<User> AmbilSemuaUser();
        User AmbilUserByUsername(string usernamenya);

        // roles
        List<Roles> AmbilSemuaRoles();
        Roles AmbilRolesById(string id);
    }
}
