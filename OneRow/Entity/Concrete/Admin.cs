﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public  class Admin
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string User_Name { get; set; } = default!;
        public int User_Password { get; set; }
        
    }
}
