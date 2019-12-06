using FCP.Core.DataAccess;
using FCP.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace FCP.DAL.Abstract
{
   public  interface IProductDal: IEntityRepository<Product>
    {
    }
}
