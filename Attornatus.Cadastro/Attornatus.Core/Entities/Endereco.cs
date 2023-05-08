namespace Attornatus.Core.Entities
{
    public class Endereco
    {
        public Endereco() { }
        
        public Endereco(string logradouro, int cep, int numero, string cidade, Guid idPessoa)
        {
            EnderecoId = Guid.NewGuid();
            Logradouro = logradouro;
            Cep = cep;
            Numero = numero;
            Cidade = cidade;
            PessoaId = idPessoa;
        }

        public Guid EnderecoId { get; private set; }
        public string Logradouro { get; private set; }
        public int Cep { get; private set; }
        public int Numero { get; private set; }
        public string Cidade { get; private set; }
        public Guid PessoaId { get; private set; }
        public virtual Pessoa? Pessoa { get; set; }
    }
}

