using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO();
                return instance;

            }
            private set
            {
                instance = value;
            }
        }
        private BillDAO() { }

        public int GetUncheckBillIByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Hoa_Don where ID_Ban = " + id + "and Trang_Thai_Thanh_Toan = 0");
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }

        public void CheckOut(int id)
        {
            string query = ("update Hoa_Don set Trang_Thai_Thanh_Toan = 1, Ngay_Xuat = GETDATE() where ID_Bill = " + id+ " ");
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void InsertBill(int idBan,string maNhanVien)
        {
            string query = "exec USP_InsertBill @idBan , @maNhanVien ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBan, maNhanVien });
        }

        public Bill[] getListBillByDate(DateTime dateStart,DateTime dateEnd)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_getListBillByDate @start , @end ", new object[]{dateStart,dateEnd });
            Bill[] listBill = new Bill[data.Rows.Count];
            int i = 0;
            foreach(DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                listBill[i]=bill;
                i++;
            }
            return listBill;
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(ID_Bill) from Hoa_Don");
            }
            catch
            {
                return 1;
            }
            
        }
    }
}
