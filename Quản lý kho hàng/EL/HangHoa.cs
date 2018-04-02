using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_kho_hàng.EL
{
    class HangHoa
    {
        public HangHoa(string maHang, string tenHang, string noiChua, double giaHang, int soLuongHang)
        {
            MaHang = maHang;
            TenHang = tenHang;
            NoiChua = noiChua;
            GiaHang = giaHang;
            SoLuongHang = soLuongHang;
        }

        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string NoiChua { get; set; }
        public double GiaHang { get; set; }
        public int SoLuongHang { get; set; }
    }
}
