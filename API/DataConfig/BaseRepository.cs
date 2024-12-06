using Infraestrutura;
using Infraestrutura.Data;
using Microsoft.EntityFrameworkCore;

namespace API.DataConfig
{
    public abstract class BaseRepository<T>: IBaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>(); 
        }
        public virtual void Adicionar(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public virtual void Editar(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public virtual List<T> Listar()
        {
            return _dbSet.ToList();
        }
        public virtual T BuscarPorId(int id)
        {
            return _dbSet.Find(id);
        }
        public virtual void Remover(int id)
        {
            T entity = BuscarPorId(id);
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}
