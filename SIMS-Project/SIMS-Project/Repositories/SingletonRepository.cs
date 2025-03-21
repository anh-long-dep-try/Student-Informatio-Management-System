using Microsoft.EntityFrameworkCore;
using SIMS_Project.Data;
using SIMS_Project.Singleton;
using System.Linq.Expressions;

namespace SIMS_Project.Repositories
{
    public class SingletonRepository<T> where T : class
    {
        protected AppDbContext _appDbContext;
        protected DbSet<T> _dbSet;

        public SingletonRepository()
        {
            _appDbContext = AppDbContextSingleton.Instance;
            _dbSet = _appDbContext.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }
    }
}