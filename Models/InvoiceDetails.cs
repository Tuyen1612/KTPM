using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace _0306191373_0306191333_0306191376_0306191482.Models
{
    public class InvoiceDetail
    {
        [Key]
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Quanity")]
        public int Quantity { get; set; }
        [DisplayName("Unit Price")]
        public int UnitPrice { get; set; }
        [DisplayName("Invoice ID")]
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        [DisplayName("Product ID")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
    }
}
