using AutoMapper;
using ConsultorioProjeto.Dtos;
using ConsultorioProjeto.Models.Entities;
using ConsultorioProjeto.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConsultorioProjeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _repository;
        public IMapper _mapper;

        public PacienteController(IPacienteRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;

        }
        // ******* método get all ******
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pacientes = await _repository.GetPacientesAsync();

            // List<PacienteDto> pacientesRetorno = new List<PacienteDto>();

            // foreach (var paciente in pacientes)
            // {
            //     pacientesRetorno.Add(new PacienteDto { Id = paciente.IdPaciente, Nome = paciente.Nome });
            // }

            return pacientes.Any()
            ? Ok(pacientes)
            : BadRequest("Paciente não encontrado");
        }

        // ****** método get por id ******

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var paciente = await _repository.GetPacientesByIdAsync(id);

            var pacienteRetorno = _mapper.Map<PacienteDetalhesDto>(paciente);

            return pacienteRetorno != null
                    ? Ok(pacienteRetorno)
                    : BadRequest("Paciente não encontrado.");

            //    sem o uso de dto e map: 
            //    var paciente = await _repository.GetPacientesByIdAsync(id);
            //     return paciente != null
            //     ? Ok(paciente)
            //     : BadRequest("Paciente não encontrado"); 
        }

        // ****** método post ******

        [HttpPost]
        public async Task<IActionResult> Post(PacienteAdicionarDto paciente)
        {
            if (paciente == null) return BadRequest("Dados Inválidos");

            var pacienteAdicionar = _mapper.Map<Paciente>(paciente);

            _repository.Add(pacienteAdicionar);

            return await _repository.SaveChangesAsync()
                ? Ok("Paciente adicionado com sucesso")
                : BadRequest("Erro ao salvar o paciente");
        }

        // ****** método put ******
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PacienteAtualizarDto paciente)
        {
            if (id <= 0) return BadRequest("Usuário não informado");

            var pacienteBanco = await _repository.GetPacientesByIdAsync(id);

            var pacienteAtualizar = _mapper.Map(paciente, pacienteBanco);

            _repository.Update(pacienteAtualizar);

            return await _repository.SaveChangesAsync()
                 ? Ok("Paciente atualizado com sucesso")
                 : BadRequest("Erro ao atualizar o paciente");
        }

        // ****** método delete ******
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest("Paciente inválido");

            var pacienteExcluir = await _repository.GetPacientesByIdAsync(id);

            if (pacienteExcluir == null) return NotFound("Paciente não encontrado");

            _repository.Delete(pacienteExcluir);

            return await _repository.SaveChangesAsync()
                 ? Ok("Paciente deletado com sucesso")
                 : BadRequest("Erro ao deletar o paciente");
        }

    }
}