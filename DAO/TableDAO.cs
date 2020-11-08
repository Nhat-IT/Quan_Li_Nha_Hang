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

        private TableDAO() { }

        /*public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance1.ExecuteQuery("select * from Ban");

            return tableList;
        }*/
    }
}
