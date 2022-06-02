using Dal.Abstract;
using Dal.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repositories
{
    public class ProductRepository /*: IProductDal*/
    {
        Context c= new Context();

        public void AddProduct(Product product)
        {
            c.Add(product);
            c.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            c.Remove(product);
            c.SaveChanges();
        }

        public Product GetById(int id)
        {
            return c.Products.Find(id);
        }

        public List<Product> ListAll()
        {
            return c.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            c.Update(product);
            c.SaveChanges();
        }
    }
}
