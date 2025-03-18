using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace SIMS_Project.Repositories
{
        public interface IRepository<T> where T : class
        {
            IEnumerable<T> GetAll();
            IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
            T GetById(int id);
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
            void SaveChanges();
        }  
}
