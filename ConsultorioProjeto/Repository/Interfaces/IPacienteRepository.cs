using ConsultorioProjeto.Dtos;
using ConsultorioProjeto.Models.Entities;

namespace ConsultorioProjeto.Repository.Interfaces
{
    public interface IPacienteRepository : IBaseRepository
    {
        Task<IEnumerable<PacienteDto>> GetPacientesAsync();
        Task<Paciente> GetPacientesByIdAsync(int id);
    }
}