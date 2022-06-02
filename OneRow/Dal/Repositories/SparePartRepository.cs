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
    public  class SparePartRepository /*: ISparePart*/
    {
        

        public void AddSparePart(SparePart sparePart)
        {
            using var c=new Context();
            c.Add(sparePart);
            c.SaveChanges();
        }

        public void DeleteSparePart(SparePart sparePart)
        {
            using var c = new Context();
            c.Remove(sparePart);
            c.SaveChanges();
        }

        public SparePart GetById(int id)
        {
            using var c = new Context();
            return c.SpareParts.Find(id);
        }

        public List<SparePart> ListAll()
        {
            using var c = new Context();
            return c.SpareParts.ToList();
        }

        public void UpdateSparePart(SparePart sparePart)
        {
            using var c = new Context();
            c.Update(sparePart);
            c.SaveChanges();
        }
    }
}
