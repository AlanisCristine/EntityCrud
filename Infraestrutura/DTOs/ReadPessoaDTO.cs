using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.DTOs
{
    public class ReadPessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public virtual ICollection<ReadProdutoDTO>? Produtos { get; set; }
    }
}
