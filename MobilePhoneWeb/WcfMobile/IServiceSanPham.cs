using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceSanPham" in both code and config file together.
    [ServiceContract]
    public interface IServiceSanPham
    {
        [OperationContract]
        List<SanPham> TimKiem(string q);
        [OperationContract]
        List<SanPham> SelectSanPham();
        [OperationContract]
        List<SanPham> SelectSanPhamTheoNSX(int ma);

        [OperationContract]
        int InsertSanPham(SanPham info);

        [OperationContract]
        int UpdateSanPham(SanPham info);

        [OperationContract]
        int DeleteSanPham(SanPham info);

        [OperationContract]
        List<NhaSanXuat> GetNhaSanXuat();
    }
}
