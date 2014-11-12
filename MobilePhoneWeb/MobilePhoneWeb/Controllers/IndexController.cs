using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobilePhoneWeb.Models;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel;
using PagedList;
namespace MobilePhoneWeb.Controllers
{
    public class IndexController : Controller
    {
        ServiceSanPham.ServiceSanPhamClient sp = new ServiceSanPham.ServiceSanPhamClient();
        
        //
        // GET: /Index/
        
//        QL_DienThoaiEntities db = new QL_DienThoaiEntities();
        public ActionResult Index()
        {
            //var pro = (from p in db.SanPhams
            //           select new SanPhams
            //           {
            //               MASP = p.MaSP,
            //               TENSP = p.TenSP,
            //               GIA = p.Gia,
            //                HINH = p.UrlHinh,
            //           }).OrderByDescending(x => x.MASP).Take(8);
            var pro = sp.SelectSanPham().OrderByDescending(x => x.MaSP).Take(8);
            ViewBag.Views = "Index";
            return View(pro);

        }
        public ActionResult sanpham(int? page)
        {
            //var pro = (from p in db.SanPhams
            //           select new SanPhams
            //           {
            //               MASP = p.MaSP,
            //               TENSP = p.TenSP,
            //               GIA = p.Gia,
            //                HINH = p.UrlHinh,
            //           }).OrderByDescending(x => x.MASP).Take(8);
            int pageNumber = page ?? 1;
            var pro2 = sp.SelectSanPham().OrderByDescending(x => x.MaSP).ToPagedList(pageNumber,12);
            ViewBag.Views = "Index";
            return View(pro2);
        }
        public ActionResult sanPhamCaoCap()
        {
            //var pro1 = (from p in db.SanPhams
            //           select new SanPhams
            //           {
            //               MASP = p.MaSP,
            //               TENSP = p.TenSP,
            //               GIA = p.Gia,
            //               HINH = p.UrlHinh,
            //           }).OrderByDescending(x => x.GIA).Take(10);
            var pro1 = sp.SelectSanPham().OrderByDescending(x => x.Gia).Take(8);
            ViewBag.Views = "sanPhamCaoCap";
            return PartialView(pro1);
        }

        public ActionResult Details(int id)
        {
            //var pro = (from p in db.SanPhams
            //           where id == p.MaSP
            //           select new SanPhams
            //           {
            //               MASP = p.MaSP,
            //               TENSP = p.TenSP,
            //               GIA = p.Gia,
            //               HINH = p.UrlHinh, 
            //               CHITIET = p.MoTa,                          
            //           });
            var pro = sp.SelectSanPham().Where(m => m.MaSP == id);
            ViewBag.Views = "ChiTiet";
            return View(pro);
        }
        public ActionResult Productbygroup(int idnsx, int?page)
        {
            //var pro = (from p in db.SanPhams
            //           where id == p.MaSP
            //           select new SanPhams
            //           {
            //               MASP = p.MaSP,
            //               TENSP = p.TenSP,
            //               GIA = p.Gia,
            //               HINH = p.UrlHinh, 
            //               CHITIET = p.MoTa,                          
            //           });
            var pro3 = sp.SelectSanPham().Where(m => m.MaNSX == idnsx).ToPagedList(1,12);
            ViewBag.Views = "ChiTiet";
            return View(pro3);
        }

            

    }
}
