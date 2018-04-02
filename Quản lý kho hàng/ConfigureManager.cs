using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_kho_hàng
{
    public class ConfigureManager
    {
        public static string ConnectionString = "Server = .; Database=KhohangDB;Trusted_Connection=True;";
        public static System.Data.SqlClient.SqlConnection SqlConnection = new System.Data.SqlClient.SqlConnection(ConnectionString);
    
    }
}
