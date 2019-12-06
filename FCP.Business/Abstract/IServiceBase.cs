using FCP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FCP.Business.Abstract
{
    public interface IServiceBase<T> where T : IEntity
    {
        List<T> GetAll();
        T GetSingle(Expression<Func<T, bool>> whereCond = null);
        T GetByID(int entityID);
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
