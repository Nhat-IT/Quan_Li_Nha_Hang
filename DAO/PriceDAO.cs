using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    class PriceDAO
    {
        private static PriceDAO instance;

        internal static PriceDAO Instance
        {
            get
            {
                if (instance == null) instance = new PriceDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private PriceDAO() { }

        public string[] getGia()
        {
            int count = (int)DataProvider.Instance.ExecuteScalar("select count(distinct(Gia)) from Thuc_An");
            string[] list = new string[count];
            DataTable data = DataProvider.Instance.ExecuteQuery("select distinct(Gia) from Thuc_An");
            int i = 0;
            foreach(DataRow item in data.Rows)
            {
                list[i] = new Price(item).Gia.ToString();
                i++;
            }
            return list;
        }
        
        public int[] GiaStringToInt(string[] list)
        {
            int count = (int)DataProvider.Instance.ExecuteScalar("select count(distinct(Gia)) from Thuc_An");
            int[] listGiaInt = new int[count];
            for(int i = 0; i < count; i++)
            {
                listGiaInt[i] = Convert.ToInt32(list[i]);
            }
            return listGiaInt;
        }
    }
}
