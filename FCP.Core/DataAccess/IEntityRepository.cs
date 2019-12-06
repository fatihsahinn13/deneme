using FCP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FCP.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T GetSingle(Expression<Func<T, bool>> whereCond = null);
        List<T> GetList(Expression<Func<T, bool>> whereCond = null);
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
