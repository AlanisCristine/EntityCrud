using CrudEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura;

public interface ICidadeRepository
{
    void Adicionar(Cidade cidade);
    List<Cidade> Listar();
    void Editar(Cidade cidade);
    void Remover(int id);
}
