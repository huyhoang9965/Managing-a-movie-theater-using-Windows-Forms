using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class DanhSachPhongGhe : Form
    {
        private SuatChieuBLL suatChieuBLL;
        private GheBLL gheBLL;
        private List<string> danhSachGheChon = new List<string>();
        private List<GheDTO> danhSachGhe;
        private int tongTien = 0;
        private int tienPhaiTra = 0;
        private int khuyenMai = 0;
        private int giaVe = 0;
        private int maSuat;
        private int maPhong;
        private string loaiVe;
        private KhachHangBLL khachHangBLL = new KhachHangBLL();

        public DanhSachPhongGhe(int maSuatChieu, int maPhong)
        {
            InitializeComponent();
            this.maSuat = maSuatChieu;
            this.maPhong = maPhong;
            gheBLL = new GheBLL();
            suatChieuBLL = new SuatChieuBLL();
        }

        private void DanhSachPhongGhe_Load(object sender, EventArgs e)
        {
            danhSachGhe = gheBLL.LayDanhSachGhe(maPhong, maSuat);
            giaVe = suatChieuBLL.LayGiaVeTheoMaSuat(maSuat); 
            radioButtonVeNguoiLon.Checked = true;
            cbbKhachHang.DataSource = khachHangBLL.LayDanhSachKhachHang();
            cbbKhachHang.DisplayMember = "HoTen";  
            cbbKhachHang.ValueMember = "MaKH";
            loaiVe = radioButtonVeNguoiLon.Text;

            int soDong = 10;
            int soCot = 10;
            int btnWidth = 50;
            int btnHeight = 40;
            int khoangCach = 5;
            int marginTop = 80;
            int marginLeft = 100;

            for (int i = 0; i < soDong; i++)
            {
                char rowChar = (char)('A' + i);
                for (int j = 0; j < soCot; j++)
                {
                    Button btn = new Button
                    {
                        Width = btnWidth,
                        Height = btnHeight,
                        Left = marginLeft + j * (btnWidth + khoangCach),
                        Top = marginTop + (i * (btnHeight + khoangCach)),
                        Text = $"{rowChar}-{j}",
                        BackColor = Color.LightYellow
                    };

                    var ghe = danhSachGhe.Find(g => g.SoGhe == btn.Text);
                    if (ghe != null && ghe.TrangThai == "Đã đặt")
                    {
                        btn.BackColor = Color.Gray;
                        btn.Enabled = false;
                    }

                    btn.Click += Btn_Click;
                    this.Controls.Add(btn);
                }
            }

            tinhTongTien();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.LightYellow)
            {
                btn.BackColor = Color.Yellow;
                danhSachGheChon.Add(btn.Text);
            }
            else if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.LightYellow;
                danhSachGheChon.Remove(btn.Text);
            }

            tinhTongTien();
        }

        private void tinhTongTien()
        {
            tongTien = danhSachGheChon.Count * giaVe; 
            khuyenMai = 0;
            tienPhaiTra = tongTien;

            if (radioButtonVeMienPhi.Checked)
            {
                khuyenMai = tongTien; 
            }
            else if (radioButtonVeTreEm.Checked)
            {
                khuyenMai = (int)(tongTien * 0.20); 
            }
            else if (radioButtonVeVIP.Checked)
            {
                khuyenMai = (int)(tongTien * 0.50); 
            }

            tienPhaiTra = tongTien - khuyenMai; 


            txtTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            txtKhuyenMai.Text = khuyenMai.ToString("N0") + " VNĐ";
            txtTienPhaiTra.Text = tienPhaiTra.ToString("N0") + " VNĐ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maKhachHang = Convert.ToInt32(cbbKhachHang.SelectedValue); // Lấy mã khách hàng
            string tenKhachHang = ((KhachHangDTO)cbbKhachHang.SelectedItem).HoTen;

            foreach (var soGhe in danhSachGheChon)
            {
                gheBLL.CapNhatTrangThaiGhe(maPhong, soGhe, "Đã đặt", maSuat);

                foreach (Control control in this.Controls)
                {
                    if (control is Button btn && btn.Text == soGhe)
                    {
                        btn.BackColor = Color.Gray;
                        btn.Enabled = false;
                    }
                }

                // Tạo vé mới và thêm vào cơ sở dữ liệu
                VeDTO ve = new VeDTO
                {
                    MaSuatChieu = maSuat,
                    MaPhong = maPhong,
                    SoGhe = soGhe,
                    MaKH = maKhachHang,
                    GiaVe = giaVe,
                    LoaiVe = loaiVe
                };

                VeBLL veBLL = new VeBLL();
                veBLL.ThemVe(ve);
            }

            MessageBox.Show("Thanh toán và lưu vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            danhSachGheChon.Clear();
            tinhTongTien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonVeNguoiLon_CheckedChanged(object sender, EventArgs e)
        {
            loaiVe = radioButtonVeNguoiLon.Text;
            tinhTongTien();
        }

        private void radioButtonVeTreEm_CheckedChanged(object sender, EventArgs e)
        {
            loaiVe = radioButtonVeTreEm.Text;
            tinhTongTien();
        }

        private void radioButtonVeVIP_CheckedChanged(object sender, EventArgs e)
        {
            loaiVe = radioButtonVeVIP.Text;
            tinhTongTien();
        }

        private void radioButtonVeMienPhi_CheckedChanged(object sender, EventArgs e)
        {
            loaiVe = radioButtonVeMienPhi.Text;
            tinhTongTien();
        }
    }
}
