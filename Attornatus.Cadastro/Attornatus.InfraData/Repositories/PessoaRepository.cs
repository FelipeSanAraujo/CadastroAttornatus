using Attornatus.Core.Entities;
using Attornatus.Core.Interfaces;
using Attornatus.InfraData.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Attornatus.InfraData.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly SqlServerContext _context;

        public PessoaRepository(SqlServerContext context)
        {
            _context = context;
        }

        public void Cadastrar(Pessoa pessoa)
        {
            _context.Set<Pessoa>().Entry(pessoa).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Alterar(Pessoa pessoa)
        {
            _context.Set<Pessoa>().Entry(pessoa).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Deletar(Pessoa pessoa)
        {
            _context.Set<Pessoa>().Entry(pessoa).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public IEnumerable<Pessoa> Consultar()
        {
            return _context.Set<Pessoa>().Include(e => e.Enderecos).ToList();
        }

        public Pessoa ConsultarComEnderecos(Guid id)
        {
            return _context.Set<Pessoa>().Include(e => e.Enderecos).FirstOrDefault();
        }

        public Pessoa ConsultarPorId(Guid id)
        {
            return _context.Set<Pessoa>().Where(e => e.PessoaId == id).AsNoTracking().FirstOrDefault();
        }
    }
}
