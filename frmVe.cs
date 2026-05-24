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
    public partial class frmVe : Form
    {
        private VeBLL veBLL = new VeBLL();
        public frmVe()
        {
            InitializeComponent();
            LoadDanhSachVe();
        }
        private void LoadDanhSachVe()
        {

            dgvVe.DataSource = veBLL.HienThiVe();

            dgvVe.Columns["MaVe"].HeaderText = "Mã Vé";
            dgvVe.Columns["MaSuatChieu"].HeaderText = "Mã Suất Chiếu";
            dgvVe.Columns["SoGhe"].HeaderText = "Số Ghế";
            dgvVe.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            dgvVe.Columns["HoTen"].HeaderText = "Tên Khách Hàng";
            dgvVe.Columns["MaPhong"].HeaderText = "Mã Phòng";
            dgvVe.Columns["LoaiVe"].HeaderText = "Loại Vé";
            dgvVe.Columns["GiaVe"].HeaderText = "Giá Vé";
            dgvVe.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvVe.Columns["NgayDat"].HeaderText = "Ngày Đặt";
            dgvVe.Columns["TenPhim"].HeaderText = "Tên Phim";
            dgvVe.Columns["GioChieu"].HeaderText = "Giờ Chiếu";
            dgvVe.Columns["TenRap"].HeaderText = "Tên Rạp";


            dgvVe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVe.MultiSelect = false;
        }

        private void frmVe_Load(object sender, EventArgs e)
        {
            LoadDanhSachVe();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            dgvVe.DataSource = veBLL.TimKiemVe(tuKhoa);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvVe.SelectedRows.Count > 0)
            {
                int maVe = Convert.ToInt32(dgvVe.SelectedRows[0].Cells["MaVe"].Value);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa vé này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    veBLL.XoaVe(maVe);
                    LoadDanhSachVe();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vé để xóa.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemVe f = new ThemVe();
            f.FormClosed += (s, args) => LoadDanhSachVe();
            f.ShowDialog();
        }

     

        private void dgvVe_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void dgvVe_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvVe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var maVe = (int)dgvVe.Rows[e.RowIndex].Cells["MaVe"].Value;
                var maSuatChieu = (int)dgvVe.Rows[e.RowIndex].Cells["MaSuatChieu"].Value;
                var soGhe = dgvVe.Rows[e.RowIndex].Cells["SoGhe"].Value.ToString();
                var maKH = (int)dgvVe.Rows[e.RowIndex].Cells["MaKH"].Value;
                var loaiVe = dgvVe.Rows[e.RowIndex].Cells["LoaiVe"].Value.ToString();
                var giaVe = (decimal)dgvVe.Rows[e.RowIndex].Cells["GiaVe"].Value;
                var gioChieu = (TimeSpan)dgvVe.Rows[e.RowIndex].Cells["GioChieu"].Value;

                VeDTO ve = new VeDTO
                {
                    MaVe = maVe,
                    MaSuatChieu = maSuatChieu,
                    SoGhe = soGhe,
                    MaKH = maKH,
                    LoaiVe = loaiVe,
                    GiaVe = giaVe,
                };

                SuaVe frm = new SuaVe(ve);
                frm.ShowDialog();
                LoadDanhSachVe();
            }
        }
    }
}
    

