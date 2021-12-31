using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191373_0306191333_0306191376_0306191482.Models
{
    public class ProductType
    {
        [Key]
        [DisplayName("Mã loại sản phẩm")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Tên loại sản phẩm")]
        public string TypeName { get; set; }

        [DisplayName("Trạng thái")]
        public int Status { get; set; }
        public List<Product> Products { get; set; }
    }
}
