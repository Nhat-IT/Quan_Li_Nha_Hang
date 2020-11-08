using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    class AccountDAO
    {
        public static AccountDAO Instance;

        public static AccountDAO Instance1 { 
            get {
                if (Instance == null) Instance = new AccountDAO();
                return Instance;
            }
            private set { 
                Instance = value; 
            }
        }

        private AccountDAO() { }

        public bool CheckLogin(string userName,string passWord)
        {
            string query = "select * from Nguoi_Quan_Li where Email_Dang_Nhap = @userName and Password = @passWord";
            DataTable result = DataProvider.Instance1.ExecuteQuery(query, new object[] { userName,passWord });
            return result.Rows.Count == 1;
        } 
    }
}
