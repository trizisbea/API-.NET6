using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultorioProjeto.Models.Entities
{
    public class Profissional : Base
    {
        // [Key]
        // [Column("id_profissional")]
        // public int IdProfissional { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("ativo")]
        public bool Ativo { get; set; } = true; 

        public List<Consulta> Consultas { get; set; }
        public List<Especialidade> Especialidades { get; set; }
    }
}