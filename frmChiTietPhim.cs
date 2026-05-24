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
using System.IO;
using BLL;


namespace GUI
{
    public partial class frmChiTietPhim : Form
    {
        private PhimDTO phim;
        private PhimDTO phimHienTai;

        public frmChiTietPhim(PhimDTO _phim)
        {
            InitializeComponent();
            phim = _phim;
            LoadChiTietPhim();
            phimHienTai = phim;
        }

        private void LoadChiTietPhim()
        {
            // Hiển thị thông tin phim ra các textbox
            txtMaPhim.Text = phim.MaPhim.ToString();
            txtTenPhim.Text = phim.TenPhim;
            txtTheLoai.Text = phim.TheLoai;
            txtDaoDien.Text = phim.DaoDien;
            txtDienVien.Text = phim.DienVien;
            txtThoiLuong.Text = phim.ThoiLuong.ToString() + " phút";
            txtNgayKhoiChieu.Text = phim.NgayKhoiChieu.ToString("dd/MM/yyyy");
            txtMoTa.Text = phim.MoTa;

            try
            {
                string duongDanPoster = Path.Combine(Application.StartupPath, "Phim", phim.Poster);
                if (File.Exists(duongDanPoster))
                {
                    pictureBoxPoster.Image = Image.FromFile(duongDanPoster);
                    pictureBoxPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load ảnh: " + ex.Message);
            }
        }
        private void frmChiTietPhim_Load(object sender, EventArgs e)
        {
        }

        private void btnXemSuatChieu_Click(object sender, EventArgs e)
        {
            int maPhim = Convert.ToInt32(txtMaPhim.Text); 
            frmChieu form = new frmChieu(maPhim);
            form.ShowDialog();
        }
    }
}
