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
using System.Data.SqlClient;

namespace GUI
{
    public partial class SuaSuatChieu : Form
    {
        private SuatChieuBLL scBLL = new SuatChieuBLL();
        private SuatChieuDTO _suatChieu;
        private SuatChieuBLL _scBLL = new SuatChieuBLL();

        // Constructor nhận đối tượng SuatChieuDTO
        public SuaSuatChieu(SuatChieuDTO suatChieu)
        {
            InitializeComponent();
            _suatChieu = suatChieu;
        }

        private void SuaSuatChieu_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin suất chiếu vào các điều khiển trên form
            txtMaSuatChieu.Text = _suatChieu.MaSuatChieu.ToString();
            txtMaPhim.Text = _suatChieu.MaPhim.ToString();
            txtMaPhong.Text = _suatChieu.MaPhong.ToString();
            datetimeNgayChieu.Value = _suatChieu.NgayChieu;
            datetimeGioChieu.Value = DateTime.Today.Add(_suatChieu.GioChieu);
            txtTien.Text = _suatChieu.Tien.ToString();
            txtTrangThai.Text = _suatChieu.TrangThai;
        }

        // Lưu thông tin sau khi sửa
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                SuatChieuDTO sc = new SuatChieuDTO
                {
                    MaSuatChieu = _suatChieu.MaSuatChieu, // Chỉ khác ở dòng này để biết đang sửa suất nào
                    MaPhim = Convert.ToInt32(txtMaPhim.Text),
                    MaPhong = Convert.ToInt32(txtMaPhong.Text),
                    NgayChieu = datetimeNgayChieu.Value.Date,
                    GioChieu = datetimeGioChieu.Value.TimeOfDay,
                    TrangThai = txtTrangThai.Text,
                    Tien = Convert.ToInt32(txtTien.Text)
                };

                if (scBLL.SuaSuatChieu(sc))
                {
                    MessageBox.Show("Cập nhật suất chiếu thành công");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra dữ liệu.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}