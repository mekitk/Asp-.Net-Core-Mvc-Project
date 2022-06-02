using Bll.Concrete;
using Dal.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        SparePartManager sp = new SparePartManager(new EfSparePartRepository());
        [Authorize]
        public IActionResult Index(int page=1)
        {
           
            List<Product> products=new List<Product>();
            products = pm.GetList();
          
            return View(products.ToPagedList(page,3));
        }

        public IActionResult ProductDelete(int id)
        {
            var sparepart = sp.GetById(id);
            var product= pm.GetById(id);

            if (sparepart == null)
            {
                pm.ProductDelete(product);
                TempData["infoproductdelete"]= string.Format("{0} Product Deleted.: {1}", product.Product_Name, DateTime.Now.ToString());
            }
            else
            {
              
                TempData["infoproductdelete"] = string.Format("Not Deleted..{0} Product Has One or Many Parts: {1}", product.Product_Name, DateTime.Now.ToString());
            }
            
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
          
            pm.ProductAdd(p);
            TempData["infoaddproduct"] = string.Format("{0} Product Added: {1}", p.Product_Name, DateTime.Now.ToString());
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var product = pm.GetById(id);
            Product pd = new Product();
            {
                pd.Product_Id = product.Product_Id;
                pd.Product_Name=product.Product_Name;
                pd.Sale_Price=product.Sale_Price;
            }
            return View(pd);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            var up= pm.GetById(p.Product_Id);
            up.Product_Name = p.Product_Name;
            up.Sale_Price = p.Sale_Price; 
            pm.ProductUpdate(up);
            return RedirectToAction("Index");
        }


    }
}
