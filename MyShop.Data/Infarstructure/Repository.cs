using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Infarstructure
{
    public class Repository<TEntity> : IRepositoty<TEntity> where TEntity : class
    {
        protected readonly DbContext MovieDbContext;
        protected readonly IDbSet<TEntity> dbSet;
        public Repository(DbContext context)
        {
            MovieDbContext = context;
        }
        public TEntity Add(TEntity entity)
        {
            return MovieDbContext.Set<TEntity>().Add(entity);
        }
        public void Remove(int id)
        {
            MovieDbContext.Set<TEntity>().Remove(MovieDbContext.Set<TEntity>().Find(id));
        }
        
        public void AddRange(IEnumerable<TEntity> entities)
        {
            MovieDbContext.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            return MovieDbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return MovieDbContext.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            MovieDbContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            MovieDbContext.Set<TEntity>().RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
        }
    }
}
