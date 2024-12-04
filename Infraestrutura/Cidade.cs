using CrudEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura;

public class Cidade
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int NumeroHabitantes { get; set; }
    public virtual ICollection<Pessoa>? Pessoas { get; set; }
}
