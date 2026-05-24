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
    public partial class frmSuatChieu : Form
    {
        SuatChieuBLL scBLL = new SuatChieuBLL();
        public frmSuatChieu()
        {
            InitializeComponent();
        }

        private void frmSuatChieu_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            LoadComboBoxNgayChieu();
        }
        private void LoadComboBoxNgayChieu()
        {
            List<SuatChieuDTO> danhSach = scBLL.LayDanhSachSuatChieu();
            var danhSachNgay = danhSach
                .Select(s => s.NgayChieu.Date) 
                .Distinct()
                .OrderBy(d => d)
                .ToList();

            cbbNgayChieu.DataSource = danhSachNgay;
            cbbNgayChieu.FormatString = "dd/MM/yyyy";
        }
        private void HienThiDanhSach()
        {
            dgvSuatChieu.DataSource = scBLL.LayDanhSachSuatChieu();
            dgvSuatChieu.Columns["MaSuatChieu"].HeaderText = "Mã Suất Chiếu";
            dgvSuatChieu.Columns["MaPhim"].HeaderText = "Mã Phim";
            dgvSuatChieu.Columns["MaPhong"].HeaderText = "Mã Phòng";
            dgvSuatChieu.Columns["NgayChieu"].HeaderText = "Ngày Chiếu";
            dgvSuatChieu.Columns["GioChieu"].HeaderText = "Giờ Chiếu";
            dgvSuatChieu.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvSuatChieu.Columns["Tien"].HeaderText = "Tiền";
            dgvSuatChieu.Columns["TenPhim"].HeaderText = "Tên Phim";
            dgvSuatChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuatChieu.MultiSelect = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSuatChieu frm = new ThemSuatChieu();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HienThiDanhSach();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSuatChieu.CurrentRow != null)
            {
                // Lấy thông tin suất chiếu từ dòng được chọn
                SuatChieuDTO sc = new SuatChieuDTO
                {
                    MaSuatChieu = Convert.ToInt32(dgvSuatChieu.CurrentRow.Cells["MaSuatChieu"].Value),
                    MaPhim = Convert.ToInt32(dgvSuatChieu.CurrentRow.Cells["MaPhim"].Value),
                    MaPhong = Convert.ToInt32(dgvSuatChieu.CurrentRow.Cells["MaPhong"].Value),
                    NgayChieu = Convert.ToDateTime(dgvSuatChieu.CurrentRow.Cells["NgayChieu"].Value),
                    GioChieu = (TimeSpan)dgvSuatChieu.CurrentRow.Cells["GioChieu"].Value,
                    TrangThai = dgvSuatChieu.CurrentRow.Cells["TrangThai"].Value.ToString(),
                    Tien = Convert.ToInt32(dgvSuatChieu.CurrentRow.Cells["Tien"].Value),
                };

                // Gọi form sửa suất chiếu với tham số SuatChieuDTO
                SuaSuatChieu frm = new SuaSuatChieu(sc);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    HienThiDanhSach(); // Cập nhật lại danh sách sau khi sửa
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            dgvSuatChieu.DataSource = scBLL.TimKiemSuatChieu(tuKhoa);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                if (dgvSuatChieu.CurrentRow != null)
                {
                    int maSC = Convert.ToInt32(dgvSuatChieu.CurrentRow.Cells["MaSuatChieu"].Value);
                    DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        if (scBLL.XoaSuatChieu(maSC))
                        {
                            MessageBox.Show("Xóa thành công!");
                            HienThiDanhSach();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!");
                        }
                    }
                }
            }
        }

        private void cbbNgayChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNgayChieu.SelectedItem != null)
            {
                DateTime ngayChon = (DateTime)cbbNgayChieu.SelectedItem;
                SuatChieuBLL bll = new SuatChieuBLL();
                var danhSach = bll.LaySuatChieuTheoNgay(ngayChon);
                dgvSuatChieu.DataSource = danhSach;
            }
        }
    }
}
