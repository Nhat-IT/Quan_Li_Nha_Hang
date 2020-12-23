using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance 
        {
            get
            {
                if (instance == null) instance = new BillInfoDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private BillInfoDAO() { }

        public BillInfo[] GetListBillInfo(int idBill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Thong_Tin_Hoa_Don where ID_Bill = " + idBill);
            BillInfo[] listBillInfor = new BillInfo[data.Rows.Count];
            int i = 0;
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfor[i]=info;
                i++;
            }
            return listBillInfor;
        }

        public void InsertBillInfor(int idBill , int idFood , int count , int GiaHienTai)
        {
            string query = "exec USP_InsertBillInfor @idBill , @idFood , @count , @giahientai";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill, idFood, count , GiaHienTai});
        }

        public int checkMonCanThayDoiCoExist(int idFood, int idBill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Thong_Tin_Hoa_Don where ID_Bill = " + idBill + " and ID_Mon = " + idFood);
            if (data.Rows.Count == 0) return -1; //Món không có trong bill info
            else
            {
                BillInfo info = new BillInfo(data.Rows[0]);
                return info.So_Mon;
            }
        }

        public void deleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("delete Thong_Tin_Hoa_Don where ID_Mon = @idmon", new object[] { id });
        }
    }
}
