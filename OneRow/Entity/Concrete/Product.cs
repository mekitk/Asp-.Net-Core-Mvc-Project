using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Product
    {

        [Key]
        public int Product_Id { get; set; }
        [StringLength(50)]
        public string Product_Name { get; set; } = default!;
        public int Sale_Price { get; set; }
        public ICollection<SparePart> Parts { get; set; } = default!;
    }
}
