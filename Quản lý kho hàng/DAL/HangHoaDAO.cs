using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Quản_lý_kho_hàng.EL;

namespace Quản_lý_kho_hàng.DAL
{
    class HangHoaDAO
    {
        public List<HangHoa> SelectAll()
        {
            List<HangHoa> products = new List<HangHoa>();
            SqlCommand command = new SqlCommand("SELECT * FROM Hanghoa", ConfigureManager.SqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                products.Add(new HangHoa(reader.GetString(0), reader.GetString(1),reader.GetString(2),reader.GetDouble(3),reader.GetInt16(4)));
            }
            return products;
        }
        public bool Delete(string maHang)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Hanghoa WHERE Hanghoa.Mahang=\'" + maHang + "\'",ConfigureManager.SqlConnection);
            return command.ExecuteNonQuery() == 0 ? false : true;
        }
        public bool Insert(HangHoa hangHoa)
        {
            SqlCommand command = new SqlCommand(string.Format("INSERT INTO Hanghoa VALUES(\'{0}\',\'{1}\',\'{2}\',\'{3}\',\'{4}\')",
                hangHoa.MaHang, hangHoa.TenHang, hangHoa.NoiChua, hangHoa.GiaHang, hangHoa.SoLuongHang));
            return command.ExecuteNonQuery() == 0 ? false : true;
        }
        public bool Update(string maHangOld, HangHoa hangHoa)
        {
            SqlCommand command = new SqlCommand(
                string.Format(
                   "UPDATE Hanghoa SET Mahang='{0}', Tenhang='{1}', Noichua='{2}', Giahang='{3}', Soluonghang='{4}' WHERE Mahang = '{5}'",
                  hangHoa.MaHang, hangHoa.TenHang, hangHoa.NoiChua, hangHoa.GiaHang, hangHoa.SoLuongHang, maHangOld
                   ), ConfigureManager.SqlConnection
                );

            return command.ExecuteNonQuery() == 0 ? false : true;
        }
    }
}
