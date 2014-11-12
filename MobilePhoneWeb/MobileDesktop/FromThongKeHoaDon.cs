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
    public partial class FromThongKeHoaDon : Form
    {

        ServiceDonHang.ServiceDonHangClient svdh = new ServiceDonHang.ServiceDonHangClient();
        ServiceDonHang.CT_DonHang ctdh = new ServiceDonHang.CT_DonHang();

        public FromThongKeHoaDon()
        {
            InitializeComponent();
            loadNowTime();
//            loadChangeTime();
        }
        private void loadNowTime()
        {
            DateTime dt = DateTime.Now;
            string txt = dt.ToString();
            
            txtNgay1.Text = "01/" + dt.Month.ToString() + "/" + dt.Year.ToString();
            txtNgay2.Text = dt.ToShortDateString();
                //dt.Day.ToString() + "/" + dt.Month.ToString() + "/" + dt.Year.ToString();
            
        }

        private void loadChangeTime()
        {
            long tong = 0;
            dataGridView1.Rows.Clear();
            DateTime _ngay1 = DateTime.Parse(txtNgay1.Text);
            String Ngay1 = _ngay1.ToShortDateString();
               // _ngay1.Day + "/" + _ngay1.Month + "/" + _ngay1.Year;
                //_ngay1.Year + "-" + _ngay1.Month + "-" + _ngay1.Day;
            DateTime _ngay2 = DateTime.Parse(txtNgay2.Text);
            String Ngay2 = _ngay2.ToShortDateString();
                //_ngay2.Year + "/" + _ngay2.Month + "/" + _ngay2.Day;

            var dt = svdh.BaocaoTheongay(Ngay1, Ngay2);
            foreach (var a in dt)
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count.ToString(),
                    a.MaDH, a.TenKH, a.Ngay,a.Sdt,a.Diachigiao,a.Trigia,a.TinhTrang);
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                tong = tong + long.Parse((a.Trigia).ToString());
            }
            //dataGridView1.DataSource = svdh.BaocaoTheongay(Ngay1, Ngay2);
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            lbTongtien.Text = tong.ToString();
        }

        private void txtNgay1_TextChanged(object sender, EventArgs e)
        {
            if(txtNgay2.Text != "")
            {
                loadChangeTime();
            }
        }

        private void txtNgay2_TextChanged(object sender, EventArgs e)
        {
            if(txtNgay1.Text != "")
            {
                loadChangeTime();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtNgay1.Text = dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtNgay2.Text = dateTimePicker2.Value.Month.ToString() + "/" + dateTimePicker2.Value.Day.ToString() + "/" + dateTimePicker2.Value.Year.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
//            DateTime dt = DateTime.Now;
//            textBox1.Text = dt.ToString();
        }

        private void btnXuatbaocao_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            loadChangeTime();
        }
    }
}
