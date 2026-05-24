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
    public partial class frmHoaDon : Form
    {
        private HoaDonBLL hoaDonBLL;
        public frmHoaDon()
        {
            InitializeComponent();
            hoaDonBLL = new HoaDonBLL();
        }


        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }
        private void LoadDanhSachHoaDon()
        {
            var danhSachHoaDon = hoaDonBLL.LayDanhSachHoaDon();
            dgvHoaDon.DataSource = danhSachHoaDon;

            // Đổi tên cột sang tiếng Việt
            dgvHoaDon.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            dgvHoaDon.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            dgvHoaDon.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvHoaDon.Columns["HinhThucThanhToan"].HeaderText = "Hình Thức Thanh Toán";
            dgvHoaDon.Columns["HoTen"].HeaderText = "Tên Khách Hàng";
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.MultiSelect = false;

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

                int maHoaDon = Convert.ToInt32(row.Cells["MaHoaDon"].Value);
                SuaHoaDon frmSua = new SuaHoaDon(maHoaDon);
                frmSua.ShowDialog(); // Mở form sửa hóa đơn
                LoadDanhSachHoaDon(); // Cập nhật lại danh sách hóa đơn sau khi sửa
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            var danhSachHoaDon = hoaDonBLL.TimKiemHoaDon(keyword);
            dgvHoaDon.DataSource = danhSachHoaDon;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                int maHoaDon = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value); // Lấy mã hóa đơn từ dòng được chọn

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa hóa đơn này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    if (hoaDonBLL.XoaHoaDon(maHoaDon))
                    {
                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachHoaDon(); // Cập nhật lại danh sách sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Xóa hóa đơn không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ThemHoaDon frmThem = new ThemHoaDon();
            frmThem.ShowDialog();
            LoadDanhSachHoaDon();
        }
    }
}
