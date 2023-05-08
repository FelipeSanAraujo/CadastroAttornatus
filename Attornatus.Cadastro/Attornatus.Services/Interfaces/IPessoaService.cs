using Attornatus.Core.Entities;
using Attornatus.Services.DTOs.PessoaDTOs;

namespace Attornatus.Services.Interfaces
{
    public interface IPessoaService
    {
        void Cadastrar(CadastrarPessoaDTO pessoa);
        void Alterar(Guid id, AlterarPessoaDTO dto);
        void Deletar(Guid id);

        IEnumerable<Pessoa> Consultar();
        Pessoa ConsultarComEnderecos(Guid id);
        Pessoa ConsultarPorId(Guid id);
    }
}
