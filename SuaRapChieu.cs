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
    public partial class SuaRapChieu : Form
    {
        private int maRap;
        private RapChieuDTO rap;
        private RapChieuBLL rapBLL = new RapChieuBLL();

        public SuaRapChieu(int maRap, RapChieuDTO rap)
        {
            InitializeComponent();
            this.maRap = maRap;
            this.rap = rap;

            // Gán thông tin lên các textbox
            txtMaRap.Text = maRap.ToString();
            txtTenRap.Text = rap.TenRap;
            txtDiaChi.Text = rap.DiaChi;
            txtDienThoai.Text = rap.DienThoai;
            txtEmail.Text = rap.Email;
        }

        public SuaRapChieu(int maRap)
        {
            this.maRap = maRap;
        }

        private void SuaRapChieu_Load(object sender, EventArgs e)
        {
            RapChieuDTO rap = new RapChieuDTO
            {
                MaRap = maRap,
                TenRap = txtTenRap.Text,
                DiaChi = txtDiaChi.Text,
                DienThoai = txtDienThoai.Text,
                Email = txtEmail.Text
            };
            rapBLL.SuaRapChieu(maRap, rap);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenRap = txtTenRap.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soDienThoai = txtDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Kiểm tra tên rạp không được để trống
            if (string.IsNullOrEmpty(tenRap))
            {
                MessageBox.Show("Tên rạp không được để trống.");
                return;
            }

            // Kiểm tra địa chỉ không được để trống
            if (string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Địa chỉ không được để trống.");
                return;
            }

            // Kiểm tra số điện thoại phải có 10 ký tự và bắt đầu bằng số 0
            if (soDienThoai.Length != 10 || !soDienThoai.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải có 10 ký tự và bắt đầu bằng số 0.");
                return;
            }

            // Kiểm tra email có định dạng @gmail.com
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email phải có định dạng '@gmail.com'.");
                return;
            }
            RapChieuDTO rapMoi = new RapChieuDTO
            {
                MaRap = this.maRap,
                TenRap = txtTenRap.Text,
                DiaChi = txtDiaChi.Text,
                DienThoai = txtDienThoai.Text,
                Email = txtEmail.Text
            };

            RapChieuBLL bll = new RapChieuBLL();
            bll.SuaRapChieu(this.maRap, rapMoi);

            MessageBox.Show("Cập nhật thành công!");
            this.Close();
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
