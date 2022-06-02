using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SparePart
    {
        [Key]
        public int Part_Id { get; set; }
        [StringLength(50)]
        public string Part_Name  { get; set; } = default!;
        public int Part_Price { get; set; }
        public int Product_Id { get; set; }
     
    }
}
