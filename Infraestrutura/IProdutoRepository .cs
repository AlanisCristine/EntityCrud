using CrudEntity;

namespace Infraestrutura;
//Add-Migration
//Remove-Migration
//update-database
public interface IProdutoRepository
{
    void Adicionar(Produto produto);
    List<Produto> Listar();
    void Editar(Produto produto);
    void Remover(int id);
}
