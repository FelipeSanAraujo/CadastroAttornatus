﻿using Attornatus.Core.Entities;
using Attornatus.Core.Interfaces;
using Attornatus.Services.DTOs.EnderecoDTOs;
using Attornatus.Services.Interfaces;
using AutoMapper;

namespace Attornatus.Services.Services
{
    public class EnderecoServices : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IEnderecoRepository _repository;

        public EnderecoServices(IEnderecoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Cadastrar(CadastrarEnderecoDTO enderecoDTO)
        {
            var endereco = _mapper.Map<Endereco>(enderecoDTO);
            _repository.Cadastrar(endereco);
        }

        public void Alterar(AlterarEnderecoDTO dto)
        {
            var enderecoMap = _mapper.Map<Endereco>(dto);
            _repository.Alterar(enderecoMap);
        }

        public IEnumerable<ConsultarEnderecosDTO> Consultar()
        {
            var enderecos = _repository.Consultar();
            var enderecoMap = _mapper.Map<List<ConsultarEnderecosDTO>>(enderecos);
            return enderecoMap;
        }
    }
}
