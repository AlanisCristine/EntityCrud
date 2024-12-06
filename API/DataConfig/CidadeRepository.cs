using CrudEntity;
using Infraestrutura;
using Infraestrutura.Data;

namespace API.DataConfig
{
    public class CidadeRepository : BaseRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(ApplicationDbContext context)
             : base(context) { }


    }
}
