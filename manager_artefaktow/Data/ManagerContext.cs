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
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Instance> Instances { get; set; }


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
            modelBuilder.Entity<User>().HasKey(u => new { u.UserName });
            modelBuilder.Entity<Role>().HasKey(r => new { r.RoleName });
            modelBuilder.Entity<Permission>().HasKey(p => new { p.PermissionName });
            modelBuilder.Entity<RolePermission>().HasKey(rp => new { rp.RoleName, rp.PermissionName });
            modelBuilder.Entity<Category>().HasKey(c => new { c.CategoryName });
            modelBuilder.Entity<Instance>().HasKey(i => new { i.InstanceName });


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

            modelBuilder.Entity<Category>()
                .Property(c => c.CreatorName)
                .IsRequired();

            modelBuilder.Entity<Instance>()
                .Property(i => i.CategoryName)
                .IsRequired();
            modelBuilder.Entity<Instance>()
                .Property(i => i.CreatorName)
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

            modelBuilder.Entity<User>()
                .HasMany<Category>(u => u.Categories)
                .WithOne(c => c.Creator)
                .HasForeignKey(c => c.CreatorName)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
                .HasMany<Instance>(u => u.Instances)
                .WithOne(i => i.Creator)
                .HasForeignKey(i => i.CreatorName)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
                .HasMany<Instance>(c => c.Instances)
                .WithOne(i => i.Category)
                .HasForeignKey(i => i.CategoryName)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
