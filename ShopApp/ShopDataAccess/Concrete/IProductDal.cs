using Shop.Entities.Concrete;
using ShopDataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataAccess.Concrete
{
    public interface IProductDal:IEntityRepository<Product>
    {
       
    }
}
