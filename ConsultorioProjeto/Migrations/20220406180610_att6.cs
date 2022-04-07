using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultorio.Migrations
{
    public partial class att6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Especialidades_EspecialidadeIdEspecialidade",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Especialidades_EspecialidadeIdEspecialidade1",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Especialidades_Profissionais_ProfissionalIdProfissional",
                table: "Especialidades");

            migrationBuilder.DropIndex(
                name: "IX_Especialidades_ProfissionalIdProfissional",
                table: "Especialidades");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_EspecialidadeIdEspecialidade",
                table: "Consultas");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_EspecialidadeIdEspecialidade1",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "ProfissionalIdProfissional",
                table: "Especialidades");

            migrationBuilder.DropColumn(
                name: "EspecialidadeIdEspecialidade",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "EspecialidadeIdEspecialidade1",
                table: "Consultas");

            migrationBuilder.CreateTable(
                name: "EspecialidadeProfissional",
                columns: table => new
                {
                    EspecialidadesIdEspecialidade = table.Column<int>(type: "integer", nullable: false),
                    ProfissionaisIdProfissional = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadeProfissional", x => new { x.EspecialidadesIdEspecialidade, x.ProfissionaisIdProfissional });
                    table.ForeignKey(
                        name: "FK_EspecialidadeProfissional_Especialidades_EspecialidadesIdEs~",
                        column: x => x.EspecialidadesIdEspecialidade,
                        principalTable: "Especialidades",
                        principalColumn: "id_especialidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EspecialidadeProfissional_Profissionais_ProfissionaisIdProf~",
                        column: x => x.ProfissionaisIdProfissional,
                        principalTable: "Profissionais",
                        principalColumn: "id_profissional",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_id_especialidade",
                table: "Consultas",
                column: "id_especialidade");

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadeProfissional_ProfissionaisIdProfissional",
                table: "EspecialidadeProfissional",
                column: "ProfissionaisIdProfissional");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Especialidades_id_especialidade",
                table: "Consultas",
                column: "id_especialidade",
                principalTable: "Especialidades",
                principalColumn: "id_especialidade",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Especialidades_id_especialidade",
                table: "Consultas");

            migrationBuilder.DropTable(
                name: "EspecialidadeProfissional");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_id_especialidade",
                table: "Consultas");

            migrationBuilder.AddColumn<int>(
                name: "ProfissionalIdProfissional",
                table: "Especialidades",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EspecialidadeIdEspecialidade",
                table: "Consultas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EspecialidadeIdEspecialidade1",
                table: "Consultas",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Especialidades_ProfissionalIdProfissional",
                table: "Especialidades",
                column: "ProfissionalIdProfissional");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_EspecialidadeIdEspecialidade",
                table: "Consultas",
                column: "EspecialidadeIdEspecialidade");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_EspecialidadeIdEspecialidade1",
                table: "Consultas",
                column: "EspecialidadeIdEspecialidade1");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Especialidades_EspecialidadeIdEspecialidade",
                table: "Consultas",
                column: "EspecialidadeIdEspecialidade",
                principalTable: "Especialidades",
                principalColumn: "id_especialidade");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Especialidades_EspecialidadeIdEspecialidade1",
                table: "Consultas",
                column: "EspecialidadeIdEspecialidade1",
                principalTable: "Especialidades",
                principalColumn: "id_especialidade");

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidades_Profissionais_ProfissionalIdProfissional",
                table: "Especialidades",
                column: "ProfissionalIdProfissional",
                principalTable: "Profissionais",
                principalColumn: "id_profissional");
        }
    }
}
