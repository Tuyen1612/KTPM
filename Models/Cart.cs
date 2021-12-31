using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191373_0306191333_0306191376_0306191482.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
