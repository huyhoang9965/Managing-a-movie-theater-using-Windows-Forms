using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();

        public TaiKhoann DangNhap(string tk, string mk)
        {
            return dal.KiemTraDangNhap(tk, mk);
        }
        public int DangKy(TaiKhoann tk)
        {
            return dal.DangKyTaiKhoan(tk);
        }
    }
}
