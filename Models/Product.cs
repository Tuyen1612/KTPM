using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191373_0306191333_0306191376_0306191482.Models
{
    public class Product
    {
        [Key]
        [DisplayName("ID sản phẩm")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Mã sản phẩm")]
        public string SKU { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Tên sách")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Tên tác giả")]
        public string Author { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Đơn giá")]
        public int Price { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Số lượng")]
        public int Stock { get; set; }


        public int ProductTypeId { get; set; }
        [DisplayName("Loại sản phẩm")]
        public ProductType ProductType { get; set; }

        [DisplayName("Hình ảnh")]
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
