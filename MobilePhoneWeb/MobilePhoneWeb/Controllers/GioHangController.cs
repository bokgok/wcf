using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobilePhoneWeb.Models;

namespace MobilePhoneWeb.Controllers
{
    public class GioHangController : Controller
    {
        ServiceSanPham.CT_DonHang dhg = new ServiceSanPham.CT_DonHang();
        ServiceSanPham.ServiceSanPhamClient sp = new ServiceSanPham.ServiceSanPhamClient();
//        QL_DienThoaiEntities db = new QL_DienThoaiEntities();
        //
        // GET: /GioHang/
       
        public ActionResult Index()
        {
            DSGioHang ds = new DSGioHang
            {
                Cart = GetCart(),
            };
            return View(ds);
        }

        public ActionResult DefaultDH()
        {
            DSGioHang ds = new DSGioHang
            {
                Cart = GetCart(),
            };
            return View(ds);
        }
        public ActionResult giohangthem(int masanpham)
        {
            int soluong = 1;
//            List<SanPham> sp = db.SanPhams.ToList();
            foreach (var item in sp.SelectSanPham())
            {
                if (item.MaSP == masanpham)
                {
                    GetCart().AddItem(item.MaSP, item.TenSP, soluong, item.Gia, item.UrlHinh);
                }
            }
            return RedirectToAction("Index");
           
        }

        public ActionResult giohangxoa(int masanpham)
        {
            GetCart().RemoveLine(masanpham);
            return RedirectToAction("Index");
        }

        public ActionResult capnhatsoluong(int masanpham, string soluong)
        {

            if (int.Parse(soluong) < 4)
            {
                GetCart().capnhatsoluong(masanpham, int.Parse(soluong));
                ViewData["CartCount"] = GetCart().sogiohang();
            }
            else
            {
                GetCart().capnhatsoluong(masanpham, 1);
            }

            return RedirectToAction("Index");
        }

        private GioHang GetCart()
        {
            GioHang cart = (GioHang)Session["Cart"];
            if (cart == null)
            {
                cart = new GioHang();
                Session["Cart"] = cart;
            }
            return cart;
        }

        //   [ChildActionOnly]
        public ActionResult TongGioHang()
        {

            ViewData["CartCount"] = GetCart().sogiohang();

            return PartialView("TongGioHang");
        }

        public ActionResult menugiohang()
        {
            //if(HttpContext.User.Identity.Name=="")
            //{
            //    GetCart().Clear();
            //}
            return PartialView(new DSGioHang { Cart = GetCart() });
        }

    }
}
