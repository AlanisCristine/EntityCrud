using CrudEntity;

namespace Infraestrutura;
//Add-Migration
//Remove-Migration
//update-database
public interface IPessoaRepository
{
    void Adicionar(Pessoa pessoa);
    List<Pessoa> Listar();
    void Editar(Pessoa pessoa);
    void Remover(int id);
}
