using Bll.Concrete;
using Dal.Concrete;
using Dal.EntityFramework;
using Entity.Concrete;
using Entity.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Controllers
{
    
    public class PartController : Controller
    {
       
        SparePartManager sp = new SparePartManager(new EfSparePartRepository());
        ProductManager pm = new ProductManager(new EfProductRepository());
        Context context = new Context();
        [Authorize]
        public IActionResult Index()
        {
            List<SparePart> spareParts = new List<SparePart>();
            spareParts = sp.GetList();
            var list = sp.GetSparePartList();
            return View(list);
           
        }
        public IActionResult PartDelete(int id)
        {
           
            var sparepart = sp.GetById(id);
            sp.ProductDelete(sparepart);
            TempData["infoproductdelete"] = string.Format("{0} Part Deleted.: {1}", sparepart.Part_Name, DateTime.Now.ToString());
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult AddPart(int id)
        
        {
            SparePart sparePart = new SparePart();
            sparePart.Product_Id = id;
            var list = pm.GetList(); 
            ViewBag.GetData = new SelectList(list, "Product_Id", "Product_Name");

            return View(sparePart);
        }
        [HttpPost]
        public IActionResult AddPart(SparePart p,List<Product> products)
        {
            
            sp.ProductAdd(p);
            TempData["infoaddpart"] = string.Format("{0} Part Added: {1}", p.Part_Name, DateTime.Now.ToString());
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var list = pm.GetList();
            var spp = sp.GetById(id);
            int dd = spp.Product_Id;
            //var pmm = pm.GetById(dd);
            ViewBag.PartData = new SelectList(list, "Product_Id", "Product_Name");





            return View(spp);
        }

        [HttpPost]
        public IActionResult Update(SparePart p)
        {
            var sparePart = sp.GetById(p.Part_Id);
            sparePart.Product_Id = p.Product_Id;
            sparePart.Part_Name = p.Part_Name;
            sparePart.Part_Price = p.Part_Price;
            sp.ProductUpdate(sparePart);

            return RedirectToAction("Index");

          
        }


    }
}
