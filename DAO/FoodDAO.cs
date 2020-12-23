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

        public Food[] GetListFoodByCategoryID(string id)
        {
            string query = "select * from Thuc_An where ID_Loai = @ order by Ten_Mon asc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            Food[] listFoodByCategory = new Food[data.Rows.Count];

            int i = 0;
            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFoodByCategory[i]=food;
                i++;
            }
            return listFoodByCategory;
        }

        public int GetGiaHienTai(int idFood)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Thuc_AN where ID_Mon = " + idFood);
            Food food = new Food(data.Rows[0]);
            return food.Gia;
        }

        public Food[] GetListFood()
        {
            string query = "select * from Thuc_An";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Food[] listFood = new Food[data.Rows.Count];

            int i = 0;
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood[i]=food;
                i++;
            }
            return listFood;
        }

        public string GetTenLoaibyIDMon(int ID_Mon)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Thuc_An where ID_Mon = " + ID_Mon);
            Food food = new Food(data.Rows[0]);
            return food.ID_Loai;
        }

        public bool AddFood(string Ten_Mon,string ID_Loai,string Tinh_Trang,int Gia,string Don_Vi_Tinh)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("exec USP_AddFoodInAdmin @Ten_Mon , @ID_Loai , @Tinh_Trang , @Gia , @Don_Vi_Tinh ", new object[] { Ten_Mon, ID_Loai, Tinh_Trang, Gia, Don_Vi_Tinh });
            return count > 0;
        }

        public bool ChangeFood(int ID_Mon,string Ten_Mon, string ID_Loai, string Tinh_Trang, int Gia, string Don_Vi_Tinh)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("exec USP_ChangeFoodInAdmin @ID_Mon , @Ten_Mon , @ID_Loai , @Tinh_Trang , @Gia , @Don_Vi_Tinh ", new object[] { ID_Mon, Ten_Mon, ID_Loai, Tinh_Trang, Gia, Don_Vi_Tinh });
            return count > 0;
        }

        public int getIdMonByTenMonAndGia(string TenMon,int Gia)
        {
            string query = "select * from Thuc_An where Ten_Mon = @tenmon and Gia = @gia";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenMon, Gia });
            if(data.Rows.Count > 0)
            {
                Food food = new Food(data.Rows[0]);
                return food.ID_Mon;
            }
            return -1;
        }
    }
}
