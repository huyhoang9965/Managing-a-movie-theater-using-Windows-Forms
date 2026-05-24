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
    public class PhongChieuDAL
    {
        private string connectionString = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";

        public List<PhongChieuDTO> HienThiPhongChieu()
        {
            List<PhongChieuDTO> ds = new List<PhongChieuDTO>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_HienThiPhongChieu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ds.Add(new PhongChieuDTO
                    {
                        MaPhong = (int)reader["MaPhong"],
                        MaRap = (int)reader["MaRap"],
                        TenPhong = reader["TenPhong"].ToString(),
                        LoaiPhong = reader["LoaiPhong"].ToString(),
                        TrangThai = reader["TrangThai"].ToString()
                    });
                }
            }
            return ds;
        }

        // Thêm phòng chiếu mới
        public bool ThemPhongChieu(PhongChieuDTO pc)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemPhongChieu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaRap", pc.MaRap);
                cmd.Parameters.AddWithValue("@TenPhong", pc.TenPhong);
                cmd.Parameters.AddWithValue("@LoaiPhong", pc.LoaiPhong);
                cmd.Parameters.AddWithValue("@TrangThai", pc.TrangThai);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa thông tin phòng chiếu
        public bool SuaPhongChieu(PhongChieuDTO pc)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_SuaPhongChieu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhong", pc.MaPhong);
                cmd.Parameters.AddWithValue("@MaRap", pc.MaRap);
                cmd.Parameters.AddWithValue("@TenPhong", pc.TenPhong);
                cmd.Parameters.AddWithValue("@LoaiPhong", pc.LoaiPhong);
                cmd.Parameters.AddWithValue("@TrangThai", pc.TrangThai);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa phòng chiếu
        public bool XoaPhongChieu(int maPhong)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaPhongChieu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Tìm kiếm phòng chiếu
        public List<PhongChieuDTO> TimKiemPhongChieu(int? maPhong, string tenPhong)
        {
            List<PhongChieuDTO> ds = new List<PhongChieuDTO>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemPhongChieu", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhong", (object)maPhong ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TenPhong", string.IsNullOrEmpty(tenPhong) ? (object)DBNull.Value : tenPhong);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ds.Add(new PhongChieuDTO
                    {
                        MaPhong = (int)reader["MaPhong"],
                        MaRap = (int)reader["MaRap"],
                        TenPhong = reader["TenPhong"].ToString(),
                        LoaiPhong = reader["LoaiPhong"].ToString(),
                        TrangThai = reader["TrangThai"].ToString()
                    });
                }
            }
            return ds;
        }
        public PhongChieuDTO LayPhongChieuByMaPC(int maPhong)
        {
            string query = "SELECT * FROM PhongChieu WHERE MaPhong = @MaPhong";
            PhongChieuDTO phongChieu = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    phongChieu = new PhongChieuDTO
                    {
                        MaPhong = (int)reader["MaPhong"],
                        TenPhong = reader["TenPhong"].ToString(),
                        LoaiPhong = reader["LoaiPhong"].ToString(),
                        TrangThai = reader["TrangThai"].ToString(),
                        MaRap = (int)reader["MaRap"] 
                    };
                }
            }

            return phongChieu;
        }
    }
}

