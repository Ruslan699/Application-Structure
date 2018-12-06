using Shop.Entities.Abstract;
using Shop.Entities.Concrete;
using ShopDataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataAccess.Concrete.EntityFramework
{
    public class EFEntityRepository<TEntity, TContext> : IEntityRepository<TEntity> where TEntity:class, IEntity, new()
                 where TContext:DbContext, new()
    {
        
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);

                addedEntity.State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
