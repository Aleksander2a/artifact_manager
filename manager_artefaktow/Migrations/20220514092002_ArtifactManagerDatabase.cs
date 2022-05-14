using Microsoft.EntityFrameworkCore.Migrations;

namespace manager_artefaktow.Migrations
{
    public partial class ArtifactManagerDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionName);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleName);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    RoleName = table.Column<string>(nullable: false),
                    PermissionName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.RoleName, x.PermissionName });
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionName",
                        column: x => x.PermissionName,
                        principalTable: "Permissions",
                        principalColumn: "PermissionName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleName",
                        column: x => x.RoleName,
                        principalTable: "Roles",
                        principalColumn: "RoleName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleName",
                        column: x => x.RoleName,
                        principalTable: "Roles",
                        principalColumn: "RoleName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionName",
                table: "RolePermissions",
                column: "PermissionName");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleName",
                table: "Users",
                column: "RoleName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
