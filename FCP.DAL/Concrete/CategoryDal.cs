using FCP.Core.DataAccess.EntityRepository;
using FCP.DAL.Abstract;
using FCP.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace FCP.DAL.Concrete
{
    public class CategoryDal : RepositoryBase<FcpContext, Category>, ICategoryDal
    {
    }
}
