using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BaseRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {
        public async Task AddAsync(TEntity p)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(p);
                addedEntity.State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(TEntity p)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(p);
                deletedEntity.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public TEntity Find(Expression<Func<TEntity, bool>>? where)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(where);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public async Task UpdateAsync(TEntity p)
        {
            using (TContext context = new TContext())
            {
                var modifiedEntity = context.Entry(p);
                modifiedEntity.State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }
    }
}
