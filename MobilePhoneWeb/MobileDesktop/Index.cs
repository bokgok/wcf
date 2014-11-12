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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýSảnPhẩnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromThongKeHoaDon fr = new FromThongKeHoaDon();
            fr.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSanPham fr = new FormSanPham();
            fr.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang fr = new FormKhachHang();
            fr.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien fr = new FormNhanVien();
            fr.Show();
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemSP fr = new FormThemSP();
            fr.Show();
        }

        private void NhaPhanPhoi_Click(object sender, EventArgs e)
        {
            FormNhaPhanPhoi fr = new FormNhaPhanPhoi();
            fr.Show();
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhaSanXuat fr = new FormNhaSanXuat();
            fr.Show();
        }

       
    }
}
