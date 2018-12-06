using Shop.Business.Abstract;
using Shop.Entities.Concrete;
using ShopDataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Concrete
{
    //User can access what Programmer permitted
   public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
