using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    class IndexFoodDAO
    {
        private static IndexFoodDAO instance;

        internal static IndexFoodDAO Instance 
        {
            get
            {
                if (instance == null) instance = new IndexFoodDAO();
                return instance;
            }
            private set => instance = value; 
        }
        private IndexFoodDAO() { }

        public int getIndexHole()
        {
            int count = (int)DataProvider.Instance.ExecuteScalar("select count(*) from Thuc_An");
            if (count == 0) return 1;
            int max = (int)DataProvider.Instance.ExecuteScalar("select max(ID_Mon) from Thuc_An");            
            IndexFood[] list = new IndexFood[count + 1];
            DataTable data = DataProvider.Instance.ExecuteQuery("select ID_Mon from Thuc_An");            
            int i = 1;
            foreach(DataRow item in data.Rows)
            {
                list[i] = new IndexFood(item);
                i++;
            }
            for(int j = 1; j <= max; j++)
            {
                if (list[j].ID_Mon != j) return j;
            }
            return max + 1;
        }
    }
}
