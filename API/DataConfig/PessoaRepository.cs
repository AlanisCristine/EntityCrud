using CrudEntity;
using Infraestrutura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public class PessoaRepository :IPessoaRepository
    {
        private readonly ApplicationDbContext _context;
        public PessoaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
        }

        public List<Pessoa> Listar()
        {
            return _context.Pessoas.ToList();
        }
        public void Editar(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);
            _context.SaveChanges();
        }
        public Pessoa BuscarPorId(int id)
        {
            return _context.Pessoas.Find(id);
        }
        public void Remover(int id)
        {
            Pessoa pessoa = BuscarPorId(id);
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
        }
    }
}
