using CrudEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.DTOs
{
    public class ReadCidadeDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroHabitantes { get; set; }
        public virtual ICollection<ReadPessoaDTO>? Pessoas { get; set; }
    }
}
