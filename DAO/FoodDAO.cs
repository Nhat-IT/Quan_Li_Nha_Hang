using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private FoodDAO() { }

        public List<Food> GetListFoodByCategoryID(string id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from Thuc_An where ID_Loai = @";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query, new object[] { id });
            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
    }
}
