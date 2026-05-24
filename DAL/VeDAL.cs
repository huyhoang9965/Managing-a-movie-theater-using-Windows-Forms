using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class VeDAL
    {
        private string connectionString = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";

        public bool ThemVe(VeDTO ve)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemVe", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                
                cmd.Parameters.AddWithValue("@MaSuatChieu", ve.MaSuatChieu);
                cmd.Parameters.AddWithValue("@SoGhe", ve.SoGhe); 
                cmd.Parameters.AddWithValue("@MaKH", ve.MaKH);
                cmd.Parameters.AddWithValue("@LoaiVe", ve.LoaiVe);
                cmd.Parameters.AddWithValue("@GiaVe", ve.GiaVe);

                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        // Sửa vé
        public bool SuaVe(VeDTO ve)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_SuaVe", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaVe", ve.MaVe);
                cmd.Parameters.AddWithValue("@MaSuatChieu", ve.MaSuatChieu);
                cmd.Parameters.AddWithValue("@SoGhe", ve.SoGhe); 
                cmd.Parameters.AddWithValue("@MaKH", ve.MaKH);
                cmd.Parameters.AddWithValue("@LoaiVe", ve.LoaiVe);
                cmd.Parameters.AddWithValue("@GiaVe", ve.GiaVe);

                conn.Open();
                int result = cmd.ExecuteNonQuery();  

                return result > 0;
            }
        }

        public void XoaVe(int maVe)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaVe", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaVe", maVe);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<VeDTO> HienThiVe()
        {
            List<VeDTO> result = new List<VeDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_HienThiVe", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    VeDTO ve = new VeDTO
                    {
                        MaVe = Convert.ToInt32(reader["MaVe"]),
                        MaSuatChieu = Convert.ToInt32(reader["MaSuatChieu"]),
                        MaPhong = Convert.ToInt32(reader["MaPhong"]),
                        TenRap = reader["TenRap"].ToString(),
                        TenPhim = reader["TenPhim"].ToString(),
                        GioChieu = (TimeSpan)reader["GioChieu"],
                        SoGhe = reader["SoGhe"].ToString(),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        HoTen = reader["HoTenKhachHang"].ToString(),
                        LoaiVe = reader["LoaiVe"].ToString(),
                        NgayDat = Convert.ToDateTime(reader["NgayDat"]),
                        GiaVe = Convert.ToDecimal(reader["GiaVe"]),
                        TrangThai = reader["TrangThai"].ToString()
                    };
                    result.Add(ve);
                }
            }

            return result;
        }

        public List<VeDTO> TimKiemVe(string keyword)
        {
            List<VeDTO> result = new List<VeDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemVe", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keyword", keyword ?? (object)DBNull.Value);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    VeDTO ve = new VeDTO
                    {
                        MaVe = Convert.ToInt32(reader["MaVe"]),
                        MaSuatChieu = Convert.ToInt32(reader["MaSuatChieu"]),
                        MaPhong = Convert.ToInt32(reader["MaPhong"]),
                        TenRap = reader["TenRap"].ToString(),
                        TenPhim = reader["TenPhim"].ToString(),
                        GioChieu = (TimeSpan)reader["GioChieu"],
                        SoGhe = reader["SoGhe"].ToString(),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        HoTen = reader["HoTen"].ToString(),
                        LoaiVe = reader["LoaiVe"].ToString(),
                        NgayDat = Convert.ToDateTime(reader["NgayDat"]),
                        GiaVe = Convert.ToDecimal(reader["GiaVe"]),
                        TrangThai = reader["TrangThai"].ToString()
                    };
                    result.Add(ve);
                }
            }

            return result;
        }

        public VeDTO TimTheoMaVe(int maVe)
        {
            VeDTO ve = null;
            string query = "SELECT * FROM Ve WHERE MaVe = @MaVe";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaVe", maVe);
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        ve = new VeDTO
                        {
                            MaVe = (int)dr["MaVe"],
                            MaSuatChieu = (int)dr["MaSuatChieu"],
                            SoGhe = dr["SoGhe"].ToString(),
                            MaKH = (int)dr["MaKH"],
                            LoaiVe = dr["LoaiVe"].ToString(),
                            GiaVe = Convert.ToInt32(dr["GiaVe"]),
                        };
                    }
                }
            }
            return ve;
        }
        public List<VeDTO> LayVeTheoMaTK(int maTK)
        {
            List<VeDTO> result = new List<VeDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_LayVeTheoMaTK", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaTK", maTK);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        VeDTO ve = new VeDTO()
                        {
                            MaVe = Convert.ToInt32(reader["MaVe"]),
                            MaSuatChieu = Convert.ToInt32(reader["MaSuatChieu"]),
                            MaPhong = Convert.ToInt32(reader["MaPhong"]),
                            SoGhe = reader["SoGhe"].ToString(),
                            MaKH = Convert.ToInt32(reader["MaKH"]),
                            HoTen = reader["HoTenKhachHang"].ToString(),   
                            LoaiVe = reader["LoaiVe"].ToString(),
                            NgayDat = Convert.ToDateTime(reader["NgayDat"]),
                            GiaVe = Convert.ToDecimal(reader["GiaVe"]),
                            TrangThai = reader["TrangThai"].ToString(),
                            TenPhim = reader["TenPhim"].ToString(),
                            GioChieu = (TimeSpan)reader["GioChieu"],
                            TenRap = reader["TenRap"].ToString()
                        };
                        result.Add(ve);
                    }
                }
            }

            return result;
        }
    }
}