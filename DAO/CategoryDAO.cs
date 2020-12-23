using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private CategoryDAO() { }

        public Category[] GetListCategory()
        {
            string query = "select * from Loai_Thuc_An order by Ten_Loai asc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Category[] listCategory = new Category[data.Rows.Count];

            int i = 0;
            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                listCategory[i]=category;
                i++;
            }
            return listCategory;
        }

        public Category GetCategoryByID(string id)
        {
            Category category = null;
            string query = "select * from Loai_Thuc_An where ID_Loai = '" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }

        public string[] getListID_Loai()
        {
            int count = (int)DataProvider.Instance.ExecuteScalar("select count(*) from Loai_Thuc_An");
            string[] list = new string[count];
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Loai_Thuc_An");
            int i = 0;
            foreach (DataRow item in data.Rows)
            {
                list[i] = new Category(item).ID;
                i++;
            }
            return list;
        }
    }
}
