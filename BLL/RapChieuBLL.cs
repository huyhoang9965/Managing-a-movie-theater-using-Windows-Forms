using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{

    public class RapChieuBLL
    {

        private RapChieuDAL rapChieuDAL = new RapChieuDAL();

        public RapChieuBLL()
        {
            rapChieuDAL = new RapChieuDAL();
        }

        // Lấy danh sách các rạp chiếu
        public List<RapChieuDTO> LayDanhSachRap()
        {
            return rapChieuDAL.LayDanhSachRap();
        }

        // Thêm rạp chiếu
        public bool ThemRapChieu(RapChieuDTO rap)
        {
            if (string.IsNullOrEmpty(rap.TenRap) || string.IsNullOrEmpty(rap.DiaChi))
            {
                throw new Exception("Tên rạp và địa chỉ không được để trống");
            }
            return rapChieuDAL.ThemRapChieu(rap);
        }

        // Sửa thông tin rạp chiếu
        public bool SuaRapChieu(int maRap, RapChieuDTO rap)
        {
            if (string.IsNullOrEmpty(rap.TenRap) || string.IsNullOrEmpty(rap.DiaChi))
            {
                throw new Exception("Tên rạp và địa chỉ không được để trống");
            }
            return rapChieuDAL.SuaRapChieu(maRap, rap);
        }

        public bool XoaRapChieu(int maRap)
        {
            return rapChieuDAL.XoaRapChieu(maRap);
        }
        public List<RapChieuDTO> TimKiemRapChieu(string tuKhoa)
        {
            return rapChieuDAL.TimKiemRapChieu(tuKhoa);
        }

        // Tìm kiếm rạp chiếu theo tên
        public RapChieuDTO LayRapByMa(int maRap)
        {
            return rapChieuDAL.LayRapByMa(maRap);
        }
    }
}
