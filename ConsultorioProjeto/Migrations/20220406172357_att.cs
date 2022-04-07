using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Consultorio.Migrations
{
    public partial class att : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Profissionais_id_profissional",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Especialidades_Profissionais_ProfissionalId",
                table: "Especialidades");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfissionaisEspecialidades_Profissionais_ProfissionaisId",
                table: "ProfissionaisEspecialidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profissionais",
                table: "Profissionais");

            migrationBuilder.RenameColumn(
                name: "ProfissionaisId",
                table: "ProfissionaisEspecialidades",
                newName: "ProfissionaisIdProfissional");

            migrationBuilder.RenameIndex(
                name: "IX_ProfissionaisEspecialidades_ProfissionaisId",
                table: "ProfissionaisEspecialidades",
                newName: "IX_ProfissionaisEspecialidades_ProfissionaisIdProfissional");

            migrationBuilder.RenameColumn(
                name: "ProfissionalId",
                table: "Especialidades",
                newName: "ProfissionalIdProfissional");

            migrationBuilder.RenameIndex(
                name: "IX_Especialidades_ProfissionalId",
                table: "Especialidades",
                newName: "IX_Especialidades_ProfissionalIdProfissional");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Profissionais",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "id_profissional",
                table: "Profissionais",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profissionais",
                table: "Profissionais",
                column: "id_profissional");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Profissionais_id_profissional",
                table: "Consultas",
                column: "id_profissional",
                principalTable: "Profissionais",
                principalColumn: "id_profissional",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidades_Profissionais_ProfissionalIdProfissional",
                table: "Especialidades",
                column: "ProfissionalIdProfissional",
                principalTable: "Profissionais",
                principalColumn: "id_profissional");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfissionaisEspecialidades_Profissionais_ProfissionaisIdPr~",
                table: "ProfissionaisEspecialidades",
                column: "ProfissionaisIdProfissional",
                principalTable: "Profissionais",
                principalColumn: "id_profissional",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Profissionais_id_profissional",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Especialidades_Profissionais_ProfissionalIdProfissional",
                table: "Especialidades");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfissionaisEspecialidades_Profissionais_ProfissionaisIdPr~",
                table: "ProfissionaisEspecialidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profissionais",
                table: "Profissionais");

            migrationBuilder.DropColumn(
                name: "id_profissional",
                table: "Profissionais");

            migrationBuilder.RenameColumn(
                name: "ProfissionaisIdProfissional",
                table: "ProfissionaisEspecialidades",
                newName: "ProfissionaisId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfissionaisEspecialidades_ProfissionaisIdProfissional",
                table: "ProfissionaisEspecialidades",
                newName: "IX_ProfissionaisEspecialidades_ProfissionaisId");

            migrationBuilder.RenameColumn(
                name: "ProfissionalIdProfissional",
                table: "Especialidades",
                newName: "ProfissionalId");

            migrationBuilder.RenameIndex(
                name: "IX_Especialidades_ProfissionalIdProfissional",
                table: "Especialidades",
                newName: "IX_Especialidades_ProfissionalId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Profissionais",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profissionais",
                table: "Profissionais",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Profissionais_id_profissional",
                table: "Consultas",
                column: "id_profissional",
                principalTable: "Profissionais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidades_Profissionais_ProfissionalId",
                table: "Especialidades",
                column: "ProfissionalId",
                principalTable: "Profissionais",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfissionaisEspecialidades_Profissionais_ProfissionaisId",
                table: "ProfissionaisEspecialidades",
                column: "ProfissionaisId",
                principalTable: "Profissionais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
