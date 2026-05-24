using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VeDTO
    {
        public int MaVe { get; set; }
        public int MaSuatChieu { get; set; }
        public int MaPhong { get; set; }
        public string TenRap { get; set; }
        public string TenPhim { get; set; }
        public TimeSpan GioChieu { get; set; }
        public string SoGhe { get; set; }
        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public string LoaiVe { get; set; }
        public DateTime NgayDat { get; set; }
        public decimal GiaVe { get; set; }      
        public string TrangThai { get; set; }

    }
}
