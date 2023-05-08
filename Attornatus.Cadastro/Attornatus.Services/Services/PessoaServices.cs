using Attornatus.Core.Entities;
using Attornatus.Core.Interfaces;
using Attornatus.Services.DTOs.PessoaDTOs;
using Attornatus.Services.Interfaces;
using AutoMapper;

namespace Attornatus.Services.Services
{
    public class PessoaServices : IPessoaService
    {
        private readonly IMapper _mapper;
        private readonly IPessoaRepository _repository;

        public PessoaServices(IPessoaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Cadastrar(CadastrarPessoaDTO pessoa)
        {
            var pessoaMap = _mapper.Map<Pessoa>(pessoa);
            _repository.Cadastrar(pessoaMap);
        }

        public void Alterar(Guid id, AlterarPessoaDTO dto)
        {
            var pessoa = _repository.ConsultarPorId(id);
            if (pessoa == null)
                throw new ArgumentNullException(nameof(pessoa));

            var pessoaMap = new Pessoa(pessoa.PessoaId, dto.Nome, dto.DataDeNascimento, dto.EnderecoPrincipal);
            _repository.Alterar(pessoaMap);
        }

        public void Deletar(Guid id)
        {
            var pessoa = _repository.ConsultarPorId(id);
            if (pessoa is null)
                throw new ArgumentException("Pessoa não encontrada.");

            _repository.Deletar(pessoa);
        }

        public IEnumerable<Pessoa> Consultar()
        {
            var lista = _repository.Consultar();
            return lista;
        }

        public Pessoa ConsultarComEnderecos(Guid id)
        {
            return _repository.ConsultarComEnderecos(id);
        }

        public Pessoa ConsultarPorId(Guid id)
        {
            return _repository.ConsultarPorId(id);
        }
    }
}
