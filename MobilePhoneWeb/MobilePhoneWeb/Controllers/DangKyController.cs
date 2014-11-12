using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobilePhoneWeb.Models;

namespace MobilePhoneWeb.Controllers
{
    public class DangKyController : Controller
    {
        //
        // GET: /DangKy/
        ServiceKhachHang.ServiceKhachHangClient ServiceKH = new ServiceKhachHang.ServiceKhachHangClient();
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(formKH user)
        {
            var test = ServiceKH.SelectKhachHang().Where(m => m.Username.Equals(user.Username));
            try
            {
                foreach(var a in test)
                {
                    ViewBag.Error = "<script language=javascript>alert('Tên đăng nhập đã được sử dụng');</script>";
                     return View(user);
                }
            }
            catch
            {   
            }
            var kh = new ServiceKhachHang.KhachHang();
            kh.DiaChi = user.DiaChi;
            kh.DienThoai = user.DienThoai;
            kh.HoTen = user.HoTen;
            kh.Password = user.Password;
            kh.Email = user.Email;
            kh.Username = user.Username;
            ServiceKH.InsertKhachHang(kh);
            return RedirectToAction("Index", "Index");                  
        }

    }
}
