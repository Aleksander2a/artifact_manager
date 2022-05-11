using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using manager_artefaktow.Data.Models;
//using manager_artefaktow.Data.Users;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace manager_artefaktow.Data
{
    public class ManagerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermition> RolePermitions { get; set; }
        public DbSet<Permition> Permitions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=ArtifactManagerDatabase;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>().HasKey(vf => new { vf.UserId, vf.RoleId });
            modelBuilder.Entity<RolePermition>().HasKey(vf => new { vf.RoleId, vf.PermitionId });
        }
    }
}
