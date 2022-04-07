using ConsultorioProjeto.Context;
using ConsultorioProjeto.Dtos;
using ConsultorioProjeto.Dtos;
using ConsultorioProjeto.Models.Entities;
using ConsultorioProjeto.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConsultorioProjeto.Repository
{
    public class PacienteRepository : BaseRepository, IPacienteRepository
    {
        private readonly ConsultorioContext _context;
        public PacienteRepository(ConsultorioContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PacienteDto>> GetPacientesAsync()
        {

            // return await _context.Pacientes.ToListAsync();

            // include necessário porque as consultas não são alimentadas automaticamente
            //return await _context.Pacientes.Include(x => x.Consultas).ToListAsync(); 
 

            // Possível fazer um select dentro do repositório ao invés do DTO
            return await _context.Pacientes
                 .Select(x => new PacienteDto { IdPaciente = x.IdPaciente, Nome = x.Nome })
                 .ToListAsync();

        }

        public async Task<Paciente> GetPacientesByIdAsync(int id)
        {
            //alimentação de outra tabela por relacionamento
            //return await _context.Pacientes.Include(x => x.Consultas).Where(x => x.IdPaciente == id).FirstOrDefaultAsync();


            return await _context.Pacientes.Include(x => x.Consultas)
            .ThenInclude(c => c.Especialidade)
            .ThenInclude(c => c.Profissionais)
            .Where(x => x.IdPaciente == id).FirstOrDefaultAsync();
        }
    }
}