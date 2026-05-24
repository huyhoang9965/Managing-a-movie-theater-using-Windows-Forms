using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmChieu : Form
    {
        private SuatChieuBLL suatChieuBLL = new SuatChieuBLL();
        private int maPhim;

        public frmChieu(int maPhimInput)
        {
            InitializeComponent();
            maPhim = maPhimInput;
        }

        private void frmChieu_Load(object sender, EventArgs e)
        {
            flpSuatChieu.Dock = DockStyle.Fill;
            HienThiSuatChieu();
        }

        private void HienThiSuatChieu()
        {
            flpSuatChieu.Controls.Clear();

            List<SuatChieuDTO> danhSach = suatChieuBLL.TimKiemSuatChieuTheoMaPhim(maPhim);

            if (danhSach.Count == 0)
            {
                MessageBox.Show("Không có suất chiếu nào cho phim này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var sc in danhSach)
            {
                Panel panelSC = new Panel
                {
                    Width = flpSuatChieu.ClientSize.Width - 25,
                    Height = 180,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.WhiteSmoke,
                    Margin = new Padding(10)
                };

                PictureBox pic = new PictureBox
                {
                    Width = 120,
                    Height = 160,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Left = 10,
                    Top = 10
                };

                string posterPath = Path.Combine(Application.StartupPath, "Phim", sc.Poster);
                pic.Image = File.Exists(posterPath) ? Image.FromFile(posterPath) : Properties.Resources.ANHBIA_;
                panelSC.Controls.Add(pic);

                Label lblInfo = new Label
                {
                    AutoSize = false,
                    Left = 140,
                    Top = 10,
                    Width = 400, // tăng lên nếu form bạn to
                    Height = 100,
                    Font = new Font("Segoe UI", 10),
                    Text = $"Tên phim: {sc.TenPhim}\nMã SC: {sc.MaSuatChieu}\nNgày: {sc.NgayChieu:dd/MM/yyyy}\nGiờ: {sc.GioChieu}\nGiá: {sc.Tien:N0} VNĐ\nTrạng thái: {sc.TrangThai}"
                };
                panelSC.Controls.Add(lblInfo);

                Button btnDatVe = new Button
                {
                    Text = "Đặt vé",
                    Width = 100,
                    Height = 30,
                    Left = 140,
                    Top = 120,
                    BackColor = Color.MediumSeaGreen,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold)
                };
                int maPhong = sc.MaPhong; 
                int maSuatChieu = sc.MaSuatChieu;  

                btnDatVe.Click += (sender, e) =>
                {
                    DanhSachPhongGhe frm = new DanhSachPhongGhe(maSuatChieu,maPhong);
                    frm.ShowDialog();
                };

                panelSC.Controls.Add(btnDatVe);
                flpSuatChieu.Controls.Add(panelSC);
            }
        }
    }
}
