using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        private NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }
        private void LoadDanhSachNhanVien()
        {
            dgvNhanVien.DataSource = nhanVienBLL.HienThiNhanVien();
            dgvNhanVien.Columns["MaNV"].HeaderText = "Mã NV";
            dgvNhanVien.Columns["HoTen"].HeaderText = "Họ tên";
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvNhanVien.Columns["SoDienThoai"].HeaderText = "SĐT";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
            dgvNhanVien.Columns["Luong"].HeaderText = "Lương";
            dgvNhanVien.Columns["MaRap"].HeaderText = "Mã rạp";
            dgvNhanVien.Columns["TenRap"].HeaderText = "Tên rạp";
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.MultiSelect = false;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maNV = Convert.ToInt32(dgvNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value);
                SuaNhanVien formSua = new SuaNhanVien(maNV);
                formSua.ShowDialog();
                LoadDanhSachNhanVien(); 
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text.Trim();
            dgvNhanVien.DataSource = nhanVienBLL.TimKiemNhanVien(tukhoa);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                int maNV = Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells["MaNV"].Value);
                var result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (nhanVienBLL.XoaNhanVien(maNV))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadDanhSachNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa");
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ThemNhanVien frm = new ThemNhanVien();
            frm.ShowDialog();
            LoadDanhSachNhanVien();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

