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
                    Description = table.Column<string>(nullable: false)
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
                    Password = table.Column<string>(nullable: false),
                    RoleName = table.Column<string>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryName = table.Column<string>(nullable: false),
                    CreatorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryName);
                    table.ForeignKey(
                        name: "FK_Categories_Users_CreatorName",
                        column: x => x.CreatorName,
                        principalTable: "Users",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProperties",
                columns: table => new
                {
                    PropertyName = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProperties", x => new { x.PropertyName, x.CategoryName });
                    table.ForeignKey(
                        name: "FK_CategoryProperties_Categories_CategoryName",
                        column: x => x.CategoryName,
                        principalTable: "Categories",
                        principalColumn: "CategoryName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instances",
                columns: table => new
                {
                    InstanceName = table.Column<string>(nullable: false),
                    Overall = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: false),
                    CreatorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instances", x => x.InstanceName);
                    table.ForeignKey(
                        name: "FK_Instances_Categories_CategoryName",
                        column: x => x.CategoryName,
                        principalTable: "Categories",
                        principalColumn: "CategoryName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instances_Users_CreatorName",
                        column: x => x.CreatorName,
                        principalTable: "Users",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "InstanceProperties",
                columns: table => new
                {
                    PropertyValue = table.Column<string>(nullable: false),
                    PropertyName = table.Column<string>(nullable: false),
                    InstanceName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstanceProperties", x => new { x.PropertyValue, x.PropertyName, x.InstanceName });
                    table.ForeignKey(
                        name: "FK_InstanceProperties_Instances_InstanceName",
                        column: x => x.InstanceName,
                        principalTable: "Instances",
                        principalColumn: "InstanceName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatorName",
                table: "Categories",
                column: "CreatorName");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProperties_CategoryName",
                table: "CategoryProperties",
                column: "CategoryName");

            migrationBuilder.CreateIndex(
                name: "IX_InstanceProperties_InstanceName",
                table: "InstanceProperties",
                column: "InstanceName");

            migrationBuilder.CreateIndex(
                name: "IX_Instances_CategoryName",
                table: "Instances",
                column: "CategoryName");

            migrationBuilder.CreateIndex(
                name: "IX_Instances_CreatorName",
                table: "Instances",
                column: "CreatorName");

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
                name: "CategoryProperties");

            migrationBuilder.DropTable(
                name: "InstanceProperties");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Instances");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
