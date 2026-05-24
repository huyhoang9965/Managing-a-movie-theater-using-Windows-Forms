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
    public partial class ThemPhongChieu : Form
    {
        private PhongChieuBLL phongChieuBLL;
        public ThemPhongChieu()
        {
            InitializeComponent();
            phongChieuBLL = new PhongChieuBLL();
        }

        private void ThemPhongChieu_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PhongChieuDTO pc = new PhongChieuDTO
                {
                    LoaiPhong = txtLoaiPhong.Text,
                    TenPhong = txtTenPhong.Text,
                    TrangThai = txtTrangThai.Text,
                    MaRap = int.Parse(txtMaRap.Text)
                };
                bool result = phongChieuBLL.ThemPhongChieu(pc);

                if (result)
                {
                    MessageBox.Show("Thêm phòng chiếu thành công.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm phòng chiếu thất bại.");
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
