using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    public partial class INICIAL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.CargoId);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "CargoId", "Codigo", "CreatedBy", "CreatedDate", "Estado", "LastModifiedBy", "LastModifiedDate", "Nombre" },
                values: new object[,]
                {
                    { 1, "991", "System", new DateTime(2022, 11, 18, 0, 18, 18, 116, DateTimeKind.Local).AddTicks(3578), true, null, null, "Desarrollador" },
                    { 2, "992", "System", new DateTime(2022, 11, 18, 0, 18, 18, 116, DateTimeKind.Local).AddTicks(3580), true, null, null, "Lider de Proyecto" }
                });

            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "DepartamentoId", "Codigo", "CreatedBy", "CreatedDate", "Estado", "LastModifiedBy", "LastModifiedDate", "Nombre" },
                values: new object[,]
                {
                    { 1, "123", "System", new DateTime(2022, 11, 18, 0, 18, 18, 116, DateTimeKind.Local).AddTicks(3505), true, null, null, "Sistema" },
                    { 2, "124", "System", new DateTime(2022, 11, 18, 0, 18, 18, 116, DateTimeKind.Local).AddTicks(3515), true, null, null, "Talento Humano" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CargoId",
                table: "Usuario",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_DepartamentoId",
                table: "Usuario",
                column: "DepartamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Departamento");
        }
    }
}
