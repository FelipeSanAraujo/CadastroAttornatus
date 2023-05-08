using System.ComponentModel.DataAnnotations;

namespace Attornatus.Services.DTOs.EnderecoDTOs
{
    public class AlterarEnderecoDTO
    {
        [Required(ErrorMessage = "É necessário um o id do endereco para realizar a alteração.")]
        public Guid EnderecoId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informe um logradouro.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informe um Cep válido.")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informe um número.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório, informe uma cidade.")]
        public string Cidade { get; set; }

        [Required]
        public Guid PessoaId { get; set; }
    }
}
