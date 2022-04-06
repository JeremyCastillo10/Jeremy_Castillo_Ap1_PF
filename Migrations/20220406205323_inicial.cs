using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeremy_Castillo_Ap1_PF.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expedientes",
                columns: table => new
                {
                    ExpedienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expedientes", x => x.ExpedienteId);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalidades",
                columns: table => new
                {
                    NacionalidadId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalidades", x => x.NacionalidadId);
                });

            migrationBuilder.CreateTable(
                name: "TiposDocumentos",
                columns: table => new
                {
                    TipoDocumentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    VecesAsignado = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumentos", x => x.TipoDocumentoId);
                });

            migrationBuilder.CreateTable(
                name: "ExpedientesDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExpedienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TiposDocumentosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpedientesDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpedientesDetalle_Expedientes_ExpedienteId",
                        column: x => x.ExpedienteId,
                        principalTable: "Expedientes",
                        principalColumn: "ExpedienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Sexo = table.Column<char>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    NacionalidadId = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudianteId);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Nacionalidades_NacionalidadId",
                        column: x => x.NacionalidadId,
                        principalTable: "Nacionalidades",
                        principalColumn: "NacionalidadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion" },
                values: new object[] { 1, "Argentina" });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion" },
                values: new object[] { 2, "Bolivia" });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion" },
                values: new object[] { 3, "Colombia" });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion" },
                values: new object[] { 4, "Dominica" });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion" },
                values: new object[] { 5, "Ecuador" });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion" },
                values: new object[] { 6, "España" });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion" },
                values: new object[] { 7, "Haiti" });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion" },
                values: new object[] { 8, "Republica Dominicana" });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion" },
                values: new object[] { 9, "Rusia" });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion" },
                values: new object[] { 10, "Venezuela" });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_NacionalidadId",
                table: "Estudiantes",
                column: "NacionalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpedientesDetalle_ExpedienteId",
                table: "ExpedientesDetalle",
                column: "ExpedienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "ExpedientesDetalle");

            migrationBuilder.DropTable(
                name: "TiposDocumentos");

            migrationBuilder.DropTable(
                name: "Nacionalidades");

            migrationBuilder.DropTable(
                name: "Expedientes");
        }
    }
}
