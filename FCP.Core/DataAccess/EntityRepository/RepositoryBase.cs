using FCP.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace FCP.Core.DataAccess.EntityRepository
{
    public class RepositoryBase<TContext, TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        TContext db = null;

        public RepositoryBase()
        {
            db = db ?? new TContext();
        }

        public int Add(TEntity entity)
        {
            try
            {
                var e = db.Entry(entity);
                e.State = EntityState.Added;
                return db.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log yapıştır.
                return -1;
            }
        }

        public int Delete(TEntity entity)
        {
            try
            {
                var e = db.Entry(entity);
                e.State = EntityState.Deleted;
                return db.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log yapıştır.
                return -1;
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> whereCond = null)
        {
            try
            {
                return whereCond == null
                    ? db.Set<TEntity>().ToList()
                    : db.Set<TEntity>().Where(whereCond).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> whereCond = null)
        {
            try
            {
                return whereCond == null
                    ? db.Set<TEntity>().FirstOrDefault()
                    : db.Set<TEntity>().FirstOrDefault(whereCond);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int Update(TEntity entity)
        {
            try
            {
                var e = db.Entry(entity);
                e.State = EntityState.Modified;
                return db.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log yapıştır.
                return -1;
            }
        }
    }
}
