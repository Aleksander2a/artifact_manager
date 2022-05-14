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
        //public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Permission> Permissions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=ArtifactManagerDatabase;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define Primary Keys
            modelBuilder.Entity<User>().HasKey(vf => new { vf.UserName });
            modelBuilder.Entity<Role>().HasKey(vf => new { vf.RoleName });
            modelBuilder.Entity<Permission>().HasKey(vf => new { vf.PermissionName });
            modelBuilder.Entity<RolePermission>().HasKey(vf => new { vf.RoleName, vf.PermissionName });


            // Define constraints on fields
            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(u => u.RoleName)
                .IsRequired();

            modelBuilder.Entity<Permission>()
                .Property(p => p.Description)
                .IsRequired();


            // Define relations between tables
            modelBuilder.Entity<Role>()
                .HasMany<User>(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleName)
                .OnDelete(DeleteBehavior.Cascade);
           

            modelBuilder.Entity<RolePermission>()
                .HasOne<Role>(rp => rp.Role)
                .WithMany(r => r.Permissions)
                .HasForeignKey(rp => rp.RoleName);

            modelBuilder.Entity<RolePermission>()
                .HasOne<Permission>(rp => rp.Permission)
                .WithMany(p => p.Roles)
                .HasForeignKey(rp => rp.PermissionName);

        }
    }
}
