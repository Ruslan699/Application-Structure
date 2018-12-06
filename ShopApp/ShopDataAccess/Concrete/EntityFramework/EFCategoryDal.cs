using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataAccess.Concrete.EntityFramework
{
    class EFCategoryDal:EFEntityRepository<Category, ShopContext>
    {
    }
}
