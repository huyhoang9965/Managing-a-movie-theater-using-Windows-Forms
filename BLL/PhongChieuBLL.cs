using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PhongChieuBLL
    {
        private PhongChieuDAL dal = new PhongChieuDAL();

        // Hiển thị tất cả phòng chiếu
        public List<PhongChieuDTO> HienThiPhongChieu()
        {
            return dal.HienThiPhongChieu();
        }

        // Thêm phòng chiếu
        public bool ThemPhongChieu(PhongChieuDTO pc)
        {
            return dal.ThemPhongChieu(pc);
        }

        // Sửa phòng chiếu
        public bool SuaPhongChieu(PhongChieuDTO pc)
        {
            return dal.SuaPhongChieu(pc);
        }

        // Xóa phòng chiếu
        public bool XoaPhongChieu(int maPhong)
        {
            return dal.XoaPhongChieu(maPhong);
        }

        // Tìm kiếm phòng chiếu
        public List<PhongChieuDTO> TimKiemPhongChieu(int? maPhong, string tenPhong)
        {
            return dal.TimKiemPhongChieu(maPhong, tenPhong);
        }
        public PhongChieuDTO LayPhongChieuByMaPC(int maPhong)
        {
            return dal.LayPhongChieuByMaPC(maPhong); 
        }
    }
}