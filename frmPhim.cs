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
using System.IO;

namespace GUI
{
    public partial class frmPhim : Form
    {

        public frmPhim()
        {
            InitializeComponent();
        }
        private void HienThiAnhTrongFlowLayoutPanel(List<PhimDTO> danhSachPhim)
        {

            flpanelPhim.Controls.Clear();  

            foreach (PhimDTO phim in danhSachPhim)
            {
                string fullPath = Path.Combine(Application.StartupPath, "Phim", phim.Poster);

                // Panel chứa ảnh và nút
                Panel panel = new Panel();
                panel.Width = 150;
                panel.Height = 250;
                panel.Margin = new Padding(10);

                PictureBox pic = new PictureBox();
                pic.Width = 150;
                pic.Height = 200;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                if (File.Exists(fullPath))
                    pic.Image = Image.FromFile(fullPath);
                else
                    pic.Image = Properties.Resources.ANHBIA_;

                Button btn = new Button();
                btn.Text = "Xem chi tiết";
                btn.Width = 150;
                btn.Height = 30;
                btn.Top = pic.Bottom + 5;
                btn.Tag = phim;
                btn.Click += Btn_Click;

                panel.Controls.Add(pic);
                panel.Controls.Add(btn);

                flpanelPhim.Controls.Add(panel);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            PhimDTO phim = btn.Tag as PhimDTO;

            if (phim != null)
            {
                frmChiTietPhim frm = new frmChiTietPhim(phim);
                frm.ShowDialog();
            }
        }


        private void frmPhim_Load(object sender, EventArgs e)
        {
            PhimBLL phimBLL = new PhimBLL();
            List<string> danhSachTheLoai = phimBLL.LayDanhSachTheLoai();
            cbbTheLoai.DataSource = danhSachTheLoai;
            HienThiAnhTrongFlowLayoutPanel(phimBLL.LayDanhSachTatCaPhim());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();  

            PhimBLL phimBLL = new PhimBLL();
            List<PhimDTO> ketQua = phimBLL.TimKiemPhim(tuKhoa);  

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phim phù hợp!");
                HienThiAnhTrongFlowLayoutPanel(new List<PhimDTO>());  
            }
            else
            {
                HienThiAnhTrongFlowLayoutPanel(ketQua);  
            }
        }



        private void ZoomImage(Image image)
        {

        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theLoai = cbbTheLoai.SelectedItem.ToString().Trim();

            PhimBLL phimBLL = new PhimBLL();
            List<PhimDTO> ketQua = phimBLL.TimKiemPhim(theLoai);  

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phim thuộc thể loại này!");
                HienThiAnhTrongFlowLayoutPanel(new List<PhimDTO>());
            }
            else
            {
                HienThiAnhTrongFlowLayoutPanel(ketQua);
            }
        }
    }
}
    

