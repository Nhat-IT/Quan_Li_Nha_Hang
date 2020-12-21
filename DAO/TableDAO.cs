using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance 
        {
            get 
            {   if (instance == null) instance = new TableDAO();
                return instance; 
            } 
            private set => instance = value; 
        }

        public static int btnWidth = 85;
        public static int btnHeight = 85;

        private TableDAO() { }

        public List<Table> LoadTableList(int Tang)
        {
            List<Table> tableList = new List<Table>();
            string query = "exec USP_SelectBan @Tang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { Tang});

            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
    }
}
