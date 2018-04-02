using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Quản_lý_kho_hàng.DAL;
using Quản_lý_kho_hàng.EL;

namespace Quản_lý_kho_hàng.BL
{
    class AccountBUS
    {
        AccountDAO accountDAO;
        public AccountBUS()
        {
            accountDAO = new AccountDAO();
        }
        public bool Add(Account account)
        {
            return accountDAO.Insert(account);
        }
        public bool CheckLogin(Account loginAccount)
        {
            List<Account> accounts = accountDAO.SelectAll();
            foreach(Account account in accounts)
            {
                if (account.Username == loginAccount.Username && account.Password == loginAccount.Password)
                    return true;
            }
            return false;
        }
    }
}
