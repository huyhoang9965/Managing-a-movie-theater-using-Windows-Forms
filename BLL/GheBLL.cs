using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class GheBLL
    {
        private GheDAL gheDAL;

        public GheBLL()
        {
            gheDAL = new GheDAL();  // Khởi tạo đối tượng DAL
        }

        // Cập nhật trạng thái ghế
        public void CapNhatTrangThaiGhe(int maPhong, string soGhe, string trangThai, int maSuatChieu)
        {
            try
            {
                // Gọi phương thức từ DAL để cập nhật trạng thái ghế
                gheDAL.CapNhatTrangThaiGhe(maPhong, soGhe, trangThai, maSuatChieu);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật trạng thái ghế: " + ex.Message);
            }
        }

        // Thêm ghế mới
        public void ThemGhe(int maPhong, string soGhe, string loaiGhe, int maSuatChieu)
        {
            try
            {
                // Gọi phương thức từ DAL để thêm ghế mới
                gheDAL.ThemGhe(maPhong, soGhe, loaiGhe, maSuatChieu);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm ghế mới: " + ex.Message);
            }
        }

        // Lấy danh sách ghế theo mã phòng và mã suất chiếu
        public List<GheDTO> LayDanhSachGhe(int? maPhong = null, int? maSuatChieu = null)
        {
            try
            {
                // Gọi phương thức từ DAL để lấy danh sách ghế
                return gheDAL.LayDanhSachGhe(maPhong, maSuatChieu);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách ghế: " + ex.Message);
            }
        }
    }
}
