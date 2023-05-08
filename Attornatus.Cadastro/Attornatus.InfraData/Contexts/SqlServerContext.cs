using Attornatus.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Attornatus.InfraData.Contexts
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> opts) : base(opts)
        {
        }

        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            base.OnModelCreating(optionsBuilder);
            optionsBuilder.ApplyConfigurationsFromAssembly(typeof(SqlServerContext).Assembly);
        }

        DbSet<Pessoa>? Pessoas { get; set; }
        DbSet<Endereco>? Enderecos { get; set; }
    }
}
