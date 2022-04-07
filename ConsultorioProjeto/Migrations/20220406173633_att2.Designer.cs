﻿// <auto-generated />
using System;
using ConsultorioProjeto.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Consultorio.Migrations
{
    [DbContext(typeof(ConsultorioContext))]
    [Migration("20220406173633_att2")]
    partial class att2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ConsultorioProjeto.Models.Entities.Consulta", b =>
                {
                    b.Property<int>("IdConsulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_consulta");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdConsulta"));

                    b.Property<DateTime>("DataHorario")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_horario");

                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("integer")
                        .HasColumnName("id_especialidade");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<int>("PacienteId")
                        .HasColumnType("integer")
                        .HasColumnName("id_paciente");

                    b.Property<decimal>("Preco")
                        .HasColumnType("numeric")
                        .HasColumnName("preco");

                    b.Property<int>("ProfissionalId")
                        .HasColumnType("integer")
                        .HasColumnName("id_profissional");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.HasKey("IdConsulta");

                    b.HasIndex("EspecialidadeId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("ProfissionalId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("ConsultorioProjeto.Models.Entities.Especialidade", b =>
                {
                    b.Property<int>("IdEspecialidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_especialidade");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdEspecialidade"));

                    b.Property<bool>("Ativa")
                        .HasColumnType("boolean")
                        .HasColumnName("ativa");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<int?>("ProfissionalIdProfissional")
                        .HasColumnType("integer");

                    b.HasKey("IdEspecialidade");

                    b.HasIndex("ProfissionalIdProfissional");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("ConsultorioProjeto.Models.Entities.Paciente", b =>
                {
                    b.Property<int>("IdPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_paciente");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdPaciente"));

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("celular");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("IdPaciente");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("ConsultorioProjeto.Models.Entities.Profissional", b =>
                {
                    b.Property<int>("IdProfissional")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_profissional");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdProfissional"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("IdProfissional");

                    b.ToTable("Profissionais");
                });

            modelBuilder.Entity("ConsultorioProjeto.Models.Entities.ProfissionalEspecialidade", b =>
                {
                    b.Property<int>("IdEspecialidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdEspecialidade"));

                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("integer");

                    b.Property<int>("ProfissionaisIdProfissional")
                        .HasColumnType("integer");

                    b.HasKey("IdEspecialidade");

                    b.HasIndex("EspecialidadeId");

                    b.HasIndex("ProfissionaisIdProfissional");

                    b.ToTable("ProfissionaisEspecialidades");
                });

            modelBuilder.Entity("ConsultorioProjeto.Models.Entities.Consulta", b =>
                {
                    b.HasOne("ConsultorioProjeto.Models.Entities.Especialidade", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsultorioProjeto.Models.Entities.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsultorioProjeto.Models.Entities.Profissional", "Profissional")
                        .WithMany("Consultas")
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidade");

                    b.Navigation("Paciente");

                    b.Navigation("Profissional");
                });

            modelBuilder.Entity("ConsultorioProjeto.Models.Entities.Especialidade", b =>
                {
                    b.HasOne("ConsultorioProjeto.Models.Entities.Profissional", null)
                        .WithMany("Especialidades")
                        .HasForeignKey("ProfissionalIdProfissional");
                });

            modelBuilder.Entity("ConsultorioProjeto.Models.Entities.ProfissionalEspecialidade", b =>
                {
                    b.HasOne("ConsultorioProjeto.Models.Entities.Especialidade", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsultorioProjeto.Models.Entities.Profissional", "Profissionais")
                        .WithMany()
                        .HasForeignKey("ProfissionaisIdProfissional")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidade");

                    b.Navigation("Profissionais");
                });

            modelBuilder.Entity("ConsultorioProjeto.Models.Entities.Paciente", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("ConsultorioProjeto.Models.Entities.Profissional", b =>
                {
                    b.Navigation("Consultas");

                    b.Navigation("Especialidades");
                });
#pragma warning restore 612, 618
        }
    }
}
