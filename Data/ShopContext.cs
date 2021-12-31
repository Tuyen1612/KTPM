using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0306191373_0306191333_0306191376_0306191482.Models;
using Microsoft.EntityFrameworkCore;

namespace _0306191373_0306191333_0306191376_0306191482.Data
{
    public class ShopContext: DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        { }
        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
