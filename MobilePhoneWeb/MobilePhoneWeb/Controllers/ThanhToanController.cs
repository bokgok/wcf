using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobilePhoneWeb.Models;
namespace MobilePhoneWeb.Controllers
{
    public class ThanhToanController : Controller
    {
        //
        // GET: /ThanhToan/
//        QL_DienThoaiEntities db = new QL_DienThoaiEntities();
        ServiceSanPham.ServiceSanPhamClient sanpham = new ServiceSanPham.ServiceSanPhamClient();
        ServiceDonHang.ServiceDonHangClient donhang = new ServiceDonHang.ServiceDonHangClient();

        ServiceDonHang.DonHang donh = new ServiceDonHang.DonHang();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DatHang()
        {
            
                return View();
                 
        }
        public ActionResult DatHangaction(ThongTinNguoiDatHang TTKH)
        {
            var hd = new ServiceDonHang.DonHang();
            List<ServiceSanPham.SanPham> sp = sanpham.SelectSanPham().ToList();
            var _hd = (from s in donhang.SelectDonHang() orderby s.MaDH descending select s).FirstOrDefault();
            int i = _hd.MaDH;
            i++;
            var cart = GetCart();
           try
           {
            if (ModelState.IsValid)
            {
                if (Session["login"] == null)
                {
                    hd.MaDH = i;
                    hd.TenKH = TTKH.tennguoinhan;
                    hd.Sdt = TTKH.sodt;
                    hd.Diachigiao = TTKH.diachi;
                    hd.Ngay = DateTime.Now;
                    hd.Trigia = (int)GetCart().tongtien();
                    hd.TinhTrang = 0;
                    donhang.InsertDonHang(hd);
                    GetCart().AddChiTietHoaDon(hd);
                    foreach (var item in sp)
                    {
                        GetCart().RemoveLine(item.MaSP);
                    }
                    return RedirectToAction("HoanTat",
                             new { id = hd.MaDH });
                }
                else
                {
                    hd.MaKH = int.Parse(Session["MaKH"].ToString());
                    hd.MaDH = i;
                    hd.TenKH = TTKH.tennguoinhan;
                    hd.Sdt = TTKH.sodt;
                   hd.Diachigiao = TTKH.diachi;
                    hd.Ngay = DateTime.Now;
                     hd.Trigia = (int)GetCart().tongtien();
                    hd.TinhTrang = 0;
                     donhang.InsertDonHang(hd);
                    donhang.UpdateDonHang(hd);
                    GetCart().AddChiTietHoaDon(hd);
                    foreach (var item in sp)
                    {
                        GetCart().RemoveLine(item.MaSP);
                    }
                    return RedirectToAction("HoanTat",
                             new { id = hd.MaDH });
                }
            }
            return RedirectToAction("DatHang");
           }
            catch
            {
                return RedirectToAction("DatHang");
            }
            
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

        public ActionResult HoanTat()
        {
            return View();
        }

        public ActionResult DonHangUser()
        {
         if(Session["login"]!=null)
         {
             var dh = donhang.SelectDonHang().Where(m => m.MaKH == int.Parse(Session["MaKH"].ToString()));
             return View(dh);
         }
         else
         {
             return RedirectToAction("Index", "Index");
         }
        }
        public ActionResult SuaDonHang(int id)
        {
            var kh = donhang.SelectDonHang().Where(m => m.MaDH == id);

            MobilePhoneWeb.Models.DonHang editdh = new Models.DonHang();
            foreach (var a in kh)
            {
                editdh.MaKH = a.MaKH;
                editdh.MaDH = a.MaDH;
                editdh.TenKH = a.TenKH;
                editdh.Ngay = a.Ngay;
                editdh.MaNV = a.MaNV;
                editdh.Diachigiao = a.Diachigiao;
                editdh.Sdt = a.Sdt;
                editdh.Trigia = a.Trigia;
                editdh.TinhTrang = a.TinhTrang;
            }
            return View(editdh);

        }
        [HttpPost]
        public ActionResult SuaDonHang(DonHang updatedh)
        {
            try
            {
                int madh = updatedh.MaDH;
                string makh = updatedh.MaKH.ToString();
                string tenkh = updatedh.TenKH;
                string manv = updatedh.MaNV.ToString();
                DateTime ngay = DateTime.Now;
                string tongtien = updatedh.Trigia.ToString();
                string dc = updatedh.Diachigiao;
                string sdt = updatedh.Sdt;
                string tinhtrang = updatedh.TinhTrang.ToString();
                ServiceDonHang.DonHang dh = new ServiceDonHang.DonHang();
                dh.MaDH = madh;
                dh.Sdt = sdt;
                dh.Trigia = int.Parse(tongtien);
                dh.Diachigiao = dc;
                dh.TinhTrang = int.Parse(tinhtrang);
                dh.TenKH = tenkh;
                try
                {
                    dh.MaKH = int.Parse(makh);
                }
                catch
                {
                    dh.MaKH = null;
                }
                try
                {
                    dh.MaNV = int.Parse(manv);

                }
                catch
                {
                    dh.MaNV = null;
                }
                dh.Ngay = ngay;
                donhang.UpdateDonHang(dh);
                return RedirectToAction("DonHangUser");
            }
            catch
            {
                ViewBag.Error = "<script language=javascript>alert('Sai thông tin ngày tháng vui lòng nhập tháng/ngày/năm');</script>";
            }
            return View(updatedh);
        }
        public ActionResult ChiTietDonHang(int id)
        {
            var lctdh = new List<ChiTietDonHang>();
            var a = donhang.SelectCTDH().Where(m => m.MaDH == id);
            foreach(var tmp in a)
            {
                var ctdh = new ChiTietDonHang();
                ctdh.soluong = tmp.SoLuong.ToString();
                 ctdh.tonggia = (tmp.SoLuong * tmp.Gia).ToString();
                var sp = sanpham.SelectSanPham().Where(m => m.MaSP == tmp.MaSP);
                foreach(var tmpsp in sp)
                {
                    ctdh.tensp = tmpsp.TenSP;
                    ctdh.gia = tmpsp.Gia.ToString();
                }
                lctdh.Add(ctdh);
            }
            return View(lctdh);
        }
    }
}
