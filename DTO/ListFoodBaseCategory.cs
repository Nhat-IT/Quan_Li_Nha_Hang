using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DTO
{
    public class ListFoodBaseCategory
    {
        public ListFoodBaseCategory(string TenMon,string TinhTrang,int Gia)
        {
            this.tenMon = TenMon;
            this.tinhTrang = TinhTrang;
            this.gia = Gia;
        }

        public ListFoodBaseCategory(DataRow row)
        {
            this.tenMon = row["Ten_Mon"].ToString();
            this.tinhTrang = row["Tinh_Trang"].ToString();
            this.gia = (int)row["Gia"];
        }

        private string tenMon;
        public string TenMon { get => tenMon; set => tenMon = value; }

        private string tinhTrang;
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        private int gia;
        public int Gia { get => gia; set => gia = value; }

    }
}
