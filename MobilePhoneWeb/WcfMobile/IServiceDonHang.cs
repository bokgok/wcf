using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMobile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceDonHang" in both code and config file together.
    [ServiceContract]
    public interface IServiceDonHang
    {
        [OperationContract]
        List<DonHang> SelectDonHang();

        [OperationContract]
        void InsertDonHang(DonHang info);

        [OperationContract]
        int UpdateDonHang(DonHang info);

        [OperationContract]
        void DeleteDonHang(DonHang info);

        [OperationContract]
        List<CT_DonHang> SelectCTDH();

        [OperationContract]
        void InsertCTDH(CT_DonHang info);

        [OperationContract]
        void UpdateCTDH(CT_DonHang info);

        [OperationContract]
        void DeleteCTDH(CT_DonHang info);

        [OperationContract]
        List<DonHang> BaocaoTheongay(string ngay1, string ngay2);
    }  
}
