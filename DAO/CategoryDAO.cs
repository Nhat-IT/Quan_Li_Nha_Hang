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

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from Loai_Thuc_An order by Ten_Loai asc";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }

        public Category GetCategoryByID(string id)
        {
            Category category = null;
            string query = "select * from Loai_Thuc_An where ID_Loai = '" + id + "'";
            DataTable data = DataProvider.Instance1.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }


    }
}
