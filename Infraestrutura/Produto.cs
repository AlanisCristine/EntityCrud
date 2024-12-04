using CrudEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int? PessoaId { get; set; }
        public virtual Pessoa? Pessoa { get; set; }
    }
}
