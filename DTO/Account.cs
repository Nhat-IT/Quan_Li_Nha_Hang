using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DTO
{
    public class Account
    {
        public Account(string iD_Quan_Li , string ten , string dia_Chi, string gioi_Tinh, DateTime ngay_Sinh, string so_Dien_Thoai, string email, string pass = null,int chu_Quan = 0 ,bool status = false, int tang = -1)
        {
            this.ID_Quan_Li = iD_Quan_Li;
            this.Ten = ten;
            this.Dia_Chi = dia_Chi;
            this.Gioi_Tinh = gioi_Tinh;
            this.Ngay_Sinh = ngay_Sinh;
            this.So_Dien_Thoai = so_Dien_Thoai;
            this.Email_Dang_Nhap = email;
            this.PassWord = pass;
            this.Chu_Quan = chu_Quan;
            this.Trang_Thai_Dang_Nhap = trang_Thai_Dang_Nhap;
            this.Tang = tang;
        }

        public Account(DataRow row)
        {
            this.ID_Quan_Li = row["ID_Quan_Li"].ToString();
            this.Ten = row["Ten"].ToString();
            this.Dia_Chi = row["Dia_Chi"].ToString();
            this.Gioi_Tinh = row["Gioi_Tinh"].ToString();
            this.Ngay_Sinh = (DateTime)row["Ngay_Sinh"];
            this.So_Dien_Thoai = row["So_Dien_Thoai"].ToString();
            this.Email_Dang_Nhap = row["Email_Dang_Nhap"].ToString();
            this.PassWord = row["Password"].ToString();
            this.Chu_Quan = (int)row["Chu_Quan"];
            this.Trang_Thai_Dang_Nhap = (bool)row["Trang_Thai_Dang_Nhap"];
            this.Tang = (int)row["Tang"];
        }

        private string iD_Quan_Li;
        public string ID_Quan_Li { get => iD_Quan_Li; set => iD_Quan_Li = value; }

        private string ten;
        public string Ten { get => ten; set => ten = value; }

        private string dia_Chi;
        public string Dia_Chi { get => dia_Chi; set => dia_Chi = value; }

        private string gioi_Tinh;
        public string Gioi_Tinh { get => gioi_Tinh; set => gioi_Tinh = value; }

        private DateTime ngay_Sinh;
        public DateTime Ngay_Sinh { get => ngay_Sinh; set => ngay_Sinh = value; }

        private string so_Dien_Thoai;
        public string So_Dien_Thoai { get => so_Dien_Thoai; set => so_Dien_Thoai = value; }

        private string email_Dang_Nhap;
        public string Email_Dang_Nhap { get => email_Dang_Nhap; set => email_Dang_Nhap = value; }

        private string passWord;
        public string PassWord { get => passWord; set => passWord = value; }

        private int chu_Quan;
        public int Chu_Quan { get => chu_Quan; set => chu_Quan = value; }

        private bool trang_Thai_Dang_Nhap;
        public bool Trang_Thai_Dang_Nhap { get => trang_Thai_Dang_Nhap; set => trang_Thai_Dang_Nhap = value; }

        private int tang;
        public int Tang { get => tang; set => tang = value; }
    }
}