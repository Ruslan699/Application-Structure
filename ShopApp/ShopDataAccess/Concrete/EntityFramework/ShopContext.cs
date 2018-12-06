using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataAccess.Concrete.EntityFramework
{
   public class ShopContext:DbContext
    { 
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
