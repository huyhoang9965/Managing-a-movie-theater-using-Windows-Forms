using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HoaDonBLL
    {
        private HoaDonDAL hoaDonDAL;

        public HoaDonBLL()
        {
            hoaDonDAL = new HoaDonDAL(); // Khởi tạo lớp DAL để truy xuất dữ liệu
        }

        // Lấy danh sách hóa đơn
        public List<HoaDonDTO> LayDanhSachHoaDon()
        {
            return hoaDonDAL.LayDanhSachHoaDon();
        }

        // Thêm hóa đơn
        public bool ThemHoaDon(HoaDonDTO hd)
        {
            // Có thể thêm các logic xử lý trước khi thêm hóa đơn
            return hoaDonDAL.ThemHoaDon(hd);
        }

        // Sửa hóa đơn
        public bool SuaHoaDon(HoaDonDTO hd)
        {
            // Kiểm tra thông tin cần sửa, có thể thêm logic kiểm tra tính hợp lệ của dữ liệu
            return hoaDonDAL.SuaHoaDon(hd);
        }

        // Xóa hóa đơn
        public bool XoaHoaDon(int maHoaDon)
        {

            return hoaDonDAL.XoaHoaDon(maHoaDon);
        }

        public List<HoaDonDTO> TimKiemHoaDon(string keyword)
        {
            return hoaDonDAL.TimKiemHoaDon(keyword);
        }
        public HoaDonDTO LayHoaDonTheoMa(int maHoaDon)
        {
            return hoaDonDAL.LayHoaDonTheoMa(maHoaDon);
        }
    }
}
