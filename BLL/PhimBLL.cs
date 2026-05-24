using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;


namespace BLL
{
    public class PhimBLL
    {
        private PhimDAL dal = new PhimDAL();

        public List<PhimDTO> LayDanhSachTatCaPhim()
        {
            return dal.LayTatCaPhim();
        }

        public List<string> LayDanhSachTheLoai()
        {
            return dal.LayDanhSachTheLoai();
        }

        public List<PhimDTO> TimKiemPhim(string tuKhoa)
        {
            return dal.TimKiemPhim(tuKhoa);
        }

        public DataTable LayDanhSachPhim()
        {
            return dal.LayDanhSachPhim();
        }
    }
    }
