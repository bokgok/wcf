using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceKhachHang" in both code and config file together.
    [ServiceContract]
    public interface IServiceKhachHang
    {
        [OperationContract]
        int DangNhap(string Username, string Password);
        [OperationContract]
        List<KhachHang> SelectKhachHang();
        [OperationContract]
        List<KhachHang> SelectKhachHangById(int id);
        [OperationContract]
       int InsertKhachHang(KhachHang info);

        [OperationContract]
        int UpdateKhachHang(KhachHang info);

        [OperationContract]
        int DeleteKhachHang(KhachHang info);
    }
}
