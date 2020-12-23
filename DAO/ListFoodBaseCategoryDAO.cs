using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    public class ListFoodBaseCategoryDAO
    {
        public static ListFoodBaseCategoryDAO instance;

        public static ListFoodBaseCategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new ListFoodBaseCategoryDAO();
                return instance;

            }
            private set
            {
                instance = value;
            }
        }

        private ListFoodBaseCategoryDAO() { }

        public ListFoodBaseCategory[] getListFoodBaseCategory(string ID_Mon)
        {
            string query = "select Ten_Mon, Tinh_Trang, Gia from Thuc_An where ID_Loai = @ID_Mon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ID_Mon });
            ListFoodBaseCategory[] listFood = new ListFoodBaseCategory[data.Rows.Count];

            int i = 0;
            int count = data.Rows.Count;
            foreach(DataRow item in data.Rows)
            {
                ListFoodBaseCategory food = new ListFoodBaseCategory(item);
                listFood[i]=food;
                i++;
            }
            return listFood;
        }
    }
}
