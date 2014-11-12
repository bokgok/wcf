using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileDesktop
{
    public partial class FormKhachHang : Form
    {
        ServiceKhachHang.ServiceKhachHangClient SVKH = new ServiceKhachHang.ServiceKhachHangClient();
        ServiceKhachHang.KhachHang opjkh = new ServiceKhachHang.KhachHang();
        public FormKhachHang()
        {
            InitializeComponent();
            showdata();
            //txtMakh.Enabled = false;
            txtGioitinh.Enabled = false;
        }

        public void showdata()
        {
            dataGridView1.DataSource = SVKH.SelectKhachHang();
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.Columns["MaKH"].Visible = false;
            btnluu.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtMakh.Text = row.Cells["MaKH"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtHoten.Text = row.Cells["HoTen"].Value.ToString();
                //txtGioitinh.Text = row.Cells["GioiTinh"].Value.ToString();

                try
                {
                    if (row.Cells["NgaySinh"].Value.ToString() == null)
                    {
                        txtNgaysinh.Text = "";
                    }
                    else
                    {
                        txtNgaysinh.Text = row.Cells["NgaySinh"].Value.ToString();
                    }
                }
                catch
                {
                    txtNgaysinh.Text = "";
                }
                txtDiachi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDienthoai.Text = row.Cells["DienThoai"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            
            txtDienthoai.Text = "";
            txtEmail.Text = "";
            txtGioitinh.Text = "";
            txtHoten.Text = "";
            txtMakh.Text ="" ;
            txtNgaysinh.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtDiachi.Text = "";
            btnluu.Enabled = true;
            btnThem.Text = "Làm mới";
            btnSua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            long sdt;
            if (txtNgaysinh.Text != "" && txtDiachi.Text != "" && txtDienthoai.Text != "" && txtEmail.Text != "" && txtHoten.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                try
                {
                    if (long.TryParse(txtDienthoai.Text.ToString(), out sdt))
                    {
                        ServiceKhachHang.KhachHang kh = new ServiceKhachHang.KhachHang();
                        kh.MaKH = int.Parse(txtMakh.Text.ToString());
                        kh.Username = txtUsername.Text;
                        kh.Password = txtPassword.Text;
                        kh.Email = txtEmail.Text;
                        kh.HoTen = txtHoten.Text;
                        kh.NgaySinh = DateTime.Parse(txtNgaysinh.Text);
                        kh.DiaChi = txtDiachi.Text;
                        kh.DienThoai = txtDienthoai.Text;
                        if (checkboxNu.Checked == true)
                        {
                            kh.GioiTinh = "Nữ";
                            txtGioitinh.Text = "Nữ";
                        }
                        else
                        {
                            kh.GioiTinh = "Nam";
                            txtGioitinh.Text = "Nam";
                        }
                        if (SVKH.UpdateKhachHang(kh) == 1)
                        {
                            MessageBox.Show("Thêm thành công!");
                        }
                        else MessageBox.Show("Có lỗi xảy ra. Vui lòng thao tác lại!");
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không đúng định dạng!");
                    }

                }
                catch
                {
                    MessageBox.Show("Ngày Sinh không đúng định dạng!");
                }
            }

            else
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ServiceKhachHang.KhachHang kh = (ServiceKhachHang.KhachHang)dataGridView1.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?!?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (SVKH.DeleteKhachHang(kh) == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    showdata();
                }
                else MessageBox.Show("Còn dữ liệu ràng buộc. Không thể xóa!");
            }
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            long sdt;
            if(txtNgaysinh.Text != "" && txtDiachi.Text != "" && txtDienthoai.Text != "" && txtEmail.Text != "" && txtHoten.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                try
                {
                    if(long.TryParse(txtDienthoai.Text.ToString(),out sdt))
                    {
                        ServiceKhachHang.KhachHang kh = new ServiceKhachHang.KhachHang();
                        kh.Username = txtUsername.Text;
                        kh.Password = txtPassword.Text;
                        kh.Email = txtEmail.Text;
                        kh.HoTen = txtHoten.Text;
                        kh.NgaySinh = DateTime.Parse(txtNgaysinh.Text);
                        kh.DiaChi = txtDiachi.Text;
                        kh.DienThoai = txtDienthoai.Text;
                        if (checkboxNu.Checked == true)
                        {
                            kh.GioiTinh = "Nữ";
                            txtGioitinh.Text = "Nữ";
                        }
                        else
                        {
                            kh.GioiTinh = "Nam";
                            txtGioitinh.Text = "Nam";
                        }
                        if (SVKH.InsertKhachHang(kh) == 1)
                        {
                            MessageBox.Show("Thêm thành công!");
                        }
                        else MessageBox.Show("Có lỗi xảy ra. Vui lòng thao tác lại!");
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không đúng định dạng!");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Ngày Sinh không đúng định dạng!");
                }
            }
            
            else
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin!");
            }

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            showdata();
            btnSua.Enabled = true;
            btnThem.Text = "Thêm";
        }
    }
}
