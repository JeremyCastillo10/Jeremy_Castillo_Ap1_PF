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
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    NacionalidadId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudianteId);
                });

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
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    EstudiantesEstudianteId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalidades", x => x.NacionalidadId);
                    table.ForeignKey(
                        name: "FK_Nacionalidades_Estudiantes_EstudiantesEstudianteId",
                        column: x => x.EstudiantesEstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "EstudianteId");
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
                name: "TiposDocumentos",
                columns: table => new
                {
                    TipoDocumentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    VecesAsignado = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpedientesDetalleId = table.Column<int>(type: "INTEGER", nullable: true),
                    ExpedientesExpedienteId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumentos", x => x.TipoDocumentoId);
                    table.ForeignKey(
                        name: "FK_TiposDocumentos_Expedientes_ExpedientesExpedienteId",
                        column: x => x.ExpedientesExpedienteId,
                        principalTable: "Expedientes",
                        principalColumn: "ExpedienteId");
                    table.ForeignKey(
                        name: "FK_TiposDocumentos_ExpedientesDetalle_ExpedientesDetalleId",
                        column: x => x.ExpedientesDetalleId,
                        principalTable: "ExpedientesDetalle",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion", "EstudiantesEstudianteId" },
                values: new object[] { 1, "Argentina", null });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion", "EstudiantesEstudianteId" },
                values: new object[] { 2, "Bolivia", null });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion", "EstudiantesEstudianteId" },
                values: new object[] { 3, "Colombia", null });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion", "EstudiantesEstudianteId" },
                values: new object[] { 4, "Dominica", null });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion", "EstudiantesEstudianteId" },
                values: new object[] { 5, "Ecuador", null });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion", "EstudiantesEstudianteId" },
                values: new object[] { 6, "España", null });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion", "EstudiantesEstudianteId" },
                values: new object[] { 7, "Haiti", null });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion", "EstudiantesEstudianteId" },
                values: new object[] { 8, "Republica Dominicana", null });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion", "EstudiantesEstudianteId" },
                values: new object[] { 9, "Rusia", null });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Descripcion", "EstudiantesEstudianteId" },
                values: new object[] { 10, "Venezuela", null });

            migrationBuilder.CreateIndex(
                name: "IX_ExpedientesDetalle_ExpedienteId",
                table: "ExpedientesDetalle",
                column: "ExpedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Nacionalidades_EstudiantesEstudianteId",
                table: "Nacionalidades",
                column: "EstudiantesEstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposDocumentos_ExpedientesDetalleId",
                table: "TiposDocumentos",
                column: "ExpedientesDetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposDocumentos_ExpedientesExpedienteId",
                table: "TiposDocumentos",
                column: "ExpedientesExpedienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nacionalidades");

            migrationBuilder.DropTable(
                name: "TiposDocumentos");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "ExpedientesDetalle");

            migrationBuilder.DropTable(
                name: "Expedientes");
        }
    }
}
