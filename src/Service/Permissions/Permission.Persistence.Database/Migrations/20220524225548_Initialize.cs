using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Permission.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Permissions");

            migrationBuilder.CreateTable(
                name: "TipoPermiso",
                schema: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPermiso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                schema: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(maxLength: 100, nullable: false),
                    ApellidoEmpleado = table.Column<string>(maxLength: 100, nullable: false),
                    TipoPermisoId = table.Column<int>(nullable: true),
                    FechaPermiso = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permisos_TipoPermiso_TipoPermisoId",
                        column: x => x.TipoPermisoId,
                        principalSchema: "Permissions",
                        principalTable: "TipoPermiso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_Id",
                schema: "Permissions",
                table: "Permisos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_TipoPermisoId",
                schema: "Permissions",
                table: "Permisos",
                column: "TipoPermisoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permisos",
                schema: "Permissions");

            migrationBuilder.DropTable(
                name: "TipoPermiso",
                schema: "Permissions");
        }
    }
}
