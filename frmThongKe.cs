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


namespace GUI
{
    public partial class frmThongKe : Form
    {
        private ThongKeBLL thongKeBLL = new ThongKeBLL();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnNgay_Click(object sender, EventArgs e)
        {
            DataTable dt = thongKeBLL.ThongKeDoanhThuTheoNgay();
            dgvThongKe.DataSource = dt;
            dgvThongKe.Columns["Ngay"].HeaderText = "Ngày";
            dgvThongKe.Columns["TongDoanhThu"].HeaderText = "Tổng Doanh Thu";
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            DataTable dt = thongKeBLL.ThongKeDoanhThuTheoThang();
            dgvThongKe.DataSource = dt;
            dgvThongKe.Columns["Nam"].HeaderText = "Năm";
            dgvThongKe.Columns["Thang"].HeaderText = "Tháng";
            dgvThongKe.Columns["TongDoanhThu"].HeaderText = "Tổng Doanh Thu";
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            DataTable dt = thongKeBLL.ThongKeDoanhThuTheoNam();
            dgvThongKe.DataSource = dt;
            dgvThongKe.Columns["Nam"].HeaderText = "Năm";
            dgvThongKe.Columns["TongDoanhThu"].HeaderText = "Tổng Doanh Thu";
        }

        private void btnTheoPhim_Click(object sender, EventArgs e)
        {
            DataTable dt = thongKeBLL.ThongKeDoanhThuTheoPhim();
            dgvThongKe.DataSource = dt;
            dgvThongKe.Columns["MaPhim"].HeaderText = "Mã Phim";
            dgvThongKe.Columns["TenPhim"].HeaderText = "Tên Phim";
            dgvThongKe.Columns["TongDoanhThu"].HeaderText = "Tổng Doanh Thu";
            dgvThongKe.Columns["SoLuongVe"].HeaderText = "Số Lượng Vé";

        }

        private void btnTheoSuatChieu_Click(object sender, EventArgs e)
        {
            DataTable dt = thongKeBLL.ThongKeSoVeTheoSuatChieu();
            dgvThongKe.DataSource = dt;
            dgvThongKe.Columns["MaSuatChieu"].HeaderText = "Mã Suất Chiếu";
            dgvThongKe.Columns["TenPhim"].HeaderText = "Tên Phim";
            dgvThongKe.Columns["NgayChieu"].HeaderText = "Ngày Chiếu";
            dgvThongKe.Columns["GioChieu"].HeaderText = "Giờ Chiếu";
            dgvThongKe.Columns["SoVeDaBan"].HeaderText = "Số Vé Đã Bán";
            
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            DataTable dtNgay = thongKeBLL.LayDanhSachNgayChieu();
            cbbNgayChieu.DataSource = dtNgay;
            cbbNgayChieu.DisplayMember = "Ngay"; 
            cbbNgayChieu.ValueMember = "Ngay";   
            cbbNgayChieu.SelectedIndex = -1;

            
        }

        private void cbbNgayChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNgayChieu.SelectedIndex != -1)
            {
                // Lấy giá trị Ngay từ DataRowView
                DataRowView selectedRow = cbbNgayChieu.SelectedItem as DataRowView;
                DateTime ngayChon = Convert.ToDateTime(selectedRow["Ngay"]);

                // Lấy thống kê suất chiếu theo ngày
                DataTable dt = thongKeBLL.ThongKeSoLuongSuatChieuTheoPhim(ngayChon);
                dgvThongKe.DataSource = dt;
                dgvThongKe.Columns["SoLuongSuatChieu"].HeaderText = "Số Lượng Suất Chiếu";
            }
        }

        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            frmBieuDo frm = new frmBieuDo();
            frm.Show();
        }
    }
}
