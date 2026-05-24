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
    public partial class ThemNhanVien : Form
    {
        private NhanVienBLL nhanVienBLL;
        public ThemNhanVien()
        {
            InitializeComponent();
            nhanVienBLL = new NhanVienBLL();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                    string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
                    string.IsNullOrWhiteSpace(txtDienThoai.Text) ||
                    string.IsNullOrWhiteSpace(txtChucVu.Text) ||
                    string.IsNullOrWhiteSpace(txtLuong.Text) ||
                    string.IsNullOrWhiteSpace(txtMaRap.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }
                NhanVienDTO nv = new NhanVienDTO
                {
                    HoTen = txtHoTen.Text, 
                    NgaySinh = dateTimePickerNgaySinh.Value, 
                    GioiTinh = txtGioiTinh.Text, 
                    SoDienThoai = txtDienThoai.Text, 
                    ChucVu = txtChucVu.Text, 
                    Luong = int.Parse(txtLuong.Text), 
                    MaRap = int.Parse(txtMaRap.Text) 
                };

                bool result = nhanVienBLL.ThemNhanVien(nv);

                if (result)
                {
                    MessageBox.Show("Thêm nhân viên thành công.");
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
