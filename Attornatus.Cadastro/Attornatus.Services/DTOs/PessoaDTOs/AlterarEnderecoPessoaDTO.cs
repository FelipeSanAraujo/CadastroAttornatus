using System.ComponentModel.DataAnnotations;

namespace Attornatus.Services.DTOs.PessoaDTOs
{
    public class AlterarEnderecoPessoaDTO
    {
        [Required(ErrorMessage = "Informe um endereco principal.")]
        public Guid EnderecoPrincipal { get; set; }
    }
}
