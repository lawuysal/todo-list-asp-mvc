using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IEntityRepository<T> where T : class
    {
        List<T> GetAll(Expression<Func<T, bool>>? filter = null);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        T Find(Expression<Func<T, bool>>? filter);
    }
}
