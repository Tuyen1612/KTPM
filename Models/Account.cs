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
        [DisplayName("MÃ KHÁCH HÀNG")]
        public int id { get; set; }
        [DisplayName("Tên đăng nhập")]
        public string Username { get; set; }
        [DisplayName("Mật Khẩu")]
        public String Password { get; set; }
        [DisplayName("Email")]
        public String Email { get; set; }
        [DisplayName("Họ và Tên")]
        public String hovaten { get; set; }
        [DisplayName("Địa Chỉ")]
        public String diachi { get; set; }
        
    }
}
