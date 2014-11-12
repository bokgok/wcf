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
    public partial class FormSanPham : Form
    {
         private string NoiLuuHinhAnh = @"..\..\..\..\MobilePhoneWeb\MobilePhoneWeb\Images\Product\";

        private string NoiChonHinhAnh = "";
        ServiceSanPham.ServiceSanPhamClient SVSP = new ServiceSanPham.ServiceSanPhamClient();
        ServiceNhaSanXuat.NhaSanXuat NSX = new ServiceNhaSanXuat.NhaSanXuat();
        ServiceNhaSanXuat.ServiceNhaSanXuatClient SVNSX = new ServiceNhaSanXuat.ServiceNhaSanXuatClient();
        public FormSanPham()
        {
            InitializeComponent();
            showdata();
        }

        void showdata()
        {
            dataGridView1.DataSource = SVSP.SelectSanPham();
            cbxNhasanxuat.DataSource = SVNSX.SelectNhaSanXuat();
            cbxNhasanxuat.ValueMember = "MaNSX";
            cbxNhasanxuat.DisplayMember = "TenNSX";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //dua len textbox
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                TBmasp.Text = row.Cells["MaSP"].Value.ToString();
                Tbtensp.Text = row.Cells["TenSP"].Value.ToString();
                TBhinh.Text = row.Cells["UrlHinh"].Value.ToString();
                Tbgia.Text = row.Cells["Gia"].Value.ToString();
                Tbmota.Text = row.Cells["MoTa"].Value.ToString();
                cbxNhasanxuat.Text = row.Cells["MaNSX"].Value.ToString();
                Tbsoluong.Text = row.Cells["SoLuong"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ServiceNhaSanXuat.NhaSanXuat nsx = (ServiceNhaSanXuat.NhaSanXuat)cbxNhasanxuat.SelectedItem;
            int nsxnew = nsx.MaNSX;
            if (Tbgia.Text != "" && Tbmota .Text != "" && Tbsoluong.Text != "" && Tbtensp.Text != "")
            {
                try
                {
                    ServiceSanPham.SanPham update = new ServiceSanPham.SanPham();
                    update.MaSP = int.Parse(TBmasp.Text.ToString());
                    update.TenSP = Tbtensp.Text;
                    update.Gia = int.Parse(Tbgia.Text.ToString());
                    update.SoLuong = int.Parse(Tbsoluong.Text.ToString());
                    update.MoTa = Tbmota.Text;
                    update.UrlHinh = TBhinh.Text;
                    update.MaNSX = nsxnew;
                    if(checkBoxhinh.Checked == true)//chọn hình khác
                    {
                        try
                        {
                            File.Delete(NoiLuuHinhAnh + TBhinh.Text);
                            File.Copy(NoiChonHinhAnh, NoiLuuHinhAnh + TBhinh.Text);

                            if (SVSP.UpdateSanPham(update) == 1)
                            {
                                MessageBox.Show("Sửa thành công!");
                                //dataGridView1.Rows.Clear();
                                //showdata();
                                showdata();
                            }
                            else MessageBox.Show("Có lỗi xảy ra. Vui lòng thao tác lại!");
                        }
                        catch
                        {
                            MessageBox.Show("hình ảnh không hợp lệ!");
                        }
                    }
                    else
                    {
                        if (SVSP.UpdateSanPham(update) == 1)
                        {
                            MessageBox.Show("Sửa thành công!");
                            showdata();
                        }
                        else MessageBox.Show("Có lỗi xảy ra. Vui lòng thao tác lại!");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Số lượng và giá phải là số nguyên");
                }
            }
            else
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void chonhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();
            op1.Filter = "Images |*.jpg;*.jpeg;*.png;*.gif";
            op1.ShowDialog();
            TBhinh.Text = op1.SafeFileName;
            NoiChonHinhAnh = op1.FileName;
        }

        private void BTthem_Click(object sender, EventArgs e)
        {
            FormThemSP fr = new FormThemSP();
            fr.Show();
        }

        private void BTcapnhat_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ServiceSanPham.SanPham sp = (ServiceSanPham.SanPham)dataGridView1.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?!?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (SVSP.DeleteSanPham(sp) == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    showdata();
                }
                else MessageBox.Show("Còn dữ liệu ràng buộc. Không thể xóa!");
            }
        }

       
    }
}
