using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Abstract
{
    public interface ISparePartService
    {
        void ProductAdd(SparePart sparePart);
        void ProductDelete(SparePart sparePart);
        void ProductUpdate(SparePart sparePart);
        List<SparePart> GetList();
        SparePart GetById(int id);
    }
}
