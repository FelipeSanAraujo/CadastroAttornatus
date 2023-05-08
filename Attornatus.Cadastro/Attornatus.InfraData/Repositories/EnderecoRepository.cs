using Attornatus.Core.Entities;
using Attornatus.Core.Interfaces;
using Attornatus.InfraData.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Attornatus.InfraData.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly SqlServerContext _context;

        public EnderecoRepository(SqlServerContext context)
        {
            _context = context;
        }

        public void Cadastrar(Endereco endereco)
        {
            _context.Set<Endereco>().Entry(endereco).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Alterar(Endereco endereco)
        {
            _context.Set<Endereco>().Entry(endereco).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<Endereco> Consultar()
        {
            return _context.Set<Endereco>().ToList();
        }

        public Endereco ConsultarPorId(Guid id)
        {
            return _context.Set<Endereco>().Find(id);
        }

        public void Delete(Guid id)
        {
            var endereco = _context.Set<Endereco>().Find(id);
            _context.Set<Endereco>().Entry(endereco).State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
