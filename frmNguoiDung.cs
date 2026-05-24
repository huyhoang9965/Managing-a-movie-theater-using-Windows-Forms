using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNguoiDung : Form
    {
        private int currentMaTK;
        public frmNguoiDung(int maTK)
        {
            InitializeComponent();
            currentMaTK = maTK;
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
        private void DoiMauPanelHome(Color mau)
        {
            panelHome.BackColor = mau;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.Black);
            ShowFormInPanel(new frmTrangChu());
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.FromArgb(193, 225, 220));
            ShowFormInPanel(new frmPhim());
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.Black);
            ShowFormInPanel(new frmTrangChu());
        }

        private void btnChiTietVe_Click(object sender, EventArgs e)
        {
            DoiMauPanelHome(Color.FromArgb(193, 225, 220));
            ChiTietVe formChiTiet = new ChiTietVe(currentMaTK);
            ShowFormInPanel(formChiTiet);
        }
    }
}
