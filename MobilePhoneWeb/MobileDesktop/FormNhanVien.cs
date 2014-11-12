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
    public partial class FormNhanVien : Form
    {
        ServiceNhanVien.ServiceNhanVienClient obj = new ServiceNhanVien.ServiceNhanVienClient();

        public FormNhanVien()
        {
            InitializeComponent();
            showdata();
        }

        public void showdata()
        {
            dataGridView1.DataSource = obj.SelectNhanVien();
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            ServiceNhanVien.NhanVien objnv = new ServiceNhanVien.NhanVien();
            //cbxQuyen.DataSource = objnv.QuyenNV;
            cbxQuyen.ValueMember = "QuyenNV";
            if(cbxQuyen.ValueMember == "1")
                cbxQuyen.DisplayMember = "Admin";
            else cbxQuyen.DisplayMember = "Nhân viên";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ServiceNhanVien.NhanVien objnv = new ServiceNhanVien.NhanVien();
            objnv.Username = txtUsername.Text;
            objnv.Password = txtPassword.Text;
            objnv.Email = txtEmail.Text;
            objnv.QuyenNV = int.Parse(cbxQuyen.ValueMember);
            obj.InsertNhanVien(objnv);
            showdata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ServiceNhanVien.NhanVien objnv = new ServiceNhanVien.NhanVien();
            objnv.MaNV = (int)dataGridView1.SelectedRows[0].Cells["MaNV"].Value;
            obj.DeleteNhanVien(objnv);
            showdata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ServiceNhanVien.NhanVien objnv = new ServiceNhanVien.NhanVien();
            objnv.MaNV = (int)dataGridView1.SelectedRows[0].Cells["MaNV"].Value;
            objnv.Username = txtPassword.Text;
            objnv.Password = txtUsername.Text;
            objnv.Email = txtEmail.Text;
            objnv.QuyenNV = int.Parse(cbxQuyen.ValueMember);
            obj.UpdateNhanVien(objnv);
            showdata();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cbxQuyen.ValueMember = row.Cells["QuyenNV"].Value.ToString();
                if (cbxQuyen.ValueMember == "1")
                    cbxQuyen.DisplayMember = "Admin";
                else cbxQuyen.DisplayMember = "Nhân viên";
            }
        }
    }
}
