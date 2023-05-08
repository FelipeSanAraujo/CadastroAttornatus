using System.ComponentModel.DataAnnotations;

namespace Attornatus.Services.DTOs.PessoaDTOs
{
    public class AlterarPessoaDTO
    {
        [Required(ErrorMessage = "Campo obrigatório, informe um nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informe uma data de nascimento.")]
        public DateTime DataDeNascimento { get; set; }

        public Guid? EnderecoPrincipal { get; set; }
    }
}
