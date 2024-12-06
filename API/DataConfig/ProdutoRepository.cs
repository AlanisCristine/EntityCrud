using CrudEntity;
using Infraestrutura;
using Infraestrutura.Data;

namespace API.DataConfig
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext context)
               : base(context) { }

    }
}
