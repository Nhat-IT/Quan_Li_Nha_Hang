using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get
            {
                if (instance == null) instance = new MenuDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private MenuDAO() { }

        public List<Menu> GetListMenuByID(int id)
        {
            string query = ("select TL.Ten_Loai, TA.Ten_Mon, TTHD.So_Mon, TTHD.Gia_Hien_Tai, TTHD.Gia_Hien_Tai * TTHD.So_Mon as Tong_Tien  from Loai_Thuc_An as TL, Thuc_An as TA, Thong_Tin_Hoa_Don as TTHD, Hoa_Don as HD where HD.Trang_Thai_Thanh_Toan = 0 and HD.ID_Bill = TTHD.ID_Bill and TTHD.ID_Mon = TA.ID_Mon and TL.ID_Loai = TA.ID_Loai and HD.ID_Ban = " + id);
            List<Menu> listMenu = new List<Menu>();

            DataTable data = DataProvider.Instance1.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;

        }
    }
}
