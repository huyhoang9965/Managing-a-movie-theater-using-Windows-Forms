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
    public class RapChieuDAL
    {
        private string connectionString = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";
        public List<RapChieuDTO> LayDanhSachRap()
        {
            List<RapChieuDTO> danhSach = new List<RapChieuDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_HienThiTatCaRapChieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RapChieuDTO rap = new RapChieuDTO
                    {
                        MaRap = Convert.ToInt32(reader["MaRap"]),
                        TenRap = reader["TenRap"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        DienThoai = reader["DienThoai"].ToString(),
                        Email = reader["Email"].ToString(),
                        NgayTao = Convert.ToDateTime(reader["NgayTao"]),
                        NguoiTao = reader["NguoiTao"].ToString()
                    };
                    danhSach.Add(rap);
                }

                reader.Close();
            }

            return danhSach;
        }

        public bool ThemRapChieu(RapChieuDTO rap)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemRapChieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TenRap", rap.TenRap);
                cmd.Parameters.AddWithValue("@DiaChi", rap.DiaChi);
                cmd.Parameters.AddWithValue("@DienThoai", rap.DienThoai);
                cmd.Parameters.AddWithValue("@Email", rap.Email);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
        }

        public bool SuaRapChieu(int maRap, RapChieuDTO rap)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_SuaRapChieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaRap", maRap);
                cmd.Parameters.AddWithValue("@TenRap", rap.TenRap);
                cmd.Parameters.AddWithValue("@DiaChi", rap.DiaChi);
                cmd.Parameters.AddWithValue("@DienThoai", rap.DienThoai);
                cmd.Parameters.AddWithValue("@Email", rap.Email);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
        }

        public bool XoaRapChieu(int maRap)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaRapChieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaRap", maRap);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
        }

        public List<RapChieuDTO> TimKiemRapChieu(string tenRap)
        {
            List<RapChieuDTO> danhSach = new List<RapChieuDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemRapChieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TuKhoa", tenRap);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RapChieuDTO rap = new RapChieuDTO
                    {
                        MaRap = Convert.ToInt32(reader["MaRap"]),
                        TenRap = reader["TenRap"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        DienThoai = reader["DienThoai"].ToString(),
                        Email = reader["Email"].ToString(),
                        NgayTao = Convert.ToDateTime(reader["NgayTao"]),
                        NguoiTao = reader["NguoiTao"].ToString()
                    };
                    danhSach.Add(rap);
                }

                reader.Close();
            }

            return danhSach;
        }
        public RapChieuDTO LayRapByMa(int maRap)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM RapChieu WHERE MaRap = @MaRap";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaRap", maRap);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    RapChieuDTO rap = new RapChieuDTO
                    {
                        MaRap = Convert.ToInt32(reader["MaRap"]),
                        TenRap = reader["TenRap"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        DienThoai = reader["DienThoai"].ToString(),
                        Email = reader["Email"].ToString(),
                        NgayTao = Convert.ToDateTime(reader["NgayTao"]),
                        NguoiTao = reader["NguoiTao"].ToString()
                    };
                    return rap;
                }
                return null;
            }
        }
    }
}

