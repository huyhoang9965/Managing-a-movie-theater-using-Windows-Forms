using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;


namespace DAL
{
    public class HoaDonDAL
    {
        private string connectionString = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";

        public List<HoaDonDTO> LayDanhSachHoaDon()
        {
            List<HoaDonDTO> list = new List<HoaDonDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThiHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HoaDonDTO hd = new HoaDonDTO
                    {
                        MaHoaDon = Convert.ToInt32(reader["MaHoaDon"]),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                        TongTien = Convert.ToInt32(reader["TongTien"]),
                        HinhThucThanhToan = reader["HinhThucThanhToan"].ToString(),
                        HoTen = reader["TenKH"].ToString()
                    };
                    list.Add(hd);
                }
            }
            return list;
        }

        // Thêm hóa đơn
        public bool ThemHoaDon(HoaDonDTO hd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKH", hd.MaKH);
                cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", hd.HinhThucThanhToan);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa hóa đơn
        public bool SuaHoaDon(HoaDonDTO hd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHoaDon", hd.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaKH", hd.MaKH);
                cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", hd.HinhThucThanhToan);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa hóa đơn
        public bool XoaHoaDon(int maHoaDon)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Tìm kiếm hóa đơn
        public List<HoaDonDTO> TimKiemHoaDon(string keyword)
        {
            List<HoaDonDTO> list = new List<HoaDonDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKiemHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Truyền tham số từ khóa vào
                cmd.Parameters.AddWithValue("@TuKhoa", keyword);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HoaDonDTO hd = new HoaDonDTO
                    {
                        MaHoaDon = Convert.ToInt32(reader["MaHoaDon"]),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                        TongTien = Convert.ToInt32(reader["TongTien"]),
                        HinhThucThanhToan = reader["HinhThucThanhToan"].ToString(),
                        HoTen = reader["TenKH"].ToString()
                    };
                    list.Add(hd);
                }
            }
            return list;
        }
        public HoaDonDTO LayHoaDonTheoMa(int maHoaDon)
        {
            HoaDonDTO hoaDon = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon WHERE MaHoaDon = @MaHoaDon", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    hoaDon = new HoaDonDTO
                    {
                        MaHoaDon = Convert.ToInt32(reader["MaHoaDon"]),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        TongTien = Convert.ToInt32(reader["TongTien"]),
                        HinhThucThanhToan = reader["HinhThucThanhToan"].ToString()
                    };
                }
            }
            return hoaDon;
        }

    }
}