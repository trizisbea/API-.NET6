using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultorioProjeto.Models.Entities
{
    public class Paciente
    {
        [Key]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }

        [Required]
        [Column("nome")]
        public string Nome { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Required]
        [Column("celular")]
        public string Celular { get; set; }

        [Required]
        [Column("cpf")]
        public string Cpf { get; set; }

        // 1 paciente - várias consultas
        public ICollection<Consulta> Consultas { get; set; }
    }
}