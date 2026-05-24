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
    public partial class ThemVe : Form
    {
        private VeBLL veBLL = new VeBLL();
        public ThemVe()
        {
            InitializeComponent();
        }

        private void ThemVe_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                VeDTO ve = new VeDTO
                {
                    MaSuatChieu = int.Parse(txtMaSuatChieu.Text),
                    SoGhe = txtSoGhe.Text,
                    MaKH = int.Parse(txtMaKhachHang.Text),
                    LoaiVe = txtLoaiVe.Text,
                    GiaVe = decimal.Parse(txtGiaVe.Text) 
                };

                veBLL.ThemVe(ve);
                MessageBox.Show("Thêm vé thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
