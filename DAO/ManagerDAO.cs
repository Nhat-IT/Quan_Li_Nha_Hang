using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    public class ManagerDAO
    {
        private static ManagerDAO instance;

        public static ManagerDAO Instance
        {
            get
            {
                if (instance == null) instance = new ManagerDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private ManagerDAO() { }

        public string GetMaNhanVien()
        {
            DataTable data = DataProvider.Instance1.ExecuteQuery("select * from Nguoi_Quan_Li where Trang_Thai_Dang_Nhap = 1");
            Manager manager = new Manager(data.Rows[0]);
            return manager.ID_Quan_Li;
        }
    }
}
