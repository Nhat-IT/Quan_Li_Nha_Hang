using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DTO
{
    public class Menu
    {
        private Menu(string foodName,int count, int donGia, int tongTien)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.DonGia = donGia;
            this.TongTien = tongTien;
        }

        public Menu(DataRow row)
        {
            this.FoodName = row["Ten_Mon"].ToString();
            this.Count = (int)row["So_Mon"];
            this.DonGia = (int)row["Gia_Hien_Tai"];
            this.TongTien = (int)row["Tong_Tien"];
        }

        private int tongTien;
        public int TongTien { get => tongTien; set => tongTien = value; }
        private int donGia;
        public int DonGia { get => donGia; set => donGia = value; }

        private int count;
        public int Count { get => count; set => count = value; }

        private string foodName;
        public string FoodName { get => foodName; set => foodName = value; }
    }
}
