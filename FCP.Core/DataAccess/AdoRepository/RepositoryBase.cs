using FCP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FCP.Core.DataAccess.AdoRepository
{
    public class RepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        public RepositoryBase()
        {
        }

        public int Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> whereCond = null)
        {
            throw new NotImplementedException();
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> whereCond = null)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
