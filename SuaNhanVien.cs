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
    public partial class SuaNhanVien : Form
    {
        private NhanVienBLL nhanVienBLL;
        private int maNV;
        public SuaNhanVien(int maNV)
        {
            InitializeComponent();
            nhanVienBLL = new NhanVienBLL();
            this.maNV = maNV;
        }

        private void SuaNhanVien_Load(object sender, EventArgs e)
        {
            NhanVienDTO nv = nhanVienBLL.LayNhanVienByMaNV(maNV);
            if (nv != null)
            {
                txtMaNV.Text = nv.MaNV.ToString();
                txtHoTen.Text = nv.HoTen;
                dateTimePickerNgaySinh.Value = nv.NgaySinh;
                txtGioiTinh.Text = nv.GioiTinh;
                txtDienThoai.Text = nv.SoDienThoai;
                txtChucVu.Text = nv.ChucVu;
                txtLuong.Text = nv.Luong.ToString();
                txtMaRap.Text = nv.MaRap.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
                // Tạo đối tượng nhân viên với thông tin sửa
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = maNV,
                    HoTen = txtHoTen.Text,
                    NgaySinh = dateTimePickerNgaySinh.Value,
                    GioiTinh = txtGioiTinh.Text,
                    SoDienThoai = txtDienThoai.Text,
                    ChucVu = txtChucVu.Text,
                    Luong = int.Parse(txtLuong.Text),  
                    MaRap = int.Parse(txtMaRap.Text)
                };

                bool result = nhanVienBLL.SuaNhanVien(nv);

                if (result)
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin nhân viên thất bại.");
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

