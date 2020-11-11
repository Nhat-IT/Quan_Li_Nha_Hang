using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DTO
{
    public class BillInfo
    {
        public BillInfo(int iD_Bill,int id_Mon,int so_Mon,int gia_Hien_Tai,int tong_Tien)
        {
            this.ID_Bill = iD_Bill;
            this.ID_Mon = id_Mon;
            this.So_Mon = so_Mon;
            this.Gia_Hien_Tai = gia_Hien_Tai;
            this.Tong_Tien = tong_Tien;
        }

        public BillInfo(DataRow row)
        {
            this.ID_Bill = (int)row["ID_Bill"];
            this.ID_Mon = (int)row["ID_Mon"];
            this.So_Mon = (int)row["So_Mon"];
            this.Gia_Hien_Tai = (int)row["Gia_Hien_Tai"];
            this.Tong_Tien = (int)row["Tong_Tien_Mon"];
        }

        private int iD_Bill;

        public int ID_Bill { get => iD_Bill; set => iD_Bill = value; }

        private int iD_Mon;
        public int ID_Mon { get => iD_Mon; set => iD_Mon = value; }

        private int so_Mon;
        public int So_Mon { get => so_Mon; set => so_Mon = value; }

        private int gia_Hien_Tai;
        public int Gia_Hien_Tai { get => gia_Hien_Tai; set => gia_Hien_Tai = value; }

        private int tong_Tien;
        public int Tong_Tien { get => tong_Tien; set => tong_Tien = value; }
    }
}
