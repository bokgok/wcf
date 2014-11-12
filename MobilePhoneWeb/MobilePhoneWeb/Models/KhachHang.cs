using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MobilePhoneWeb.Models
{
    public class KhachHang
    {
         [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public int MaKH { get; set; }
         [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        public string Username { get; set; }
         [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email không được để trống !")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
                   ErrorMessage = "Email không đúng định dạng.")]
        public string Email { get; set; }
         [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string HoTen { get; set; }
         [Required(ErrorMessage = "Vui lòng nhập giới tính")]
         [RegularExpression("(Nam|Nữ)",
                    ErrorMessage = "Chỉ được phép nhập 'Nam' hoặc 'Nữ'")]
        public string GioiTinh { get; set; }
         [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]
         [DataType(DataType.DateTime)]
         [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public string NgaySinh { get; set; }
         [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string DiaChi { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [RegularExpression("(09[0-9]{8}|01[2-9]{1}[0-9]{8})",
                   ErrorMessage = "số diên thoại không đúng định dạng.")]
        public string DienThoai { get; set; }
    }
}