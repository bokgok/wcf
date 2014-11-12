using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDonHang" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDonHang.svc or ServiceDonHang.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDonHang : IServiceDonHang
    {
        public List<DonHang> SelectDonHang()
        {
            var list = new List<DonHang>();
            using (QL_DienThoaiEntities2 db = new QL_DienThoaiEntities2())
            {
                try
                {
                    var donhang = from p in db.DonHangs select p;
                    foreach (DonHang item in donhang)
                    {
                        DonHang dh = new DonHang()
                        {
                            MaDH = item.MaDH,
                            MaKH = item.MaKH,
                            Ngay = item.Ngay,
                            Trigia = item.Trigia,
                            TinhTrang = item.TinhTrang,
                            MaNV = item.MaNV,
                            TenKH = item.TenKH,
                            Sdt= item.Sdt,
                            Diachigiao = item.Diachigiao
                        };
                        list.Add(dh);
                    }
                }
                catch
                {
                    return null;
                }
            }
            return list;
        }

        public void InsertDonHang(DonHang info)
        {
            using (QL_DienThoaiEntities2 db = new QL_DienThoaiEntities2())
            {
                try
                {
                    DonHang inserted = new DonHang
                    {
                      //  MaDH = info.MaDH,
                        MaKH = info.MaKH,
                        Ngay = info.Ngay,
                        Trigia = info.Trigia,
                        TinhTrang = 0,
                        Diachigiao = info.Diachigiao,
                        TenKH = info.TenKH,
                        Sdt = info.Sdt
//                        MaNV = info.MaNV
                    };
                    db.Entry(inserted).State = EntityState.Added;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException);
                }
            }
        }

        public int UpdateDonHang(DonHang info)
        {
            using (var db = new QL_DienThoaiEntities2())
            {
                try
                {
                    DonHang updated = new DonHang
                    {
                        MaDH = info.MaDH,
                        MaKH = info.MaKH,
                        MaNV = info.MaNV,
                        TenKH = info.TenKH,
                        Diachigiao = info.Diachigiao,
                        Sdt = info.Sdt,
                        Ngay = info.Ngay,
                        Trigia = info.Trigia,
                        TinhTrang = info.TinhTrang
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

        public void DeleteDonHang(DonHang info)
        {
            using (var db = new QL_DienThoaiEntities2())
            {
                try
                {
                    var deleted = (from p in db.DonHangs
                                   where p.MaDH == info.MaDH
                                   select p).FirstOrDefault();
                    db.Entry(deleted).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException);
                }
            }
        }

        public List<CT_DonHang> SelectCTDH()
        {
            var list = new List<CT_DonHang>();
            using (QL_DienThoaiEntities2 db = new QL_DienThoaiEntities2())
            {
                try
                {
                    var chitietdonhang = from p in db.CT_DonHang select p;
                    foreach (CT_DonHang item in chitietdonhang)
                    {
                        CT_DonHang ctdh = new CT_DonHang()
                        {
                            MaDH = item.MaDH,
                            MaSP = item.MaSP,
                            SoLuong = item.SoLuong,
                            Gia = item.Gia
                        };
                        list.Add(ctdh);
                    }
                }
                catch
                {
                    return null;
                }
            }
            return list;
        }

        public void InsertCTDH(CT_DonHang info)
        {
            using (QL_DienThoaiEntities2 db = new QL_DienThoaiEntities2())
            {
                try
                {
                    CT_DonHang inserted = new CT_DonHang
                    {
                        MaDH = info.MaDH,
                        MaSP = info.MaSP,
                        SoLuong = info.SoLuong,
                        Gia = info.Gia

                    };
                    db.Entry(inserted).State = EntityState.Added;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException);
                }
            }
        }

        public void UpdateCTDH(CT_DonHang info)
        {
            using (var db = new QL_DienThoaiEntities2())
            {
                try
                {
                    CT_DonHang updated = new CT_DonHang
                    {
                        MaDH = info.MaDH,
                        MaSP = info.MaSP,
                        SoLuong = info.SoLuong,
                        Gia = info.Gia
                    };
                    db.Entry(updated).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException);
                }
            }
        }

        public void DeleteCTDH(CT_DonHang info)
        {
            using (var db = new QL_DienThoaiEntities2())
            {
                try
                {
                    var deleted = (from p in db.CT_DonHang
                                   where p.MaDH == info.MaDH && p.MaSP == info.MaSP
                                   select p).FirstOrDefault();
                    db.Entry(deleted).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException);
                }
            }
        }

        //public void BaocaoThongke(string ngay1, string ngay2)
        //{ 
        //    using (var db = new QL_DienThoaiEntities())
        //    {
        //        try 
        //        {
        //            var baocao = (from p in db.DonHangs
        //                          where (p.Ngay >= DateTime.Parse(ngay1)) && (p.Ngay <= DateTime.Parse(ngay2))
        //                          select 
        //                            (from ct in db.CT_DonHang
        //                                 where p.MaDH == ct.MaDH
        //                                 select ct.MaSP
        //                            )
        //                          );
        //        }
        //        catch(Exception e) 
        //        {
        //            Console.WriteLine(e.InnerException);
        //        }
        //    }
        
        //}

//        public List<SanPham> BaocaoTheongay(string ngay1, string ngay2)
        public List<DonHang> BaocaoTheongay(string ngay1, string ngay2)
        {

            DateTime dt1 = DateTime.Parse(ngay1);
            DateTime dt2 = DateTime.Parse(ngay2);
//            var list = new List<SanPham>();
            var list = new List<DonHang
>();
            using (QL_DienThoaiEntities2 db = new QL_DienThoaiEntities2())
            {
                try
                {
                    //var baocao = from bc in db.DonHangs
                    //             where (bc.Ngay >= DateTime.Parse(ngay1)) && (bc.Ngay <= DateTime.Parse(ngay2))
                    //             select
//                    var baocao =     from ct in db.CT_DonHang
////                                    where ct.MaDH == bc.MaDH
//                                    select
//                                    (
//                                    from p in db.SanPhams 
//                                    where p.MaSP == ct.MaSP
//                                    select p
                                        
//                                    );
                    
                    var baocao = from dh in db.DonHangs
                                 where ((dh.Ngay >= dt1) && (dh.Ngay <= dt2))
                                 //&& (dh.Ngay <= DateTime.Parse(ngay2)))
                                 select dh;

                    foreach (DonHang item in baocao)
                    {
                        DonHang dhang = new DonHang()
                        {
                            MaDH = item.MaDH,
                            Ngay = item.Ngay,
                            Trigia = item.Trigia,
                            TenKH = item.TenKH,
                            Diachigiao= item.Diachigiao,
                            Sdt = item.Sdt

                        };
                        list.Add(dhang);
                    }
                    //foreach (SanPham item in baocao)
                    //{
                    //    SanPham sp = new SanPham()
                    //    {
                    //        MaSP = item.MaSP,
                    //        TenSP = item.TenSP,                  
                    //        Gia = item.Gia,
                    //        SoLuong = item.SoLuong                           
                    //    };
                    //    list.Add(sp);
                    //}
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
