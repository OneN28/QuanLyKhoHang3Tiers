using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Quản_lý_kho_hàng.EL;

namespace Quản_lý_kho_hàng.DAL
{
    class AccountDAO
    {
        
        public List<Account> SelectAll()
        {
            List<Account> accounts = new List<Account>();
            SqlCommand command = new SqlCommand("SELECT * FROM Account", ConfigureManager.SqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                accounts.Add(new Account(reader.GetString(0), reader.GetString(1)));
            }
            reader.Close();
            return accounts;
        }

        public bool Insert(Account account)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Account VALUES(\'" + account.Username + "\',\'" + account.Password + "\')", ConfigureManager.SqlConnection);
            return command.ExecuteNonQuery() == 0 ? false : true;
        }

    }
}
