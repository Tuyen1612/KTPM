using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _0306191373_0306191333_0306191376_0306191482.Models
{
    public class Account
    {
        [Key]
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("UserName")]
        [MaxLength(20, ErrorMessage = "Maximum 20 characters")]
        public string Username { get; set; }
        [DisplayName("PassWord")]
        [MaxLength(20, ErrorMessage = "Maximum 20 characters")]
        public String Password { get; set; }
        [DisplayName("Email")]
        public String Email { get; set; }
        [DisplayName("Phone number")]
        public String Phone { get; set; }
        [DisplayName("Address")]
        public String Address { get; set; }
        [DisplayName("Full Name")]
        public String Fullname { get; set; }
        [DisplayName("Is Admin")]
        public bool IsAdmin { get; set; }
        [DisplayName("Avatar")]
        public  String Avatar {get; set; }
        [DisplayName("Status")]
        public bool Status { get; set; }

    }
}
