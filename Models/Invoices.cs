using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace _0306191373_0306191333_0306191376_0306191482.Models
{
    public class Invoices
    {
        [Key]
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Code")]
        public string Code { get; set; }
        [DisplayName("IssuedDate")]
        public DateTime IssueDate { get; set; }
        [DisplayName("Shipping Address")]
        public String ShippingAddress { get; set; }
        [DisplayName("Shipping Phone")]
        public String ShippingPhone { get; set; }
        [DisplayName("Total")]
        public int Total { get; set; }
        [DisplayName("Account ID")]
        public Account Account { get; set; }
        [DisplayName("Status")]
        public bool Status { get; set; }

    }
}
