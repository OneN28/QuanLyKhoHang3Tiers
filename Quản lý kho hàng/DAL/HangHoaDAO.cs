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
                products.Add(new HangHoa(reader.GetString(0), reader.GetString(1),reader.GetString(3),double.Parse(reader.GetString(2)),int.Parse(reader.GetString(4))));
            }
            reader.Close();
            return products;
        }
        public bool Delete(string maHang)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Hanghoa WHERE Hanghoa.Mahang=\'" + maHang + "\'",ConfigureManager.SqlConnection);
            return command.ExecuteNonQuery() == 0 ? false : true;
        }
        public bool Insert(HangHoa hangHoa)
        {
            SqlCommand command = new SqlCommand(string.Format("INSERT INTO Hanghoa VALUES(\'{0}\',\'{1}\',\'{4}\',\'{2}\',\'{3}\')",
                hangHoa.MaHang, hangHoa.TenHang, hangHoa.NoiChua, hangHoa.GiaHang, hangHoa.SoLuongHang),ConfigureManager.SqlConnection);
            return command.ExecuteNonQuery() == 0 ? false : true;
        }
        public bool Update(string maHangOld, HangHoa hangHoa)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    string.Format(
                       "UPDATE Hanghoa SET MaHang='{0}', TenHang='{1}', NoiChua='{2}', GiaHang='{3}', SoLuongHang='{4}' WHERE MaHang = '{5}'",
                      hangHoa.MaHang, hangHoa.TenHang, hangHoa.NoiChua, hangHoa.GiaHang, hangHoa.SoLuongHang, maHangOld
                       ), ConfigureManager.SqlConnection
                    );
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                
                return false;
            }
        }
    }
}
