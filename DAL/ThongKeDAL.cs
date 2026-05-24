using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ThongKeDAL
    {
        private string connectionString = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";

        // Phương thức thực hiện thủ tục sp_ThongKeDoanhThuTheoNgay
        public DataTable ThongKeDoanhThuTheoNgay()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThongKeDoanhThuTheoNgay", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Phương thức thực hiện thủ tục sp_ThongKeDoanhThuTheoThang
        public DataTable ThongKeDoanhThuTheoThang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThongKeDoanhThuTheoThang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Phương thức thực hiện thủ tục sp_ThongKeDoanhThuTheoNam
        public DataTable ThongKeDoanhThuTheoNam()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThongKeDoanhThuTheoNam", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable ThongKeDoanhThuTheoPhim()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThongKeDoanhThuTheoPhim", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Thống kê số vé theo suất chiếu
        public DataTable ThongKeSoVeTheoSuatChieu()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThongKeSoVeTheoSuatChieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Thống kê số lượng suất chiếu theo phim theo ngày
        public DataTable ThongKeSoLuongSuatChieuTheoPhim(DateTime ngayChieu)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThongKeSoLuongSuatChieuTheoPhim", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NgayChieu", ngayChieu);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable LayDanhSachNgayChieu()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT CONVERT(date, NgayChieu) AS Ngay FROM SuatChieu ORDER BY Ngay DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}



