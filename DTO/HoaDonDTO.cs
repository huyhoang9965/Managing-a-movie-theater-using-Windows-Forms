using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public int MaHoaDon { get; set; }
        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public DateTime NgayLap { get; set; }
        public int TongTien { get; set; }
        public string HinhThucThanhToan { get; set; }
    }
}
