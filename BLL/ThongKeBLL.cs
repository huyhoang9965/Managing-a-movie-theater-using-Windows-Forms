using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class ThongKeBLL
    {
        private ThongKeDAL thongKeDAL = new ThongKeDAL();

        // Phương thức để lấy doanh thu theo ngày
        public DataTable ThongKeDoanhThuTheoNgay()
        {
            return thongKeDAL.ThongKeDoanhThuTheoNgay();
        }

        // Phương thức để lấy doanh thu theo tháng
        public DataTable ThongKeDoanhThuTheoThang()
        {
            return thongKeDAL.ThongKeDoanhThuTheoThang();
        }

        // Phương thức để lấy doanh thu theo năm
        public DataTable ThongKeDoanhThuTheoNam()
        {
            return thongKeDAL.ThongKeDoanhThuTheoNam();
        }
        public DataTable ThongKeDoanhThuTheoPhim()
        {
            return thongKeDAL.ThongKeDoanhThuTheoPhim();
        }

        public DataTable ThongKeSoVeTheoSuatChieu()
        {
            return thongKeDAL.ThongKeSoVeTheoSuatChieu();
        }

        public DataTable ThongKeSoLuongSuatChieuTheoPhim(DateTime ngayChieu)
        {
            return thongKeDAL.ThongKeSoLuongSuatChieuTheoPhim(ngayChieu);
        }
        public DataTable LayDanhSachNgayChieu()
        {
            return thongKeDAL.LayDanhSachNgayChieu();
        }
    }
}

