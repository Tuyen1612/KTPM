using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _0306191373_0306191333_0306191376_0306191482.Data
{
    public class ShopContext: DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        { }
        //public DbSet<account> Accounts { get; set; }
    }
}
