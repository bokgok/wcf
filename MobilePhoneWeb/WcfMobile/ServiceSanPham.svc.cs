using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceSanPham" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceSanPham.svc or ServiceSanPham.svc.cs at the Solution Explorer and start debugging.
    public class ServiceSanPham : IServiceSanPham
    {
        QL_DienThoaiEntities2 db = new QL_DienThoaiEntities2();
        public List<SanPham> SelectSanPhamTheoNSX(int ma)
        {
            var list = new List<SanPham>();
            using (var db = new QL_DienThoaiEntities2())
            {
                try
                {
                    var sanpham = from p in db.SanPhams where p.MaNSX == ma select p;
                    foreach (SanPham item in sanpham)
                    {
                        SanPham sp = new SanPham()
                        {
                            MaSP = item.MaSP,
                            TenSP = item.TenSP,
                            UrlHinh = item.UrlHinh,
                            Gia = item.Gia,
                            MoTa = item.MoTa,
                            MaNSX = item.MaNSX,
                            SoLuong = item.SoLuong
                        };
                        list.Add(sp);
                    }
                }
                catch
                {
                    return null;
                }
            }
            return list;
        }
        public List<SanPham> TimKiem(string q)
        { 
            var list = new List<SanPham>();
            try
            {
                var pro = (from p in db.SanPhams
                       where p.TenSP.EndsWith(q)
                       || p.TenSP.StartsWith(q)
                       || p.TenSP.Equals(q)
                       || p.TenSP == q select p);
                foreach(var tksp in pro)
                {
                    SanPham sp = new SanPham()
                    {
                        MaSP = tksp.MaSP,
                        TenSP = tksp.TenSP,
                        Gia = tksp.Gia,
                        UrlHinh = tksp.UrlHinh
                    };
                    list.Add(sp);
                }
            }
            catch
            {
                return null;
            }
            return list;
        }
        public List<SanPham> SelectSanPham()
        {
            var list = new List<SanPham>();
            using (QL_DienThoaiEntities2 db = new QL_DienThoaiEntities2())
            {
                try
                {
                    var sanpham = from p in db.SanPhams select p;
                    foreach (SanPham item in sanpham)
                    {
                        SanPham sp = new SanPham()
                        {
                            MaSP = item.MaSP,
                            TenSP = item.TenSP,
                            UrlHinh = item.UrlHinh,
                            Gia = item.Gia,
                            MoTa = item.MoTa,
                            MaNSX = item.MaNSX,
                            SoLuong = item.SoLuong
                        };
                        list.Add(sp);
                    }
                }
                catch
                {
                    return null;
                }
            }
            return list;
        }

        public int InsertSanPham(SanPham info)
        {
            using (QL_DienThoaiEntities2 db = new QL_DienThoaiEntities2())
            {
                try
                {
                    SanPham inserted = new SanPham
                    {
                        //MaSP = info.MaSP,
                        TenSP = info.TenSP,
                        UrlHinh = info.UrlHinh,
                        Gia = info.Gia,
                        MoTa = info.MoTa,
                        MaNSX = info.MaNSX,
                        SoLuong = info.SoLuong
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

        public int UpdateSanPham(SanPham info)
        {
            using (var db = new QL_DienThoaiEntities2())
            {
                try
                {
                    SanPham updated = new SanPham
                    {
                        MaSP = info.MaSP,
                        TenSP = info.TenSP,
                        UrlHinh = info.UrlHinh,
                        Gia = info.Gia,
                        MoTa = info.MoTa,
                        MaNSX = info.MaNSX,
                        SoLuong = info.SoLuong
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

        public int DeleteSanPham(SanPham info)
        {
            using (var db = new QL_DienThoaiEntities2())
            {
                try
                {
                    var deleted = (from p in db.SanPhams
                                   where p.MaSP == info.MaSP
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

        public List<NhaSanXuat> GetNhaSanXuat()
        {
            var list = new List<NhaSanXuat>();
            using (QL_DienThoaiEntities2 db = new QL_DienThoaiEntities2())
            {
                try
                {
                    var nhasanxuat = from p in db.NhaSanXuats select p;
                    foreach (var item in nhasanxuat)
                    {
                        NhaSanXuat nsx = new NhaSanXuat()
                        {
                            MaNSX = item.MaNSX,
                            TenNSX = item.TenNSX
                        };
                        list.Add(nsx);
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
