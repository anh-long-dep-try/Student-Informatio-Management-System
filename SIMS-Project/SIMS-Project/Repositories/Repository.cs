using Microsoft.EntityFrameworkCore;
using SIMS_Project.Data;
using System.Linq.Expressions;

namespace SIMS_Project.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected AppDbContext _appDbContext;
        protected DbSet<T> _dbSet;
        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<T>();
        }


        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();//Covert IEnumerable to List
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();//Get all record in table where predicate is true
        }

        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);//Get record by id
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);//Add record to table
        }

        public virtual void Update(T entity)
        {
            _dbSet.Update(entity);//Attach record to table
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);//Remove record from table
        }
        public virtual void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }
    }
}
