using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DTO
{
    public class Food
    {
        public Food(int id_Mon,string ten_Mon,string iD_Loai,string tinh_Trang,int gia,string don_Vi_Tinh)
        {
            this.ID_Mon = id_Mon;
            this.Ten_Mon = ten_Mon;
            this.ID_Loai = iD_Loai;
            this.Tinh_Trang = tinh_Trang;
            this.Gia = gia;
            this.Don_Vi_Tinh = don_Vi_Tinh;
        }

        public Food(DataRow row)
        {
            this.ID_Mon = (int)row["ID_Mon"];
            this.Ten_Mon = row["Ten_Mon"].ToString();
            this.ID_Loai = row["ID_Loai"].ToString();
            this.Tinh_Trang = row["Tinh_Trang"].ToString();
            this.Gia = (int)row["Gia"];
            this.Don_Vi_Tinh = row["Don_Vi_Tinh"].ToString();
        }

        private int iD_Mon;
        public int ID_Mon { get => iD_Mon; set => iD_Mon = value; }

        private string ten_Mon;
        public string Ten_Mon { get => ten_Mon; set => ten_Mon = value; }

        private string iD_Loai;
        public string ID_Loai { get => iD_Loai; set => iD_Loai = value; }

        private string tinh_Trang;
        public string Tinh_Trang { get => tinh_Trang; set => tinh_Trang = value; }    

        private int gia;
        public int Gia { get => gia; set => gia = value; }

        private string don_Vi_Tinh;
        public string Don_Vi_Tinh { get => don_Vi_Tinh; set => don_Vi_Tinh = value; }

    }
}
