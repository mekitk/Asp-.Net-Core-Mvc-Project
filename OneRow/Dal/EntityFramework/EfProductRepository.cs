using Dal.Abstract;
using Dal.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>,IProductDal
    {

    }
}
