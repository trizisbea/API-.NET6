using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Consultorio.Migrations
{
    public partial class att10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfissionaisEspecialidades");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfissionaisEspecialidades",
                columns: table => new
                {
                    id_prof_especialidade = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_especialidade = table.Column<int>(type: "integer", nullable: false),
                    id_profissional = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfissionaisEspecialidades", x => x.id_prof_especialidade);
                    table.ForeignKey(
                        name: "FK_ProfissionaisEspecialidades_Especialidades_id_especialidade",
                        column: x => x.id_especialidade,
                        principalTable: "Especialidades",
                        principalColumn: "id_especialidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfissionaisEspecialidades_Profissionais_id_profissional",
                        column: x => x.id_profissional,
                        principalTable: "Profissionais",
                        principalColumn: "id_profissional",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfissionaisEspecialidades_id_especialidade",
                table: "ProfissionaisEspecialidades",
                column: "id_especialidade");

            migrationBuilder.CreateIndex(
                name: "IX_ProfissionaisEspecialidades_id_profissional",
                table: "ProfissionaisEspecialidades",
                column: "id_profissional");
        }
    }
}
