using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuatChieuDTO
    {
        public int MaSuatChieu { get; set; }
        public int MaPhim { get; set; }
        public int MaPhong { get; set; }
        public DateTime NgayChieu { get; set; }
        public TimeSpan GioChieu { get; set; }
        public string TrangThai { get; set; }
        public int Tien { get; set; }
        public string TenPhim { get; set; }
        public string Poster { get; set; }
    }
}
