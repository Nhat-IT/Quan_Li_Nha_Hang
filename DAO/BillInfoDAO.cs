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

        public List<BillInfo> GetListBillInfo(int idBill)
        {
            List<BillInfo> listBillInfor = new List<BillInfo>();
            DataTable data = DataProvider.Instance1.ExecuteQuery("select * from Thong_Tin_Hoa_Don where ID_Bill = " + idBill);
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfor.Add(info);
            }
            return listBillInfor;
        }

        public void InsertBillInfor(int idBill , int idFood , int count , int GiaHienTai)
        {
            string query = "exec USP_InsertBillInfor @idBill , @idFood , @count , @giahientai";
            DataProvider.Instance1.ExecuteNonQuery(query, new object[] { idBill, idFood, count , GiaHienTai});
        }

        public int checkMonCanThayDoiCoExist(int idFood, int idBill)
        {
            DataTable data = DataProvider.Instance1.ExecuteQuery("select * from Thong_Tin_Hoa_Don where ID_Bill = " + idBill + " and ID_Mon = " + idFood);
            if (data.Rows.Count == 0) return -1; //Món không có trong bill info
            else
            {
                BillInfo info = new BillInfo(data.Rows[0]);
                return info.So_Mon;
            }
        }
    }
}
