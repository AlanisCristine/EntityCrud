using CrudEntity;
using Infraestrutura;
using Infraestrutura.Data;

namespace API.DataConfig
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly ApplicationDbContext _context;

        public CidadeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Cidade cidade)
        {
            _context.Cidades.Add(cidade);
            _context.SaveChanges();
        }

        public void Editar(Cidade cidade)
        {
            _context.Cidades.Update(cidade);
            _context.SaveChanges();
        }

        public List<Cidade> Listar()
        {
            return _context.Cidades.ToList();
        }
        public Cidade BuscarPorId(int id)
        {
            return _context.Cidades.Find(id);
        }
        public void Remover(int id)
        {
            Cidade cidade = BuscarPorId(id);
            _context.Cidades.Remove(cidade);
            _context.SaveChanges();
        }
    }
}
