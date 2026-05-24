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
    public partial class QuanLyRapChieuPhim : Form
    {
        public QuanLyRapChieuPhim()
        {
            InitializeComponent();
        }

        private void ShowFormInPanel(Form form)
        {
            foreach (Control control in panelChinh.Controls)
            {
                control.Dispose();
            }


            form.TopLevel = false; 
            form.FormBorderStyle = FormBorderStyle.None; 
            form.Dock = DockStyle.Fill; 
            panelChinh.Controls.Add(form); 
            form.Show(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.Black);
            ShowFormInPanel(new frmTrangChu());
        }
        private void DoiMauPanelHome(Color mau)
        {
            panelHome.BackColor = mau;
        }

        private void QuanLyRapChieuPhim_Load(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.Black);
            ShowFormInPanel(new frmTrangChu());
        }

        private void btnRapChieu_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.FromArgb(193, 225, 220));
            ShowFormInPanel(new frmRapChieu());
        }
       

        private void btnPhongChieu_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.FromArgb(193, 225, 220));
            ShowFormInPanel(new frmPhongChieu());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.FromArgb(193, 225, 220));
            ShowFormInPanel(new frmKhachHang());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.FromArgb(193, 225, 220));
            ShowFormInPanel(new frmNhanVien());
        }
        
        private void btnSuatChieu_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.FromArgb(193, 225, 220));
            ShowFormInPanel(new frmSuatChieu());
        }
        
        private void btnVe_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.FromArgb(193, 225, 220));
            ShowFormInPanel(new frmVe());
        }
        
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.FromArgb(193, 225, 220));
            ShowFormInPanel(new frmHoaDon());
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.FromArgb(193, 225, 220));
            ShowFormInPanel(new frmPhim());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.FromArgb(193, 225, 220));
            ShowFormInPanel(new frmThongKe());
        }
    }
}



