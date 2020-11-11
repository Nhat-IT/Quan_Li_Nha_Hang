using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DTO
{
    public class Table
    {
        public Table(int id,int tang,int ban,string status)
        {
            this.Id = id;
            this.Tang = tang;
            this.Ban = ban;
            this.Status = status;
        }

        public Table(DataRow row)
        {
            this.Id = (int)row["ID_Ban"];
            this.Tang = (int)row["Tang"];
            this.Ban = (int)row["Ten_Ban"];
            this.status = row["Tinh_Trang_Ban"].ToString();
        }

        private int id;
        public int Id { get => id; set => id = value; }

        private int tang;
        public int Tang { get => tang; set => tang = value; }

        private int ban;
        public int Ban { get => ban; set => ban = value; }

        private string status;
        public string Status { get => status; set => status = value; }

    }
}
