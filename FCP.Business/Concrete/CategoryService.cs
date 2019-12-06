using FCP.Business.Abstract;
using FCP.DAL.Abstract;
using FCP.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FCP.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        ICategoryDal icategoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            icategoryDal = categoryDal;
        }

        public int Add(Category entity)
        {
            return icategoryDal.Add(entity);
        }

        public int Delete(Category entity)
        {
            return icategoryDal.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return icategoryDal.GetList();
        }

        public Category GetByID(int entityID)
        {
            return icategoryDal.GetSingle(x => x.ID == entityID);
        }

        public Category GetSingle(Expression<Func<Category, bool>> whereCond = null)
        {
            return icategoryDal.GetSingle(whereCond);
        }

        public int Update(Category entity)
        {
            return icategoryDal.Update(entity);
        }
    }
}
