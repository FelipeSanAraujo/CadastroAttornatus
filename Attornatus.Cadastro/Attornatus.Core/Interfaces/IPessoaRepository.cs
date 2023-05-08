using Attornatus.Core.Entities;

namespace Attornatus.Core.Interfaces
{
    public interface IPessoaRepository
    {
        void Cadastrar(Pessoa pessoa);
        void Alterar(Pessoa pessoa);
        void Deletar(Pessoa pessoa);

        IEnumerable<Pessoa> Consultar();
        Pessoa ConsultarComEnderecos(Guid id);
        Pessoa ConsultarPorId(Guid Id);
    }
}
