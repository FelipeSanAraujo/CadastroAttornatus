using Attornatus.Core.Entities;
using System.Text.Json.Serialization;

namespace Attornatus.Services.DTOs.EnderecoDTOs
{
    public class ConsultarEnderecosDTO
    {
        public Guid EnderecoId { get; private set; }
        public string Logradouro { get; private set; }
        public int Cep { get; private set; }
        public int Numero { get; private set; }
        public string Cidade { get; private set; }
        public Guid PessoaId { get; private set; }

        [JsonIgnore]
        public virtual Pessoa? Pessoa { get; set; }
    }
}
