using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileDesktop
{
    public partial class FormThemSP : Form
    {
        private string NoiLuuHinhAnh = @"..\..\..\..\MobilePhoneWeb\MobilePhoneWeb\Images\Product\";

        private string NoiChonHinhAnh = "";
        ServiceSanPham.ServiceSanPhamClient SVSP = new ServiceSanPham.ServiceSanPhamClient();
        ServiceNhaSanXuat.ServiceNhaSanXuatClient SVNSX = new ServiceNhaSanXuat.ServiceNhaSanXuatClient();

        ServiceNhaSanXuat.NhaSanXuat objnsx = new ServiceNhaSanXuat.NhaSanXuat();
        public FormThemSP()
        {
            InitializeComponent();
        }

        private void FormThemSP_Load(object sender, EventArgs e)
        {
           

           
            CBnsx.DataSource = SVNSX.SelectNhaSanXuat();
            CBnsx.ValueMember = "MaNSX";
            CBnsx.DisplayMember = "TenNSX";
            
        }

        private void BTthemsp_Click(object sender, EventArgs e)
        {
            ServiceNhaSanXuat.NhaSanXuat nsx = (ServiceNhaSanXuat.NhaSanXuat)CBnsx.SelectedItem;
            int nsxnew = nsx.MaNSX;
            if (TBgia.Text != "" && TBmota.Text != "" && TBsoluong.Text != "" && TBtensp.Text != "")
            {
                try
                {
                    ServiceSanPham.SanPham inserted = new ServiceSanPham.SanPham();
                    inserted.TenSP = TBtensp.Text;
                    inserted.Gia = int.Parse(TBgia.Text.ToString());
                    inserted.SoLuong = int.Parse(TBsoluong.Text.ToString());
                    inserted.MoTa = TBmota.Text;
                    inserted.MaNSX = nsxnew;
                    inserted.UrlHinh = TBhinh.Text;
                    try
                    {
                        File.Delete(NoiLuuHinhAnh + TBhinh.Text);
                        File.Copy(NoiChonHinhAnh, NoiLuuHinhAnh + TBhinh.Text);

                        if (SVSP.InsertSanPham(inserted) == 1)
                        {
                            MessageBox.Show("Thêm thành công!");
                        }
                        else MessageBox.Show("Có lỗi xảy ra. Vui lòng thao tác lại!");
                    }
                    catch
                    {
                        MessageBox.Show("Hình ảnh không hợp lệ!");
                    }
                }
                catch
                {
                    MessageBox.Show("Số lượng và giá phải là số nguyên!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }

        }

        private void BTchonhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();
            op1.Filter = "Images |*.jpg;*.jpeg;*.png;*.gif";
            op1.ShowDialog();
            TBhinh.Text = op1.SafeFileName;
            NoiChonHinhAnh = op1.FileName;
        }

        private void BTlammoi_Click(object sender, EventArgs e)
        {
            TBgia.Text = "";
            TBhinh.Text = "";
            TBmota.Text = "";
            TBsoluong.Text = "";
            TBtensp.Text = "";
        }
    }
}
    