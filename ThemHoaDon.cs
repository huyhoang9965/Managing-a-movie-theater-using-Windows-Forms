using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class ThemHoaDon : Form
    {
        private HoaDonBLL hoaDonBLL;
        public ThemHoaDon()
        {
            InitializeComponent();
            hoaDonBLL = new HoaDonBLL();
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int maKH = Convert.ToInt32(txtMaKhachHang.Text);
                int tongTien = Convert.ToInt32(txtTongTien.Text);
                string hinhThucThanhToan = txtTongTien.Text;

                HoaDonDTO hoaDon = new HoaDonDTO
                {
                    MaKH = maKH,
                    TongTien = tongTien,
                    HinhThucThanhToan = hinhThucThanhToan
                };

                if (hoaDonBLL.ThemHoaDon(hoaDon))
                {
                    MessageBox.Show("Thêm hóa đơn thành công!");
                    this.Close(); // Đóng form thêm hóa đơn
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn không thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
