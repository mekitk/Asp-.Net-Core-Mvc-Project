using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Concrete
{
    public class Context :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-D9DGB3V\\SQLEXPRESS; database=OneRowDb; integrated security=true;");
        }
        


        public DbSet<Product> Products { get; set; }

        public DbSet<SparePart> SpareParts { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}
