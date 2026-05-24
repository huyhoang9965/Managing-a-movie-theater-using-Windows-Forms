using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

public class KhachHangDAL
{
    private string connectionString = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";

    public List<KhachHangDTO> LayDanhSachKhachHang()
    {
        List<KhachHangDTO> list = new List<KhachHangDTO>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT * FROM KhachHang";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                KhachHangDTO kh = new KhachHangDTO
                {
                    MaKH = Convert.ToInt32(reader["MaKH"]),
                    HoTen = reader["HoTen"].ToString(),
                    Email = reader["Email"].ToString(),
                    SoDienThoai = reader["SoDienThoai"].ToString(),
                    NgayDangKy = Convert.ToDateTime(reader["NgayDangKy"])
                };
                list.Add(kh);
            }
        }
        return list;
    }

    public bool ThemKhachHang(KhachHangDTO kh)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO KhachHang (HoTen, Email, SoDienThoai) VALUES (@HoTen, @Email, @SoDienThoai)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@HoTen", kh.HoTen);
            cmd.Parameters.AddWithValue("@Email", kh.Email);
            cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public bool SuaKhachHang(KhachHangDTO kh)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "UPDATE KhachHang SET HoTen = @HoTen, Email = @Email, SoDienThoai = @SoDienThoai WHERE MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@HoTen", kh.HoTen);
            cmd.Parameters.AddWithValue("@Email", kh.Email);
            cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai);
            cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public bool XoaKhachHang(int maKH)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaKH", maKH);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public List<KhachHangDTO> TimKiemKhachHang(string tuKhoa)
    {
        List<KhachHangDTO> list = new List<KhachHangDTO>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_TimKiemKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                KhachHangDTO kh = new KhachHangDTO
                {
                    MaKH = Convert.ToInt32(reader["MaKH"]),
                    HoTen = reader["HoTen"].ToString(),
                    Email = reader["Email"].ToString(),
                    SoDienThoai = reader["SoDienThoai"].ToString(),
                    NgayDangKy = Convert.ToDateTime(reader["NgayDangKy"])
                };
                list.Add(kh);
            }
        }
        return list;
    }
}
