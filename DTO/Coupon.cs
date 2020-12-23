using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DTO
{
    public class Coupon
    {
        public Coupon(string ma, string TenCT, int Phan_Tram_Giam, DateTime start, DateTime end)
        {
            this.Ma_Coupon = ma;
            this.Ten_Chuong_Trinh = TenCT;
            this.Phan_Tram_Giam = Phan_Tram_Giam;
            this.Ngay_Bat_Dau = start;
            this.Ngay_Ket_Thuc = end;
        }

        public Coupon(DataRow row)
        {
            this.Ma_Coupon = row["Ma_Coupon"].ToString();
            this.Ten_Chuong_Trinh = row["Ten_Chuong_Trinh_Khuyen_Mai"].ToString();
            this.Phan_Tram_Giam = (int)row["Phan_Tram_Giam"];
            this.Ngay_Bat_Dau = (DateTime)row["Ngay_Bat_Dau"];
            this.Ngay_Ket_Thuc = (DateTime)row["Ngay_Ket_Thuc"];
        }

        private string ma_Coupon;

        private string ten_Chuong_Trinh;

        private int phan_Tram_Giam;

        private DateTime ngay_Bat_Dau;

        private DateTime ngay_Ket_Thuc;

        public string Ma_Coupon { get => ma_Coupon; set => ma_Coupon = value; }
        public string Ten_Chuong_Trinh { get => ten_Chuong_Trinh; set => ten_Chuong_Trinh = value; }
        public int Phan_Tram_Giam { get => phan_Tram_Giam; set => phan_Tram_Giam = value; }
        public DateTime Ngay_Bat_Dau { get => ngay_Bat_Dau; set => ngay_Bat_Dau = value; }
        public DateTime Ngay_Ket_Thuc { get => ngay_Ket_Thuc; set => ngay_Ket_Thuc = value; }
    }
}
