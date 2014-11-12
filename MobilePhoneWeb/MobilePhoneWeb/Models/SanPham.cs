using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MobilePhoneWeb.Models
{
    public class SanPham
    {
        public int MaSP { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
        public string TenSP { get; set; }
         [Required(ErrorMessage = "Vui lòng chọn hình")]
        public IEnumerable<HttpPostedFileBase> Files { get; set; }
       
        public string UrlHinh { get; set; }
        //[Required(ErrorMessage = "Vui lòng nhập giá")]
        [Range(1, 100000000000, ErrorMessage = "Giá phải là số nguyên dương!")]
        [DataType(DataType.Currency)]
        //[DisplayFormat(DataFormatString = "{0:c}")]
    //    [Range(typeof(int), "0", "100",
    //ErrorMessage = "{0} can only be between {1} and {2}")]
        //[Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Gia { get; set; }
        public string MoTa { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mã nhà sản xuất")]
        [RegularExpression("([0-9]{2}|1|2|3|4|5|6|7|8|9)",
                   ErrorMessage = "Sai định dạnh.số lượng phải là số nguyên dương<100")]
        public int SoLuong { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số lượng")]
        [RegularExpression("([1-4]{1})",
                   ErrorMessage = "1:Apple;2:Nokia;3:SamSung;4:Hãng Khác")]
        public int MaNSX { get; set; }
       
    
    }
}