using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DTO
{
    public class Category
    {
        public Category(string id,string tenloai)
        {
            this.ID = id;
            this.Ten_Loai = tenloai;
        }

        public Category(DataRow row)
        {
            this.ID = row["ID_Loai"].ToString();
            this.Ten_Loai = row["Ten_Loai"].ToString();
        }

        private string ten_Loai;
        public string Ten_Loai { get => ten_Loai; set => ten_Loai = value; }

        private string iD;
        public string ID { get => iD; set => iD = value; }
    }
}
