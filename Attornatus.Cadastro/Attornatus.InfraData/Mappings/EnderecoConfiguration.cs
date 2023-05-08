using Attornatus.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Attornatus.InfraData.Mappings
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable(nameof(Endereco));

            builder.HasKey(p => p.EnderecoId);

            builder.Property(p => p.Logradouro)
                .HasColumnName("Logradouro")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Numero)
                .HasColumnName("Numero")
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(p => p.Cep)
                .HasColumnName("Cep")
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(p => p.Cidade)
                .HasColumnName("Cidade")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(e => e.PessoaId)
                .HasColumnName("PessoaId")
                .IsRequired();
        }
    }
}
