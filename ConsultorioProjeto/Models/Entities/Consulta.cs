using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultorioProjeto.Models.Entities
{
    public class Consulta : Base
    {
        // [Key]
        // [Column("id_consulta")]
        // public int IdConsulta { get; set; }

        [Required]
        [Column("data_horario")]
        public DateTime DataHorario { get; set; }

        [Column("status")]
        public int Status { get; set; }

        [Column("preco")]
        public decimal Preco { get; set; }

        [Required]
        [ForeignKey(nameof(Paciente))]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }
        public Paciente Paciente { get; set; }

        [Column("id_especialidade")]
        [ForeignKey(nameof(Especialidade))]
        public int IdEspecialidade { get; set; }
        public Especialidade Especialidade { get; set; }

        [Required]
        [ForeignKey(nameof(Profissional))]
        [Column("id_profissional")]
        public int IdProfissional { get; set; }
        public Profissional Profissional { get; set; }

    }
}