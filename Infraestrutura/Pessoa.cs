using Infraestrutura;

namespace CrudEntity;

public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string CPF { get; set; }
    public int? CidadeId { get; set; }
    public virtual Cidade? Cidade { get; set; }
    public virtual ICollection<Produto>? Produtos { get; set; }
    

}
