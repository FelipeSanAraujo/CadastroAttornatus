using Attornatus.Core.Entities;
using Attornatus.Services.DTOs.EnderecoDTOs;

namespace Attornatus.Services.Interfaces
{
    public interface IEnderecoService
    {
        void Cadastrar(CadastrarEnderecoDTO dto);
        void Alterar(AlterarEnderecoDTO dto);

        IEnumerable<Endereco> Consultar();
    }
}
