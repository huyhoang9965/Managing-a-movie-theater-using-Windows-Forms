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
    public partial class frmKhachHang : Form
    {
        private KhachHangBLL khBLL = new KhachHangBLL();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
        private void LoadKhachHang()
        {
            dgvKhachHang.DataSource = khBLL.LayDanhSachKhachHang();
            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
            dgvKhachHang.Columns["HoTen"].HeaderText = "Họ tên";
            dgvKhachHang.Columns["Email"].HeaderText = "Email";
            dgvKhachHang.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvKhachHang.Columns["NgayDangKy"].HeaderText = "Ngày đăng ký";
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.MultiSelect = false;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }


        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KhachHangDTO kh = new KhachHangDTO
                {
                    MaKH = Convert.ToInt32(dgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value),
                    HoTen = dgvKhachHang.Rows[e.RowIndex].Cells["HoTen"].Value.ToString(),
                    Email = dgvKhachHang.Rows[e.RowIndex].Cells["Email"].Value.ToString(),
                    SoDienThoai = dgvKhachHang.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString(),
                    NgayDangKy = Convert.ToDateTime(dgvKhachHang.Rows[e.RowIndex].Cells["NgayDangKy"].Value)
                };

                SuaKhachHang frm = new SuaKhachHang(kh);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadKhachHang();
                }
                LoadKhachHang();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            dgvKhachHang.DataSource = khBLL.TimKiemKhachHang(tuKhoa);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                int maKH = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["MaKH"].Value);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (khBLL.XoaKhachHang(maKH))
                    {
                        MessageBox.Show("Xóa thành công.");
                        LoadKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            List<string> gheChon = new List<string>();
            int maSuatChieu = 1;

            ThemKhachHang frm = new ThemKhachHang(gheChon, maSuatChieu);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHang();
            }
            LoadKhachHang();
        }
    }
}
