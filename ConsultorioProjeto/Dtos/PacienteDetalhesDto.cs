using ConsultorioProjeto.Models.Entities;

namespace ConsultorioProjeto.Dtos
{
    public class PacienteDetalhesDto
    {
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public ICollection<ConsultaDto> Consultas { get; set; }
    }
}