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

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfor = new List<BillInfo>();

            /*DataTable data = DataProvider.Instance1.ExecuteQuery("select Thuc_An.Ten_Mon, Thong_Tin_Hoa_Don.So_Mon, Thong_Tin_Hoa_Don.Gia_Hien_Tai, Thong_Tin_Hoa_Don.Gia_Hien_Tai * Thong_Tin_Hoa_Don.So_Mon as Tong_Tien  from Thuc_An, Thong_Tin_Hoa_Don, Ban, Hoa_Don where Hoa_Don.ID_Bill=Thong_Tin_Hoa_Don.ID_Bill and Thong_Tin_Hoa_Don.ID_Mon = Thuc_An.ID_Mon and Ban.ID_Ban = " + id);

            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfor.Add(info);
            }*/

            return listBillInfor;
        }
    }
}
