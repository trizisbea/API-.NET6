using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultorioProjeto.Models.Entities
{
    public class Especialidade
    {
         [Key]
         [Column("id_especialidade")]
        public int IdEspecialidade { get; set; }

        [Required]
        [Column("nome")]
        public string Nome { get; set; }

        [Column("ativa")]
        public bool Ativa { get; set; } = true;
        public ICollection<Consulta> Consultas { get; set; }

        public ICollection<Profissional> Profissionais { get; set; }

    }
}