using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Shop.Entities.Concrete;

namespace ShopDataAccess.Concrete.Oracle
{
   public class OLProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }


        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
           {
               new Product{ ProductID = 1, CategoryId = 1, ProductName="PC",

                                QuantityPerUnit = "1 in a box", UnitPrice = 2000,

                                        UnitsInStock =10 }
           };

            return products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
