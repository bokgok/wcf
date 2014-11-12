using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace MobilePhoneWeb.Models
{
    public class Users
    {
        [Required(ErrorMessage = "Vui lòng nhập tên người dùng")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Mật khẩu")]
        public string Passwork { get; set; }
    }
}