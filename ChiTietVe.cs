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
    public partial class ChiTietVe : Form
    {
        private VeBLL veBLL = new VeBLL();
        private int maTK;
        public ChiTietVe(int maTK)
        {
            InitializeComponent();
            this.maTK = maTK;
        }

        private void ChiTietVe_Load(object sender, EventArgs e)
        {
            HienThiVeTheoTaiKhoan();
        }
        private void HienThiVeTheoTaiKhoan()
        {
            try
            {
                List<VeDTO> danhSachVe = veBLL.LayVeTheoMaTK(maTK);
                dgvChiTietVe.DataSource = danhSachVe;
        

                dgvChiTietVe.Columns["MaVe"].HeaderText = "Mã Vé";
                dgvChiTietVe.Columns["MaSuatChieu"].HeaderText = "Mã Suất Chiếu";
                dgvChiTietVe.Columns["SoGhe"].HeaderText = "Số Ghế";
                dgvChiTietVe.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
                dgvChiTietVe.Columns["HoTen"].HeaderText = "Tên Khách Hàng";
                dgvChiTietVe.Columns["MaPhong"].HeaderText = "Mã Phòng";
                dgvChiTietVe.Columns["LoaiVe"].HeaderText = "Loại Vé";
                dgvChiTietVe.Columns["GiaVe"].HeaderText = "Giá Vé";
                dgvChiTietVe.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvChiTietVe.Columns["NgayDat"].HeaderText = "Ngày Đặt";
                dgvChiTietVe.Columns["TenPhim"].HeaderText = "Tên Phim";
                dgvChiTietVe.Columns["GioChieu"].HeaderText = "Giờ Chiếu";
                dgvChiTietVe.Columns["TenRap"].HeaderText = "Tên Rạp";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải vé: " + ex.Message);
            }
        }
    }
}

