using Microsoft.EntityFrameworkCore;
using uas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }
        public virtual DbSet<Roles> Tb_Roles { get; set; }
        public virtual DbSet<User> Tb_User { get; set; }
        public virtual DbSet<Stuff> Tb_Barang { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Roles>().HasData(new Roles[]
            {
                new Roles
                {
                    Id = "1",
                    Name = "Admin"
                },
                new Roles
                {
                    Id = "2",
                    Name = "User"
                }
            });
        }
    }
}
