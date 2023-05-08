using System.ComponentModel.DataAnnotations;

namespace Attornatus.Services.DTOs.EnderecoDTOs
{
    public class CadastrarEnderecoDTO
    {
        [Required(ErrorMessage = "Campo obrigatório, informe um logradouro.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informe um Cep válido.")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informe um número.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informe uma cidade.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informe o id da pessoa.")]
        public Guid PessoaId { get; set; }
    }
}
