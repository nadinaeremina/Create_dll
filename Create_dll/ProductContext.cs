//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Create_dll.Model;
using Microsoft.EntityFrameworkCore;

namespace Create_dll
{
    public class ProductContext: DbContext
    {
        public DbSet<Product> products { get; set; } = null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=NADI\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
