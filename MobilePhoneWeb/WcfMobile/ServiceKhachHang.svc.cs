﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceKhachHang" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceKhachHang.svc or ServiceKhachHang.svc.cs at the Solution Explorer and start debugging.
    public class ServiceKhachHang : IServiceKhachHang
    {
        public int DangNhap(string Username, string Password)
        {
            int login = -1;
            using (QL_DienThoaiEntities2 dc = new QL_DienThoaiEntities2())
            {
                var v = dc.KhachHangs.Where(a => a.Username.Equals(Username) && a.Password.Equals(Password)).FirstOrDefault();
                if (v != null)
                {
                    login = 1;
                }
            }
            return login;
        }
        public List<KhachHang> SelectKhachHang()
        {
            var list = new List<KhachHang>();
            using (var db = new QL_DienThoaiEntities2())
            {
                try
                {
                    //var khachhang = from p in db.KhachHangs select p;
                    var khachhang = from p in db.KhachHangs select new { p.MaKH, p.Username, p.Password, p.Email, p.HoTen, p.GioiTinh, p.NgaySinh, p.DiaChi, p.DienThoai };
                    foreach (var item in khachhang)
                    {
                        KhachHang kh = new KhachHang()
                        {
                            MaKH = item.MaKH,
                            Username = item.Username,
                            Password = item.Password,
                            Email = item.Email,
                            HoTen = item.HoTen,
                            GioiTinh = item.GioiTinh,
                            NgaySinh = item.NgaySinh,
                            DiaChi = item.DiaChi,
                            DienThoai = item.DienThoai
                        };
                        list.Add(kh);
                    }
                }
                catch
                {
                    return null;
                }
            }
            return list;
        }

        public int InsertKhachHang(KhachHang info)
        {
            using (var db = new QL_DienThoaiEntities2())
            {
                try
                {
                    KhachHang inserted = new KhachHang
                    {
                        Username = info.Username,
                        Password = info.Password,
                        Email = info.Email,
                        HoTen = info.HoTen,
                        GioiTinh = info.GioiTinh,
                        NgaySinh = info.NgaySinh,
                        DiaChi = info.DiaChi,
                        DienThoai = info.DienThoai
                    };
                    db.Entry(inserted).State = EntityState.Added;
                    db.SaveChanges();
                    return 1;
                }
                catch 
                {
                    return 0;
                }
            }
        }

        public int UpdateKhachHang(KhachHang info)
        {
            using (var db = new QL_DienThoaiEntities2())
            {
                try
                {
                    KhachHang updated = new KhachHang
                    {
                        MaKH = info.MaKH,
                        Username = info.Username,
                        Password = info.Password,
                        Email = info.Email,
                        HoTen = info.HoTen,
                        GioiTinh = info.GioiTinh,
                        NgaySinh = info.NgaySinh,
                        DiaChi = info.DiaChi,
                        DienThoai = info.DienThoai
                    };
                    db.Entry(updated).State = EntityState.Modified;
                    db.SaveChanges();
                    return 1;
                }
                catch 
                {
                    return 0;
                }
            }
        }

        public int DeleteKhachHang(KhachHang info)
        {
            using (var db = new QL_DienThoaiEntities2())
            {
                try
                {
                    var deleted = (from p in db.KhachHangs
                                   where p.MaKH == info.MaKH
                                   select p).FirstOrDefault();
                    db.Entry(deleted).State = EntityState.Deleted;
                    db.SaveChanges();
                    return 1;
                }
                catch 
                {
                    return 0;
                }
            }
        }
        public List<KhachHang> SelectKhachHangById(int id)
        {
            var list = new List<KhachHang>();
            using (QL_DienThoaiEntities2 db = new QL_DienThoaiEntities2())
            {
                try
                {
                    var kh = from p in db.KhachHangs where p.MaKH == id select p;
                    foreach (KhachHang  item in kh)
                    {
                        KhachHang khedit = new KhachHang()
                        {
                            MaKH = item.MaKH,
                            HoTen = item.HoTen,
                            Username = item.Username,
                            Password = item.Password,
                            NgaySinh = item.NgaySinh,
                            DiaChi = item.DiaChi,
                            DienThoai = item.DienThoai,
                            GioiTinh = item.GioiTinh,
                            Email = item.Email
                        };
                        list.Add(khedit);
                    }
                }
                catch
                {
                    return null;
                }
            }
            return list;
        }
    }
}
