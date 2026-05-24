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
using System.Windows.Forms.DataVisualization.Charting;
namespace GUI
{
    public partial class frmBieuDo : Form
    {
        private ThongKeBLL thongKeBLL = new ThongKeBLL();
        public frmBieuDo()
        {
            InitializeComponent();
        }

        private void frmBieuDo_Load(object sender, EventArgs e)
        {
            cbbLoaiThongKe.Items.Add("Doanh thu theo ngày");
            cbbLoaiThongKe.Items.Add("Doanh thu theo tháng");
            cbbLoaiThongKe.Items.Add("Doanh thu theo năm");
            cbbLoaiThongKe.SelectedIndex = 0;
        }

        private void btnVeBieuDo_Click(object sender, EventArgs e)
        {
            string loaiThongKe = cbbLoaiThongKe.SelectedItem.ToString();
            DataTable dt = new DataTable();
            string xMember = "", yMember = "TongDoanhThu";

            switch (loaiThongKe)
            {
                case "Doanh thu theo ngày":
                    dt = thongKeBLL.ThongKeDoanhThuTheoNgay();

                    // Tạo cột hiển thị ngày định dạng dd/MM/yyyy
                    dt.Columns.Add("NgayFormatted", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime ngay = Convert.ToDateTime(row["Ngay"]);
                        row["NgayFormatted"] = ngay.ToString("dd/MM/yyyy");
                    }
                    dt.DefaultView.Sort = "Ngay ASC";
                    dt = dt.DefaultView.ToTable();
                    xMember = "NgayFormatted";
                    break;

                case "Doanh thu theo tháng":
                    dt = thongKeBLL.ThongKeDoanhThuTheoThang();

                    // Tạo cột định dạng Tháng/Năm
                    dt.Columns.Add("ThangNam", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["ThangNam"] = $"{row["Thang"]}/{row["Nam"]}";
                    }
                    dt.DefaultView.Sort = "Nam ASC, Thang ASC";
                    dt = dt.DefaultView.ToTable();
                    xMember = "ThangNam";
                    break;

                case "Doanh thu theo năm":
                    dt = thongKeBLL.ThongKeDoanhThuTheoNam();

                    // Thêm cột năm dạng chuỗi để hiển thị rõ ràng trên trục X
                    dt.Columns.Add("NamText", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["NamText"] = row["Nam"].ToString();
                    }
                    dt.DefaultView.Sort = "Nam ASC";
                    dt = dt.DefaultView.ToTable();
                    xMember = "NamText";
                    break;
            }

            chartDoanhThu.Series.Clear();
            chartDoanhThu.ChartAreas.Clear();

            chartDoanhThu.ChartAreas.Add("MainArea");
            Series series = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Line,
                XValueMember = xMember,
                YValueMembers = yMember,
                BorderWidth = 3
            };

            chartDoanhThu.Series.Add(series);
            chartDoanhThu.DataSource = dt;
            chartDoanhThu.DataBind();
        }
    }
}
