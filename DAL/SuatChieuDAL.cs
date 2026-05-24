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
    public class SuatChieuDAL
    {
        private string connectionString = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";

        public List<SuatChieuDTO> LayDanhSachSuatChieu()
        {
            List<SuatChieuDTO> list = new List<SuatChieuDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_HienThiSuatChieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SuatChieuDTO sc = new SuatChieuDTO
                    {
                        MaSuatChieu = Convert.ToInt32(rd["MaSuatChieu"]),
                        MaPhim = Convert.ToInt32(rd["MaPhim"]),
                        TenPhim = rd["TenPhim"].ToString(),
                        MaPhong = Convert.ToInt32(rd["MaPhong"]),
                        NgayChieu = Convert.ToDateTime(rd["NgayChieu"]),
                        GioChieu = (TimeSpan)rd["GioChieu"],
                        TrangThai = rd["TrangThai"].ToString(),
                        Tien = Convert.ToInt32(rd["Tien"])
                    };
                    list.Add(sc);
                }
            }
            return list;
        }

        public bool ThemSuatChieu(SuatChieuDTO sc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemSuatChieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhim", sc.MaPhim);
                cmd.Parameters.AddWithValue("@MaPhong", sc.MaPhong);
                cmd.Parameters.AddWithValue("@NgayChieu", sc.NgayChieu);
                cmd.Parameters.AddWithValue("@GioChieu", sc.GioChieu);
                cmd.Parameters.AddWithValue("@TrangThai", sc.TrangThai);
                cmd.Parameters.AddWithValue("@Tien", sc.Tien);

                conn.Open();
                int kq = cmd.ExecuteNonQuery();
                return kq > 0;
            }
        }

        public bool SuaSuatChieu(SuatChieuDTO sc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_SuaSuatChieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSuatChieu", sc.MaSuatChieu);
                cmd.Parameters.AddWithValue("@MaPhim", sc.MaPhim);
                cmd.Parameters.AddWithValue("@MaPhong", sc.MaPhong);
                cmd.Parameters.AddWithValue("@NgayChieu", sc.NgayChieu);
                cmd.Parameters.AddWithValue("@GioChieu", sc.GioChieu);
                cmd.Parameters.AddWithValue("@TrangThai", sc.TrangThai);
                cmd.Parameters.AddWithValue("@Tien", sc.Tien);

                conn.Open();
                int kq = cmd.ExecuteNonQuery();
                return kq > 0;
            }
        }

        public bool XoaSuatChieu(int maSuatChieu)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaSuatChieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSuatChieu", maSuatChieu);

                conn.Open();
                int kq = cmd.ExecuteNonQuery();
                return kq > 0;
            }
        }

        public List<SuatChieuDTO> TimKiemSuatChieu(string tuKhoa)
        {
            List<SuatChieuDTO> list = new List<SuatChieuDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemSuatChieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SuatChieuDTO sc = new SuatChieuDTO
                    {
                        MaSuatChieu = Convert.ToInt32(rd["MaSuatChieu"]),
                        MaPhim = Convert.ToInt32(rd["MaPhim"]),
                        TenPhim = rd["TenPhim"].ToString(),
                        MaPhong = Convert.ToInt32(rd["MaPhong"]),
                        NgayChieu = Convert.ToDateTime(rd["NgayChieu"]),
                        GioChieu = (TimeSpan)rd["GioChieu"],
                        TrangThai = rd["TrangThai"].ToString(),
                        Tien = Convert.ToInt32(rd["Tien"])
                    };
                    list.Add(sc);
                }
            }
            return list;
        }
        public List<SuatChieuDTO> TimKiemSuatChieuTheoMaPhim(int maPhim)
        {
            List<SuatChieuDTO> list = new List<SuatChieuDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemSuatChieuTheoMaPhim", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhim", maPhim);

                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SuatChieuDTO sc = new SuatChieuDTO
                    {
                        MaSuatChieu = Convert.ToInt32(rd["MaSuatChieu"]),
                        MaPhim = Convert.ToInt32(rd["MaPhim"]),
                        TenPhim = rd["TenPhim"].ToString(),
                        MaPhong = Convert.ToInt32(rd["MaPhong"]),
                        NgayChieu = Convert.ToDateTime(rd["NgayChieu"]),
                        GioChieu = (TimeSpan)rd["GioChieu"],
                        TrangThai = rd["TrangThai"].ToString(),
                        Tien = Convert.ToInt32(rd["Tien"]),
                        Poster = rd["Poster"].ToString() // Lưu trữ đường dẫn ảnh (nếu có)
                    };
                    list.Add(sc);
                }
            }
            return list;
        }
        public int LayGiaVeTheoMaSuat(int maSuat)
        {
            int giaVe = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_LayGiaVeTheoMaSuat", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSuatChieu", maSuat);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    giaVe = Convert.ToInt32(result);
                }
            }
            return giaVe;
        }
        public List<SuatChieuDTO> LaySuatChieuTheoNgay(DateTime ngayChieu)
        {
            List<SuatChieuDTO> list = new List<SuatChieuDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_LaySuatChieuTheoNgay", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NgayChieu", ngayChieu);

                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SuatChieuDTO sc = new SuatChieuDTO
                    {
                        MaSuatChieu = Convert.ToInt32(rd["MaSuatChieu"]),
                        MaPhim = Convert.ToInt32(rd["MaPhim"]),
                        TenPhim = rd["TenPhim"].ToString(),
                        MaPhong = Convert.ToInt32(rd["MaPhong"]),
                        NgayChieu = Convert.ToDateTime(rd["NgayChieu"]),
                        GioChieu = (TimeSpan)rd["GioChieu"],
                        TrangThai = rd["TrangThai"].ToString(),
                        Tien = Convert.ToInt32(rd["Tien"])
                    };
                    list.Add(sc);
                }
            }
            return list;
        }
    }
}