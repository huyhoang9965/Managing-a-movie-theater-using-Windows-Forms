using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private string connectionString = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";

        public TaiKhoann KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TaiKhoan WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TaiKhoann tk = new TaiKhoann
                    {
                        MaTK = Convert.ToInt32(reader["MaTK"]),
                        TaiKhoan = reader["TaiKhoan"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        MaQuyen = Convert.ToInt32(reader["MaQuyen"])
                    };

                    return tk;
                }
                return null;
            }
        }
        public int DangKyTaiKhoan(TaiKhoann tk)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_DangKyTaiKhoan", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TaiKhoan", tk.TaiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
                    cmd.Parameters.AddWithValue("@MaKH", tk.MaKH);
                    conn.Open();
                    return cmd.ExecuteNonQuery();  
                }
            }
        }
    }
}