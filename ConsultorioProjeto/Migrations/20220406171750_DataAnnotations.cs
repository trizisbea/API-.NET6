using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Consultorio.Migrations
{
    public partial class DataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    id_paciente = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    celular = table.Column<string>(type: "text", nullable: false),
                    cpf = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.id_paciente);
                });

            migrationBuilder.CreateTable(
                name: "Profissionais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    ativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissionais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    id_especialidade = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    ativa = table.Column<bool>(type: "boolean", nullable: false),
                    ProfissionalId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.id_especialidade);
                    table.ForeignKey(
                        name: "FK_Especialidades_Profissionais_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "Profissionais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    id_consulta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data_horario = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    preco = table.Column<decimal>(type: "numeric", nullable: false),
                    id_paciente = table.Column<int>(type: "integer", nullable: false),
                    id_especialidade = table.Column<int>(type: "integer", nullable: false),
                    id_profissional = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.id_consulta);
                    table.ForeignKey(
                        name: "FK_Consultas_Especialidades_id_especialidade",
                        column: x => x.id_especialidade,
                        principalTable: "Especialidades",
                        principalColumn: "id_especialidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Pacientes_id_paciente",
                        column: x => x.id_paciente,
                        principalTable: "Pacientes",
                        principalColumn: "id_paciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Profissionais_id_profissional",
                        column: x => x.id_profissional,
                        principalTable: "Profissionais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfissionaisEspecialidades",
                columns: table => new
                {
                    IdEspecialidade = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProfissionaisId = table.Column<int>(type: "integer", nullable: false),
                    EspecialidadeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfissionaisEspecialidades", x => x.IdEspecialidade);
                    table.ForeignKey(
                        name: "FK_ProfissionaisEspecialidades_Especialidades_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "Especialidades",
                        principalColumn: "id_especialidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfissionaisEspecialidades_Profissionais_ProfissionaisId",
                        column: x => x.ProfissionaisId,
                        principalTable: "Profissionais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_id_especialidade",
                table: "Consultas",
                column: "id_especialidade");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_id_paciente",
                table: "Consultas",
                column: "id_paciente");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_id_profissional",
                table: "Consultas",
                column: "id_profissional");

            migrationBuilder.CreateIndex(
                name: "IX_Especialidades_ProfissionalId",
                table: "Especialidades",
                column: "ProfissionalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfissionaisEspecialidades_EspecialidadeId",
                table: "ProfissionaisEspecialidades",
                column: "EspecialidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfissionaisEspecialidades_ProfissionaisId",
                table: "ProfissionaisEspecialidades",
                column: "ProfissionaisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "ProfissionaisEspecialidades");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Profissionais");
        }
    }
}
