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
    public partial class frmPhongChieu : Form
    {
        private PhongChieuBLL bll = new PhongChieuBLL();
        public frmPhongChieu()
        {
            InitializeComponent();
        }

        private void frmPhongChieu_Load(object sender, EventArgs e)
        {
            HienThiDanhSachPhongChieu();
        }
        private void HienThiDanhSachPhongChieu()
        {
            List<PhongChieuDTO> ds = bll.HienThiPhongChieu();
            dgvPhongChieu.DataSource = ds;
            dgvPhongChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhongChieu.MultiSelect = false;
        }



        private void dgvPhongChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }




        private void dgvPhongChieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var maPhong = (int)dgvPhongChieu.Rows[e.RowIndex].Cells[0].Value;
                SuaPhongChieu frm = new SuaPhongChieu(maPhong);
                frm.ShowDialog();
                HienThiDanhSachPhongChieu();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvPhongChieu.SelectedRows.Count > 0)
            {
                var maPhong = (int)dgvPhongChieu.SelectedRows[0].Cells[0].Value;

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa phòng chiếu này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    bll.XoaPhongChieu(maPhong);
                    HienThiDanhSachPhongChieu();

                    MessageBox.Show(
                        "Xóa phòng chiếu thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn một phòng chiếu để xóa.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ThemPhongChieu frm = new ThemPhongChieu();
            frm.ShowDialog();
            HienThiDanhSachPhongChieu();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            int? maPhong = null;

            if (int.TryParse(timKiem, out int maPhongResult))
            {
                maPhong = maPhongResult;
            }

            List<PhongChieuDTO> danhSachPhong = bll.TimKiemPhongChieu(maPhong, timKiem);

            dgvPhongChieu.DataSource = danhSachPhong;
        }
    }
}
