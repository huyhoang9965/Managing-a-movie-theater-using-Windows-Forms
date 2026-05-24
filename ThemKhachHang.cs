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
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class ThemKhachHang : Form
    {

        private List<string> gheChon;
        private int tongTien;
        private KhachHangBLL khBLL = new KhachHangBLL();

        public ThemKhachHang(List<string> gheChon, int tongTien)
        {
            InitializeComponent();
            this.gheChon = gheChon;
            this.tongTien = tongTien;
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {

        }
        private bool KiemTraDuLieuNhap()
        {
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Họ tên không được để trống");
                txtHoTen.Focus();
                return false;
            }

            if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0");
                txtSoDienThoai.Focus();
                return false;
            }

            if (!Regex.IsMatch(email, @"^[\w\.\-]+@gmail\.com$"))
            {
                MessageBox.Show("Email phải có định dạng @gmail.com");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
                return;

            KhachHangDTO kh = new KhachHangDTO
            {
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim()
            };

            if (khBLL.ThemKhachHang(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
            frmDangKi frm = new frmDangKi();
            frm.ShowDialog();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

