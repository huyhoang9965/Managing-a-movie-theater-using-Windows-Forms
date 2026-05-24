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
    public partial class SuaHoaDon : Form
    {
        private HoaDonBLL hoaDonBLL;
        private int maHoaDon;
        public SuaHoaDon(int maHoaDon)
        {
            InitializeComponent();
            hoaDonBLL = new HoaDonBLL();
            this.maHoaDon = maHoaDon;
        }

        private void SuaHoaDon_Load(object sender, EventArgs e)
        {
            {
                HoaDonDTO hoaDon = hoaDonBLL.LayHoaDonTheoMa(maHoaDon);
                if (hoaDon != null)
                {
                    txtMaHoaDon.Text = hoaDon.MaHoaDon.ToString();
                    txtMaKhachHang.Text = hoaDon.MaKH.ToString();
                    txtTongTien.Text = hoaDon.TongTien.ToString();
                    txtHinhThuc.Text = hoaDon.HinhThucThanhToan;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn.");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int maKH = Convert.ToInt32(txtMaKhachHang.Text);
                int tongTien = Convert.ToInt32(txtTongTien.Text);
                string hinhThucThanhToan = txtHinhThuc.Text;

                HoaDonDTO hoaDon = new HoaDonDTO
                {
                    MaHoaDon = maHoaDon,
                    MaKH = maKH,
                    TongTien = tongTien,
                    HinhThucThanhToan = hinhThucThanhToan
                };

                if (hoaDonBLL.SuaHoaDon(hoaDon))
                {
                    MessageBox.Show("Sửa hóa đơn thành công!");
                    this.Close(); // Đóng form sửa hóa đơn
                }
                else
                {
                    MessageBox.Show("Sửa hóa đơn không thành công.");
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
