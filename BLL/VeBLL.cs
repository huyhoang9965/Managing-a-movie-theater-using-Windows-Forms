using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class VeBLL
    {
        private VeDAL veDAL;

        public VeBLL()
        {
            veDAL = new VeDAL();
        }

        public bool ThemVe(VeDTO ve)
        {
           return veDAL.ThemVe(ve);
        }

        public bool SuaVe(VeDTO ve)
        {
            return veDAL.SuaVe(ve); 
        }

        public void XoaVe(int maVe)
        {
            veDAL.XoaVe(maVe);
        }

        public List<VeDTO> HienThiVe()
        {
            return veDAL.HienThiVe();
        }

        public List<VeDTO> TimKiemVe(string keyword)
        {
            return veDAL.TimKiemVe(keyword);
        }
        public VeDTO TimTheoMaVe(int maVe)
        {
            return veDAL.TimTheoMaVe(maVe);
        }
        public List<VeDTO> LayVeTheoMaTK(int maTK)
        {
            return veDAL.LayVeTheoMaTK(maTK);
        }
    }
}