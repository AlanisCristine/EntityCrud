using CrudEntity;
using Infraestrutura;
using Infraestrutura.Data;

namespace API.DataConfig
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;
        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Editar(Produto produto)
        {
            _context.Produtos.Update(produto);  
            _context.SaveChanges();
        }

        public List<Produto> Listar()
        {
            return _context.Produtos.ToList();
        }

        public void Remover(int id)
        {
            Produto produto = BuscarPorId(id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
        public Produto BuscarPorId(int id)
        {
            return _context.Produtos.Find(id);
        }
    }
}
