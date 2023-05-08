using Attornatus.Core.Entities;
using Attornatus.Services.DTOs.EnderecoDTOs;
using AutoMapper;

namespace Attornatus.Services.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CadastrarEnderecoDTO, Endereco>().ReverseMap();
            CreateMap<AlterarEnderecoDTO, Endereco>().ReverseMap();
        }
    }
}
