using Bll.Abstract;
using Dal.Abstract;
using Dal.Concrete;
using Dal.EntityFramework;
using Entity.Concrete;
using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Concrete
{
    public class SparePartManager : ISparePartService
    {

        ISparePart _sparePart;
        Context context = new Context();

        public SparePartManager(ISparePart sparePart)
        {
            _sparePart = sparePart;
        }



        public SparePart GetById(int id)
        {
            return _sparePart.GetById(id);
        }

        public List<SparePart> GetList()
        {
            return _sparePart.GetList();
        }

        public void ProductAdd(SparePart sparePart)
        {
            _sparePart.Insert(sparePart);
        }

        public void ProductDelete(SparePart sparePart)
        {
            _sparePart.Delete(sparePart);
        }

        public void ProductUpdate(SparePart sparePart)
        {
            _sparePart.Update(sparePart);
        }

        public object GetSparePartList()
        {
            var result = from spare in context.SpareParts
                         join product in context.Products on spare.Product_Id equals product.Product_Id
                         select new SparePartDTO
                         {
                             PartName = spare.Part_Name,
                             Price = spare.Part_Price,
                             ProductName = product.Product_Name,
                             PartId = spare.Part_Id
                         };

           return result.ToList();

        }


        public object GetSparePartListById(int id)
        {
            var result = from spare in context.SpareParts
                         join product in context.Products on spare.Product_Id equals product.Product_Id
                         select new SparePartDTO
                         {
                             PartName = spare.Part_Name,
                             Price = spare.Part_Price,
                             ProductName = product.Product_Name,
                             PartId = spare.Part_Id
                         };

            return result.ToList();

        }
    }
}
