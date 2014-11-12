using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MobilePhoneWeb.Models
{
    public class DonHang
    {
         [Required(ErrorMessage = "Email không được để trống !")]
        public int MaDH { get; set; }
        public Nullable<int> MaKH { get; set; }
         [Required(ErrorMessage = "Email không được để trống !")]
        public Nullable<System.DateTime> Ngay { get; set; }
         [Required(ErrorMessage = "Email không được để trống !")]
        public Nullable<int> Trigia { get; set; }
         [Required(ErrorMessage = "Email không được để trống !")]
         [RegularExpression("0|1",
                    ErrorMessage = "Sai dữ liệu: chưa giao '0',đã giao:1")]
        public Nullable<int> TinhTrang { get; set; }
        public Nullable<int> MaNV { get; set; }
         [Required(ErrorMessage = "Email không được để trống !")]
        public string TenKH { get; set; }
         [Required(ErrorMessage = "Email không được để trống !")]
        public string Diachigiao { get; set; }
         [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
         [RegularExpression("(09[0-9]{8}|01[2-9]{1}[0-9]{8})",
                    ErrorMessage = "số diên thoại không đúng định dạng.")]
        public string Sdt { get; set; }
    }
}