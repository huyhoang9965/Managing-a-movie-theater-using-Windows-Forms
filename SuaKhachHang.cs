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
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class SuaKhachHang : Form
    {
        private KhachHangDTO khachHang;
        private KhachHangBLL khBLL = new KhachHangBLL();
        public SuaKhachHang(KhachHangDTO kh)
        {
            InitializeComponent();
            khachHang = kh;
            txtMaKhachHang.Text = kh.MaKH.ToString();
            txtHoTen.Text = kh.HoTen;
            txtEmail.Text = kh.Email;
            txtSoDienThoai.Text = kh.SoDienThoai;
        }

        private void SuaKhachHang_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = khachHang.HoTen;
            txtEmail.Text = khachHang.Email;
            txtSoDienThoai.Text = khachHang.SoDienThoai;
        }
        private bool KiemTraDuLieuNhap()
        {
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Họ tên không được để trống!");
                txtHoTen.Focus();
                return false;
            }

            if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0!");
                txtSoDienThoai.Focus();
                return false;
            }

            if (!Regex.IsMatch(email, @"^[\w\.\-]+@gmail\.com$"))
            {
                MessageBox.Show("Email phải có định dạng @gmail.com!");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
                return;

            khachHang.HoTen = txtHoTen.Text.Trim();
            khachHang.Email = txtEmail.Text.Trim();
            khachHang.SoDienThoai = txtSoDienThoai.Text.Trim();

            if (khBLL.SuaKhachHang(khachHang))
            {
                MessageBox.Show("Cập nhật khách hàng thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
