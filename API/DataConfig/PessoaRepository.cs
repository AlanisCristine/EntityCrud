using API.DataConfig;
using CrudEntity;
using Infraestrutura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public class PessoaRepository :BaseRepository<Pessoa>, IPessoaRepository
    {
       
        public PessoaRepository(ApplicationDbContext context)
            : base(context) { }
       
    }
}
