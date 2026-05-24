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
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và mật khẩu.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng.");
                    return;
                }

                TaiKhoann taiKhoan = new TaiKhoann
                {
                    TaiKhoan = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text,
                    MaKH = int.Parse(txtMaKH.Text)
                };
                TaiKhoanBLL bll = new TaiKhoanBLL();
                int result = bll.DangKy(taiKhoan);
                if (result > 0)
                {
                    MessageBox.Show("Tài khoản đã được đăng kí thành công.");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi đăng kí tài khoản.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {

        }
    }
}
