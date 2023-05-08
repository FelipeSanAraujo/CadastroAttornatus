namespace Attornatus.Core.Entities
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa(Guid pessoaId, string nome, DateTime dataDeNascimento, Guid? enderecoPrincipal)
        {
            PessoaId = pessoaId;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            EnderecoPrincipal = enderecoPrincipal;
        }

        public Pessoa(string nome, DateTime dataDeNascimento, Guid? enderecoPrincipal)
        {
            PessoaId = Guid.NewGuid();
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            EnderecoPrincipal = enderecoPrincipal;
        }

        public Guid PessoaId { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public Guid? EnderecoPrincipal { get; private set; }
        public virtual ICollection<Endereco>? Enderecos { get; set; }
    }
}
