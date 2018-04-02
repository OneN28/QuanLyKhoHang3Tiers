using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Quản_lý_kho_hàng.DAL;
using Quản_lý_kho_hàng.EL;

namespace Quản_lý_kho_hàng.BL
{
    class HangHoaBUS
    {
        HangHoaDAO hangHoaDAO;
        public HangHoaBUS()
        {
            hangHoaDAO = new HangHoaDAO();
        }
        public bool Insert(HangHoa hangHoa)
        {
            return hangHoaDAO.Insert(hangHoa);
        }

        public bool Update(string maHangOld, HangHoa hangHoa)
        {
            return hangHoaDAO.Update(maHangOld, hangHoa);
        }
        public bool Delete(string maHang)
        {
            return hangHoaDAO.Delete(maHang);
        }
        public List<HangHoa> ViewAll()
        {
            return hangHoaDAO.SelectAll();
        }
    }
}
