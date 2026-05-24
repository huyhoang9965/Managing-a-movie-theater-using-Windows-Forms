using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class SuatChieuBLL
    {
        private SuatChieuDAL dal = new SuatChieuDAL();

        public List<SuatChieuDTO> LayDanhSachSuatChieu()
        {
            return dal.LayDanhSachSuatChieu();
        }

        public bool ThemSuatChieu(SuatChieuDTO sc)
        {
            return dal.ThemSuatChieu(sc);
        }

        public bool SuaSuatChieu(SuatChieuDTO sc)
        {
            return dal.SuaSuatChieu(sc);
        }

        public bool XoaSuatChieu(int maSC)
        {
            return dal.XoaSuatChieu(maSC);
        }

        public List<SuatChieuDTO> TimKiemSuatChieu(string tuKhoa)
        {
            return dal.TimKiemSuatChieu(tuKhoa);
        }
        public List<SuatChieuDTO> TimKiemSuatChieuTheoMaPhim(int maPhim)
        {
            return dal.TimKiemSuatChieuTheoMaPhim(maPhim);
        }
        public int LayGiaVeTheoMaSuat(int maSuat)
        {
            return dal.LayGiaVeTheoMaSuat(maSuat);
        }
        public List<SuatChieuDTO> LaySuatChieuTheoNgay(DateTime ngayChieu)
        {
            return dal.LaySuatChieuTheoNgay(ngayChieu);
        }
    }
}
