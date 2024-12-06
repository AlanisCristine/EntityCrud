using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public  interface IBaseRepository<T>
    {
        void Adicionar(T produto);
        List<T> Listar();
        void Editar(T produto);
        void Remover(int id);
        T BuscarPorId(int id);
    }
}
