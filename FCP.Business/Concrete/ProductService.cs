using FCP.Business.Abstract;
using FCP.DAL.Abstract;
using FCP.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FCP.Business.Concrete
{
    public class ProductService : IProductService
    {
        IProductDal iproductDal;
        public ProductService(IProductDal productDal)
        {
            iproductDal = productDal;
        }

        public int Add(Product entity)
        {
            return iproductDal.Add(entity);
        }

        public int Delete(Product entity)
        {
            return iproductDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return iproductDal.GetList();
        }

        public List<Product> GetByCategory(int categoryID)
        {
            return iproductDal.GetList(x => x.CategoryID == categoryID);
        }

        public Product GetByID(int entityID)
        {
            return iproductDal.GetSingle(x => x.ID == entityID);
        }

        public Product GetSingle(Expression<Func<Product, bool>> whereCond = null)
        {
            return iproductDal.GetSingle(whereCond);

        }

        public int Update(Product entity)
        {
            return iproductDal.Update(entity);
        }
    }
}
