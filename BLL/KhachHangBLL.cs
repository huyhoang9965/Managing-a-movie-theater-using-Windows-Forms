using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL dal = new KhachHangDAL();

        public List<KhachHangDTO> LayDanhSachKhachHang()
        {
            return dal.LayDanhSachKhachHang();
        }

        public bool ThemKhachHang(KhachHangDTO kh)
        {
            return dal.ThemKhachHang(kh);
        }

        public bool SuaKhachHang(KhachHangDTO kh)
        {
            return dal.SuaKhachHang(kh);
        }

        public bool XoaKhachHang(int maKH)
        {
            return dal.XoaKhachHang(maKH);
        }

        public List<KhachHangDTO> TimKiemKhachHang(string tuKhoa)
        {
            return dal.TimKiemKhachHang(tuKhoa);
        }
    }
}
