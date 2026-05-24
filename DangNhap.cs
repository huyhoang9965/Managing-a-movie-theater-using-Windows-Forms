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
    public partial class DangNhap : Form
    {
        TaiKhoanBLL bll = new TaiKhoanBLL();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenTK = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.");
                return;
            }

            TaiKhoann tk = bll.DangNhap(tenTK, matKhau);
            if (tk != null)
            {
                MessageBox.Show("Đăng nhập thành công!");

                this.Hide();

                switch (tk.MaQuyen)
                {
                    case 1:
                        new frmNguoiDung(tk.MaTK).ShowDialog();
                        break;
                    case 2:
                        new frmNguoiDung(tk.MaTK).ShowDialog();
                        break;
                    case 3:
                        new QuanLyRapChieuPhim().ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Quyền không hợp lệ!");
                        break;
                }

                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            List<string> gheChon = new List<string>();
            int maSuatChieu = 1;

            ThemKhachHang frm = new ThemKhachHang(gheChon, maSuatChieu);
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }

        }

    }
}
