using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobilePhoneWeb.Models;
using MobilePhoneWeb;

namespace MobilePhoneWeb.Controllers
{
    public class DangnhapController : Controller
    {
        //
        // GET: /Dangnhap/
        ServiceKhachHang.ServiceKhachHangClient Kh = new ServiceKhachHang.ServiceKhachHangClient();
        public ActionResult Dangnhap()
        {
            if(Session["login"] == null)
            {
                return View();
            }
            return RedirectToAction("Index", "Index");
        }
        [HttpPost]
        public ActionResult DangNhap(Users u)
        {

            string Username = u.Username;
            string Password = u.Passwork;
            if(Kh.DangNhap(Username,Password) ==1)
            {
                MobilePhoneWeb.Models.Users user = new MobilePhoneWeb.Models.Users();
                user.Username = Username;
                Session["login"] = Username;
                var test = Kh.SelectKhachHang().Where(m => m.Username.Equals(Username));
                foreach(var a in test )
                {
                    Session["MaKH"] = a.MaKH;
                }
                return RedirectToAction("Index", "Index");
            }
            else
            {
                ViewBag.Error = "<script language=javascript>alert('Sai thông tin đăng nhập');</script>";
                return View(u);
            }
            
            return View(u);
        }
        public ActionResult DangXuataction()
        {
            Session["login"] = null;
            return RedirectToAction("Index", "Index");
        }

    }
}
