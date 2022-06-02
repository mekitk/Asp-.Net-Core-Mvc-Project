using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class SparePartDTO
    {
        public string PartName { get; set; }
        public int Price { get; set; }
        public string ProductName { get; set; }

        public int PartId { get; set; }

        public int ProductId { get; set; }

    }
}
