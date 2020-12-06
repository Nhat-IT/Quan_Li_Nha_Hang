﻿using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    class AccountDAO
    {
        public static AccountDAO Instance;

        public static AccountDAO Instance1 { 
            get {
                if (Instance == null) Instance = new AccountDAO();
                return Instance;
            }
            private set { 
                Instance = value; 
            }
        }

        private AccountDAO() { }

        public bool CheckLogin(string userName,string passWord)
        {
            string query = "select * from Nguoi_Quan_Li where Email_Dang_Nhap = @userName and Password = @passWord";
            DataTable result = DataProvider.Instance1.ExecuteQuery(query, new object[] { userName,passWord });
            return result.Rows.Count == 1;
        }
        public string GetMaNhanVien()
        {
            DataTable data = DataProvider.Instance1.ExecuteQuery("select * from Nguoi_Quan_Li where Trang_Thai_Dang_Nhap = 1");
            Account manager = new Account(data.Rows[0]);
            return manager.ID_Quan_Li;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance1.ExecuteQuery("select * from Nguoi_Quan_Li where Email_Dang_Nhap = '" + userName + "'");
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool updateProfile(string emailLogin,string ten,string diaChi,string soDienThoai,string gioiTinh,string pass,DateTime birthday,int TangPhucVu)
        {
            int count = DataProvider.Instance1.ExecuteNonQuery("exec USP_UpdateProfile @emailLogin , @ten , @diaChi , @gioiTinh , @birthday , @soDienThoai , @pass , @tangPhucVu ", new object[] { emailLogin, ten, diaChi, gioiTinh, birthday, soDienThoai, pass, TangPhucVu });
            return count > 0;
        }

        public bool updatePass(string email_dang_nhap,string mk_cu,string mk_moi)
        {
            int count =  DataProvider.Instance1.ExecuteNonQuery("update Nguoi_Quan_Li set Password = " + mk_moi + " where Email_Dang_Nhap = '" + email_dang_nhap + "' and Password = " + mk_cu);
            return count > 0;
        }

        public int getTang()
        {
            int Tang;
            DataTable data = DataProvider.Instance1.ExecuteQuery("select * from Nguoi_Quan_Li where Trang_Thai_Dang_Nhap = 1");
            Account account = new Account(data.Rows[0]);
            Tang = account.Tang;
            return Tang;
        }

        public void updateLogin(string user,string pass)
        {
            DataProvider.Instance1.ExecuteNonQuery("update Nguoi_Quan_Li set Trang_Thai_Dang_Nhap = 0");
            DataProvider.Instance1.ExecuteNonQuery("update Nguoi_Quan_Li set Trang_Thai_Dang_Nhap = 1 where Email_Dang_Nhap = @user and Password = @pass", new object[] { user, pass });
        }

        public void updateLogout()
        {
            DataProvider.Instance1.ExecuteNonQuery("update Nguoi_Quan_Li set Trang_Thai_Dang_Nhap = 0");
        }

        public List<Account> getListAccount()
        {
            List<Account> list = new List<Account>();
            DataTable table = DataProvider.Instance1.ExecuteQuery("select * from Nguoi_Quan_Li");
            foreach(DataRow item in table.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }
            return list;
        }
    }
}