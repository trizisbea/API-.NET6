using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultorio.Migrations
{
    public partial class att4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Especialidades_id_especialidade",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfissionaisEspecialidades_Especialidades_EspecialidadeId",
                table: "ProfissionaisEspecialidades");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfissionaisEspecialidades_Profissionais_ProfissionaisIdPr~",
                table: "ProfissionaisEspecialidades");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_id_especialidade",
                table: "Consultas");

            migrationBuilder.RenameColumn(
                name: "EspecialidadeId",
                table: "ProfissionaisEspecialidades",
                newName: "id_especialidade");

            migrationBuilder.RenameColumn(
                name: "ProfissionaisIdProfissional",
                table: "ProfissionaisEspecialidades",
                newName: "id_profissional");

            migrationBuilder.RenameColumn(
                name: "IdEspecialidade",
                table: "ProfissionaisEspecialidades",
                newName: "id_prof_especialidade");

            migrationBuilder.RenameIndex(
                name: "IX_ProfissionaisEspecialidades_ProfissionaisIdProfissional",
                table: "ProfissionaisEspecialidades",
                newName: "IX_ProfissionaisEspecialidades_id_profissional");

            migrationBuilder.RenameIndex(
                name: "IX_ProfissionaisEspecialidades_EspecialidadeId",
                table: "ProfissionaisEspecialidades",
                newName: "IX_ProfissionaisEspecialidades_id_especialidade");

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
                name: "FK_ProfissionaisEspecialidades_Especialidades_id_especialidade",
                table: "ProfissionaisEspecialidades",
                column: "id_especialidade",
                principalTable: "Especialidades",
                principalColumn: "id_especialidade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfissionaisEspecialidades_Profissionais_id_profissional",
                table: "ProfissionaisEspecialidades",
                column: "id_profissional",
                principalTable: "Profissionais",
                principalColumn: "id_profissional",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Especialidades_EspecialidadeIdEspecialidade",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Especialidades_EspecialidadeIdEspecialidade1",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfissionaisEspecialidades_Especialidades_id_especialidade",
                table: "ProfissionaisEspecialidades");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfissionaisEspecialidades_Profissionais_id_profissional",
                table: "ProfissionaisEspecialidades");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_EspecialidadeIdEspecialidade",
                table: "Consultas");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_EspecialidadeIdEspecialidade1",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "EspecialidadeIdEspecialidade",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "EspecialidadeIdEspecialidade1",
                table: "Consultas");

            migrationBuilder.RenameColumn(
                name: "id_especialidade",
                table: "ProfissionaisEspecialidades",
                newName: "EspecialidadeId");

            migrationBuilder.RenameColumn(
                name: "id_profissional",
                table: "ProfissionaisEspecialidades",
                newName: "ProfissionaisIdProfissional");

            migrationBuilder.RenameColumn(
                name: "id_prof_especialidade",
                table: "ProfissionaisEspecialidades",
                newName: "IdEspecialidade");

            migrationBuilder.RenameIndex(
                name: "IX_ProfissionaisEspecialidades_id_profissional",
                table: "ProfissionaisEspecialidades",
                newName: "IX_ProfissionaisEspecialidades_ProfissionaisIdProfissional");

            migrationBuilder.RenameIndex(
                name: "IX_ProfissionaisEspecialidades_id_especialidade",
                table: "ProfissionaisEspecialidades",
                newName: "IX_ProfissionaisEspecialidades_EspecialidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_id_especialidade",
                table: "Consultas",
                column: "id_especialidade");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Especialidades_id_especialidade",
                table: "Consultas",
                column: "id_especialidade",
                principalTable: "Especialidades",
                principalColumn: "id_especialidade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfissionaisEspecialidades_Especialidades_EspecialidadeId",
                table: "ProfissionaisEspecialidades",
                column: "EspecialidadeId",
                principalTable: "Especialidades",
                principalColumn: "id_especialidade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfissionaisEspecialidades_Profissionais_ProfissionaisIdPr~",
                table: "ProfissionaisEspecialidades",
                column: "ProfissionaisIdProfissional",
                principalTable: "Profissionais",
                principalColumn: "id_profissional",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
