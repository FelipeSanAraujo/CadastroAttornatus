using Attornatus.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Attornatus.InfraData.Mappings
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable(nameof(Pessoa));

            builder.HasKey(p => p.PessoaId);

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(p => p.DataDeNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(p => p.EnderecoPrincipal)
                .HasColumnName("EnderecoPrincipal");

            builder.HasMany(p => p.Enderecos)
                .WithOne(p => p.Pessoa)
                .HasForeignKey(e => e.PessoaId);
        }
    }
}
