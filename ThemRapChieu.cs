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
    public partial class ThemRapChieu : Form
    {
        private RapChieuBLL rapBLL;
        public ThemRapChieu()
        {
            InitializeComponent();
            rapBLL = new RapChieuBLL();
        }
        private void button1_Click(object sender, EventArgs e)
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

        

        RapChieuDTO rap = new RapChieuDTO
                {
                    TenRap = tenRap,
                    DiaChi = diaChi,
                    DienThoai = soDienThoai,
                    Email = email
                };

                bool success = rapBLL.ThemRapChieu(rap);

                if (success)
                {
                    MessageBox.Show("Thêm rạp chiếu thành công.");
                    this.Close(); // Đóng form khi thành công
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm rạp chiếu.");
                }
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

        private void ThemRapChieu_Load(object sender, EventArgs e)
        {

        }
    }
}
