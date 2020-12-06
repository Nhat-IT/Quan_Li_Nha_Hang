using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DTO
{
    public class Bill
    {   
        public Bill(int id,DateTime ngayNhap,int id_Ban,bool status,string id_Quan_Li,string ma_Coupon,string ten,string email,string dia_chi_khach,string so_Dien_Thoai,long tong_Tien)
        {
            this.Id = id;
            this.NgayNhap = ngayNhap;
            this.Id_Ban = id_Ban;
            this.Status = status;
            this.Id_Quan_Li = id_Quan_Li;
            this.Ma_Coupon = ma_Coupon;
            this.Ten = ten;
            this.Email = email;
            this.Dia_Chi_Khach = dia_chi_khach;
            this.So_Dien_Thoai = so_Dien_Thoai;
            this.Tong_Tien = tong_Tien;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["ID_Bill"];
            this.NgayNhap = (DateTime)row["Ngay_Nhap"];
            this.Id_Ban = (int)row["ID_Ban"];
            this.Status = (bool)row["Trang_Thai_Thanh_Toan"];
            this.Id_Quan_Li = (string)row["ID_Quan_Li"];
            this.Ma_Coupon = (string)row["Ma_Coupon"];
            this.Ten = (string)row["Ten"];
            this.Email = (string)row["Email"];
            this.So_Dien_Thoai = (string)row["So_Dien_Thoai"];
            this.Dia_Chi_Khach = (string)row["Dia_Chi_Khach"];
            this.Tong_Tien = (long)row["Tong_Tien"];
        }

        private int id;
        public int Id { get => id; set => id = value; }

        private DateTime ngayNhap;
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
       
        private int id_Ban;
        public int Id_Ban { get => id_Ban; set => id_Ban = value; }

        private bool status;
        public bool Status { get => status; set => status = value; }

        private string id_Quan_Li;
        public string Id_Quan_Li { get => id_Quan_Li; set => id_Quan_Li = value; }
        
        private string ma_Coupon;
        public string Ma_Coupon { get => ma_Coupon; set => ma_Coupon = value; }
        
        private string ten;
        public string Ten { get => ten; set => ten = value; }

        private string email;
        public string Email { get => email; set => email = value; }

        private string dia_Chi_Khach;
        public string Dia_Chi_Khach { get => dia_Chi_Khach; set => dia_Chi_Khach = value; }
        
        private string so_Dien_Thoai;
        public string So_Dien_Thoai { get => so_Dien_Thoai; set => so_Dien_Thoai = value; }

        private long tong_Tien;
        public long Tong_Tien { get => tong_Tien; set => tong_Tien = value; }
    }
}
