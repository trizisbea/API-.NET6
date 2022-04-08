using AutoMapper;
using ConsultorioProjeto.Dtos;
using ConsultorioProjeto.Models.Entities;

// arquivo feito para setar as configurações do AutoMapper
// possível fazer isso também na Controller, mas dessa forma o SOLID é aplicado
namespace ConsultorioProjeto.Helpers
{
    public class ConsultorioProfile : Profile
    {
        public ConsultorioProfile()
        {
            //mapeamento de uma entidade ignorando um dos atributos
            CreateMap<Paciente, PacienteDetalhesDto>()
            .ForMember(dest => dest.Email, opt => opt.Ignore()); 

            CreateMap<Consulta, ConsultaDto>()
            .ForMember(dest => dest.Especialidade, opt => opt.MapFrom(src => src.Especialidade.Nome))
            .ForMember(dest => dest.Profissional, opt => opt.MapFrom(src => src.Profissional.Nome));

            CreateMap<Paciente, PacienteAdicionarDto>().ReverseMap();

            CreateMap<Paciente, PacienteAtualizarDto>().ReverseMap()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null)); 
        }
    }
}