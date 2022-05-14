﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using manager_artefaktow.Data;

namespace manager_artefaktow.Migrations
{
    [DbContext(typeof(ManagerContext))]
    partial class ManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("manager_artefaktow.Data.Models.Permission", b =>
                {
                    b.Property<string>("PermissionName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermissionName");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("manager_artefaktow.Data.Models.Role", b =>
                {
                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RoleName");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("manager_artefaktow.Data.Models.RolePermission", b =>
                {
                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PermissionName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RoleName", "PermissionName");

                    b.HasIndex("PermissionName");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("manager_artefaktow.Data.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserName");

                    b.HasIndex("RoleName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("manager_artefaktow.Data.Models.RolePermission", b =>
                {
                    b.HasOne("manager_artefaktow.Data.Models.Permission", "Permission")
                        .WithMany("Roles")
                        .HasForeignKey("PermissionName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("manager_artefaktow.Data.Models.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("manager_artefaktow.Data.Models.User", b =>
                {
                    b.HasOne("manager_artefaktow.Data.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleName")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
