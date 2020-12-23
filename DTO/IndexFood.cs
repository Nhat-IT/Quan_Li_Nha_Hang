using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DTO
{
    public class IndexFood
    {
        public IndexFood(int IDmon)
        {
            this.ID_Mon = ID_Mon;
        }

        public IndexFood(DataRow row)
        {
            this.ID_Mon = (int)row["ID_Mon"];
        }

        private int iD_Mon;

        public int ID_Mon { get => iD_Mon; set => iD_Mon = value; }
    }
}
