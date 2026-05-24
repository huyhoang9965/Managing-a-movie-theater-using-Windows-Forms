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

    public partial class frmRapChieu : Form
    {
        private RapChieuBLL rapBLL;
        public frmRapChieu()
        {
            InitializeComponent();
            rapBLL = new RapChieuBLL();
        }

        private void frmRapChieu_Load(object sender, EventArgs e)
        {
            LoadDanhSachRapChieu();
        }
        private void LoadDanhSachRapChieu()
        {
            List<RapChieuDTO> danhSachRap = rapBLL.LayDanhSachRap();
            dgvRapChieu.DataSource = danhSachRap;
            dgvRapChieu.Columns["MaRap"].HeaderText = "Mã Rạp";
            dgvRapChieu.Columns["TenRap"].HeaderText = "Tên Rạp";
            dgvRapChieu.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvRapChieu.Columns["DienThoai"].HeaderText = "Điện Thoại";
            dgvRapChieu.Columns["Email"].HeaderText = "Email";
            dgvRapChieu.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dgvRapChieu.Columns["NguoiTao"].HeaderText = "Người Tạo";
            dgvRapChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRapChieu.MultiSelect = false;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemRapChieu frm = new ThemRapChieu();
            frm.ShowDialog();
            LoadDanhSachRapChieu();
        }

        private void dgvRapChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        private void dgvRapChieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maRap = Convert.ToInt32(dgvRapChieu.Rows[e.RowIndex].Cells["MaRap"].Value);

                RapChieuDTO rap = rapBLL.LayRapByMa(maRap);
                SuaRapChieu frmSua = new SuaRapChieu(maRap, rap);
                frmSua.ShowDialog();
                LoadDanhSachRapChieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvRapChieu.SelectedRows.Count > 0)
            {
                int maRap = Convert.ToInt32(dgvRapChieu.SelectedRows[0].Cells["MaRap"].Value);
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa rạp này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool thanhCong = rapBLL.XoaRapChieu(maRap);
                    if (thanhCong)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadDanhSachRapChieu(); ;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn rạp cần xóa!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                dgvRapChieu.DataSource = rapBLL.TimKiemRapChieu(tuKhoa);
            }
            else
            {
                LoadDanhSachRapChieu(); 
            }
        }

        private void dgvRapChieu_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
