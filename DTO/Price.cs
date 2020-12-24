using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DTO
{
    class Price
    {
        public Price(long gia)
        {
            this.Gia = gia;
        }

        public Price(DataRow row)
        {
            this.Gia = (int)row["Gia"];
        }


        private long gia;

        public long Gia { get => gia; set => gia = value; }
    }
}
