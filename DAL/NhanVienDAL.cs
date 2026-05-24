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
    public class NhanVienDAL
    {
        private string connectionString = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";

        public List<NhanVienDTO> HienThiNhanVien()
        {
            List<NhanVienDTO> ds = new List<NhanVienDTO>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_HienThiNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new NhanVienDTO
                    {
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        ChucVu = reader["ChucVu"].ToString(),
                        Luong = Convert.ToInt32(reader["Luong"]),
                        MaRap = Convert.ToInt32(reader["MaRap"]),
                        TenRap = reader["TenRap"].ToString()
                    });
                }
            }
            return ds;
        }

        public bool ThemNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
                cmd.Parameters.AddWithValue("@Luong", nv.Luong);
                cmd.Parameters.AddWithValue("@MaRap", nv.MaRap);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_SuaNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
                cmd.Parameters.AddWithValue("@Luong", nv.Luong);
                cmd.Parameters.AddWithValue("@MaRap", nv.MaRap);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaNhanVien(int maNV)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNV", maNV);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<NhanVienDTO> TimKiemNhanVien(string tukhoa)
        {
            List<NhanVienDTO> ds = new List<NhanVienDTO>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TuKhoa", tukhoa);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new NhanVienDTO
                    {
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        ChucVu = reader["ChucVu"].ToString(),
                        Luong = Convert.ToInt32(reader["Luong"]),
                        MaRap = Convert.ToInt32(reader["MaRap"]),
                        TenRap = reader["TenRap"].ToString()
                    });
                }
            }
            return ds;
        }
        public NhanVienDTO LayNhanVienByMaNV(int maNV)
        {
            NhanVienDTO nv = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nv = new NhanVienDTO
                    {
                        MaNV = reader["MaNV"] == DBNull.Value ? 0 : Convert.ToInt32(reader["MaNV"]),
                        HoTen = reader["HoTen"] == DBNull.Value ? "" : reader["HoTen"].ToString(),
                        NgaySinh = reader["NgaySinh"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["NgaySinh"]),
                        GioiTinh = reader["GioiTinh"] == DBNull.Value ? "" : reader["GioiTinh"].ToString(),
                        SoDienThoai = reader["SoDienThoai"] == DBNull.Value ? "" : reader["SoDienThoai"].ToString(),
                        ChucVu = reader["ChucVu"] == DBNull.Value ? "" : reader["ChucVu"].ToString(),
                        Luong = reader["Luong"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Luong"]),
                        MaRap = reader["MaRap"] == DBNull.Value ? 0 : Convert.ToInt32(reader["MaRap"])
                    };
                }
            }
            return nv;
        }
    }
}