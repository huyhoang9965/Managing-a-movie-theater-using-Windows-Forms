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
    public partial class SuaPhongChieu : Form
    {
        private PhongChieuBLL phongChieuBLL;
        private int maPhong;
        public SuaPhongChieu(int maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            phongChieuBLL = new PhongChieuBLL();
        }

        private void SuaPhongChieu_Load(object sender, EventArgs e)
        {
            {
                var phongChieu = phongChieuBLL.LayPhongChieuByMaPC(maPhong); // Lấy thông tin phòng chiếu theo mã

                if (phongChieu != null)
                {
                    txtMaPhong.Text = phongChieu.MaPhong.ToString();
                    txtTenPhong.Text = phongChieu.TenPhong;
                    txtLoaiPhong.Text = phongChieu.LoaiPhong;
                    txtTrangThai.Text = phongChieu.TrangThai;
                    txtMaRap.Text = phongChieu.MaRap.ToString(); 
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng chiếu.");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng nhân viên với thông tin sửa
                PhongChieuDTO pc = new PhongChieuDTO
                {
                    MaPhong = maPhong,
                    LoaiPhong = txtLoaiPhong.Text,
                    TenPhong = txtTenPhong.Text,
                    TrangThai = txtTrangThai.Text,
                    MaRap = int.Parse(txtMaRap.Text)
                };
                bool result = phongChieuBLL.SuaPhongChieu(pc);
                if (result)
                {
                    MessageBox.Show("Sửa thông tin phòng chiếu thành công.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin phòng chiếu thất bại.");
                }
            }
            catch (SqlException ex)
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
