using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFCodeFirst.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext():base("connectionString")
        {

        }
        public DbSet<Product> ProductTable { get; set; }
    }
}