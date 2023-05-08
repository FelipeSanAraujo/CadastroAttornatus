using Attornatus.Core.Entities;
using Attornatus.Services.DTOs.PessoaDTOs;
using AutoMapper;

namespace Attornatus.Services.Profiles
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<CadastrarPessoaDTO, Pessoa>().ReverseMap();
            CreateMap<AlterarPessoaDTO, Pessoa>().ReverseMap();
        }
    }
}
