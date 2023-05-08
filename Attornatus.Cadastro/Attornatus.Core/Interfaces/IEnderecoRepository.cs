using Attornatus.Core.Entities;

namespace Attornatus.Core.Interfaces
{
    public interface IEnderecoRepository
    {
        void Cadastrar(Endereco endereco);
        void Alterar(Endereco endereco);
        void Delete(Guid id);

        IEnumerable<Endereco> Consultar();
        Endereco ConsultarPorId(Guid Id);
    }
}
