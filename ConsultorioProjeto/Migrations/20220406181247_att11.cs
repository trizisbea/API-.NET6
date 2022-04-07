using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Consultorio.Migrations
{
    public partial class att11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Profissionais_id_profissional",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_EspecialidadeProfissional_Profissionais_ProfissionaisIdProf~",
                table: "EspecialidadeProfissional");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profissionais",
                table: "Profissionais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "id_profissional",
                table: "Profissionais");

            migrationBuilder.DropColumn(
                name: "id_consulta",
                table: "Consultas");

            migrationBuilder.RenameColumn(
                name: "ProfissionaisIdProfissional",
                table: "EspecialidadeProfissional",
                newName: "ProfissionaisId");

            migrationBuilder.RenameIndex(
                name: "IX_EspecialidadeProfissional_ProfissionaisIdProfissional",
                table: "EspecialidadeProfissional",
                newName: "IX_EspecialidadeProfissional_ProfissionaisId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Profissionais",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Consultas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profissionais",
                table: "Profissionais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Profissionais_id_profissional",
                table: "Consultas",
                column: "id_profissional",
                principalTable: "Profissionais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EspecialidadeProfissional_Profissionais_ProfissionaisId",
                table: "EspecialidadeProfissional",
                column: "ProfissionaisId",
                principalTable: "Profissionais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Profissionais_id_profissional",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_EspecialidadeProfissional_Profissionais_ProfissionaisId",
                table: "EspecialidadeProfissional");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profissionais",
                table: "Profissionais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas");

            migrationBuilder.RenameColumn(
                name: "ProfissionaisId",
                table: "EspecialidadeProfissional",
                newName: "ProfissionaisIdProfissional");

            migrationBuilder.RenameIndex(
                name: "IX_EspecialidadeProfissional_ProfissionaisId",
                table: "EspecialidadeProfissional",
                newName: "IX_EspecialidadeProfissional_ProfissionaisIdProfissional");

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

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Consultas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "id_consulta",
                table: "Consultas",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profissionais",
                table: "Profissionais",
                column: "id_profissional");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas",
                column: "id_consulta");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Profissionais_id_profissional",
                table: "Consultas",
                column: "id_profissional",
                principalTable: "Profissionais",
                principalColumn: "id_profissional",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EspecialidadeProfissional_Profissionais_ProfissionaisIdProf~",
                table: "EspecialidadeProfissional",
                column: "ProfissionaisIdProfissional",
                principalTable: "Profissionais",
                principalColumn: "id_profissional",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
