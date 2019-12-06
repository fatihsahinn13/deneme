using FCP.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace FCP.Business.Abstract
{
    public interface IProductService :IServiceBase<Product>
    {
        List<Product> GetByCategory(int categoryID); 
    }
}
