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
    public partial class SuaVe : Form
    {
        private VeBLL veBLL;
        private VeDTO ve;
        public SuaVe(VeDTO ve)
        {
            InitializeComponent();
            this.ve = ve;
            veBLL = new VeBLL();
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void SuaVe_Load(object sender, EventArgs e)
        {
            if (ve != null)
            {
                txtMaVe.Text = ve.MaVe.ToString();
                txtMaSuatChieu.Text = ve.MaSuatChieu.ToString();
                txtSoGhe.Text = ve.SoGhe; 
                txtMaKhachHang.Text = ve.MaKH.ToString();
                txtLoaiVe.Text = ve.LoaiVe;
                txtGiaVe.Text = ve.GiaVe.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy vé.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string soGhe = txtSoGhe.Text.Trim();
                VeDTO veToUpdate = new VeDTO
                {
                    MaVe = ve.MaVe,
                    MaSuatChieu = int.Parse(txtMaSuatChieu.Text),
                    SoGhe = soGhe,
                    MaKH = int.Parse(txtMaKhachHang.Text),
                    LoaiVe = txtLoaiVe.Text,
                    GiaVe = decimal.Parse(txtGiaVe.Text)
                };

                if (veBLL.SuaVe(veToUpdate)) 
                {
                    MessageBox.Show("Cập nhật vé thành công");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra dữ liệu.");
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
