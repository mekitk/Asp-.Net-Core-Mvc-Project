using Bll.Abstract;
using Dal.Abstract;
using Dal.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productdal;

        public ProductManager(IProductDal productdal)
        {
            _productdal =  productdal;
        }

        public Product GetById(int id)
        {
          return _productdal.GetById(id);
        }

        public List<Product> GetList()
        {
            return _productdal.GetList();
        }

        public void ProductAdd(Product product)
        {
            _productdal.Insert(product);
        }

        public void ProductDelete(Product product)
        {
           
                _productdal.Delete(product);
           
        }

        public void ProductUpdate(Product product)
        {
            _productdal.Update(product);
        }

      
    }
}
