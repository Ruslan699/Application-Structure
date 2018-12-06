using Shop.Entities.Concrete;
using ShopDataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataAccess.Concrete
{
   public class EFProductDal : EFEntityRepository<Product,ShopContext>, IProductDal
    {
       


    }
}
