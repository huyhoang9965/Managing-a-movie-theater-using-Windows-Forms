using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL dal = new NhanVienDAL();

        public List<NhanVienDTO> HienThiNhanVien() => dal.HienThiNhanVien();

        public bool ThemNhanVien(NhanVienDTO nv)
        {

            return dal.ThemNhanVien(nv);
        }

        public bool SuaNhanVien(NhanVienDTO nv)
        {

            return dal.SuaNhanVien(nv);
        }

        public bool XoaNhanVien(int maNV)
        {

            return dal.XoaNhanVien(maNV);
        }

        public List<NhanVienDTO> TimKiemNhanVien(string tukhoa)
        {
            return dal.TimKiemNhanVien(tukhoa);
        }
        public NhanVienDTO LayNhanVienByMaNV(int maNV)
        {
            return dal.LayNhanVienByMaNV(maNV);
        }
    }
}
