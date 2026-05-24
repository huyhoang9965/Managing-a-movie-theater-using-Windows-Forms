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
    public class PhimDAL
    {
        private string connectionString = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";

        public object MessageBox { get; private set; }

        public List<PhimDTO> LayTatCaPhim()
        {
            List<PhimDTO> ds = new List<PhimDTO>();
            string query = "SELECT * FROM Phim";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ds.Add(new PhimDTO
                    {
                        MaPhim = (int)dr["MaPhim"],
                        TenPhim = dr["TenPhim"].ToString(),
                        TheLoai = dr["TheLoai"].ToString(),
                        DaoDien = dr["DaoDien"].ToString(),
                        DienVien = dr["DienVien"].ToString(),
                        ThoiLuong = (int)dr["ThoiLuong"],
                        NgayKhoiChieu = (DateTime)dr["NgayKhoiChieu"],
                        MoTa = dr["MoTa"].ToString(),
                        Poster = dr["Poster"].ToString()
                    });
                }
            }
            return ds;
        }

        public List<string> LayDanhSachTheLoai()
        {
            List<string> ds = new List<string>();
            string query = "SELECT DISTINCT TheLoai FROM Phim";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ds.Add(dr["TheLoai"].ToString());
                }
            }
            return ds;
        }

        public List<PhimDTO> TimKiemPhim(string tuKhoa)
        {
            List<PhimDTO> ds = new List<PhimDTO>();
            string query = "sp_TimKiemPhim"; // Tên stored procedure

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ds.Add(new PhimDTO
                    {
                        MaPhim = (int)dr["MaPhim"],
                        TenPhim = dr["TenPhim"].ToString(),
                        TheLoai = dr["TheLoai"].ToString(),
                        DaoDien = dr["DaoDien"]?.ToString(),
                        DienVien = dr["DienVien"]?.ToString(),
                        ThoiLuong = dr["ThoiLuong"] != DBNull.Value ? (int)dr["ThoiLuong"] : 0,
                        NgayKhoiChieu = dr["NgayKhoiChieu"] != DBNull.Value ? (DateTime)dr["NgayKhoiChieu"] : DateTime.MinValue,
                        MoTa = dr["MoTa"]?.ToString(),
                        Poster = dr["Poster"]?.ToString()
                    });
                }
            }
            return ds;
        }
        public DataTable LayDanhSachPhim()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Phim";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
    }

