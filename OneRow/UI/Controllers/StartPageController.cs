using Bll.Concrete;
using Dal.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class StartPageController : Controller
    {
        public IActionResult Index()
        {
            ProductManager pm = new ProductManager(new EfProductRepository());
          
            int products; 
            products = pm.GetList().Count();
            ViewData["productscount"] = products;
            return View();
        
            
        }
    }
}
