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
    public class GheDAL
    {
        private string connectionString = @"Data Source=LAPTOP-ATF1ETUQ\SQLEXPRESS;Initial Catalog=DA1;Integrated Security=True";

        // Cập nhật trạng thái ghế
        public void CapNhatTrangThaiGhe(int maPhong, string soGhe, string trangThai, int maSuatChieu)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Ghe SET TrangThai = @TrangThai WHERE MaPhong = @MaPhong AND SoGhe = @SoGhe AND MaSuatChieu = @MaSuatChieu";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                cmd.Parameters.AddWithValue("@SoGhe", soGhe);
                cmd.Parameters.AddWithValue("@MaSuatChieu", maSuatChieu); // Thêm MaSuatChieu

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Thêm ghế mới
        public void ThemGhe(int maPhong, string soGhe, string loaiGhe, int maSuatChieu)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Ghe (MaPhong, SoGhe, LoaiGhe, TrangThai, MaSuatChieu) VALUES (@MaPhong, @SoGhe, @LoaiGhe, 'Trống', @MaSuatChieu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                cmd.Parameters.AddWithValue("@SoGhe", soGhe);
                cmd.Parameters.AddWithValue("@LoaiGhe", loaiGhe);
                cmd.Parameters.AddWithValue("@MaSuatChieu", maSuatChieu); // Thêm MaSuatChieu

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Lấy danh sách ghế theo suất chiếu
        public List<GheDTO> LayDanhSachGhe(int? maPhong = null, int? maSuatChieu = null)
        {
            List<GheDTO> danhSachGhe = new List<GheDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Xây dựng phần điều kiện cho câu truy vấn
                string query = "SELECT * FROM Ghe WHERE 1=1";  // Phần WHERE này luôn đúng, giúp dễ dàng nối điều kiện sau đó

                // Thêm điều kiện cho MaPhong nếu có
                if (maPhong.HasValue)
                {
                    query += " AND MaPhong = @MaPhong";
                }

                // Thêm điều kiện cho MaSuatChieu nếu có
                if (maSuatChieu.HasValue)
                {
                    query += " AND MaSuatChieu = @MaSuatChieu";
                }

                SqlCommand cmd = new SqlCommand(query, conn);

                // Thêm tham số vào câu truy vấn nếu có
                if (maPhong.HasValue)
                {
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong.Value);
                }

                if (maSuatChieu.HasValue)
                {
                    cmd.Parameters.AddWithValue("@MaSuatChieu", maSuatChieu.Value);
                }

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    GheDTO ghe = new GheDTO
                    {
                        MaGhe = Convert.ToInt32(reader["MaGhe"]),
                        SoGhe = reader["SoGhe"].ToString(),
                        TrangThai = reader["TrangThai"].ToString(),
                        LoaiGhe = reader["LoaiGhe"].ToString(),
                        MaSuatChieu = Convert.ToInt32(reader["MaSuatChieu"]),
                        MaPhong = Convert.ToInt32(reader["MaPhong"])
                    };
                    danhSachGhe.Add(ghe);
                }
            }

            return danhSachGhe;
        }
    }
}
