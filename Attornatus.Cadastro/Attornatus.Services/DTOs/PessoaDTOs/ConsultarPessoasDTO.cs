using Attornatus.Core.Entities;

namespace Attornatus.Services.DTOs.PessoaDTOs
{
    public class ConsultarPessoasDTO
    {
        public Guid IdPessoa { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public Guid? EnderecoPrincipal { get; set; }
        public IEnumerable<Endereco> Endereco { get; set; }
    }
}
