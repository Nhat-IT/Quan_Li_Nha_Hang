using Quan_Li_Nha_Hang.DAO;
using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Nha_Hang
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private void Email_Login_Enter(object sender, EventArgs e)
        {
            if (Email_Login.Text == "Email Login")
            {
                Email_Login.Text = "";
                Email_Login.ForeColor = Color.Black;
            }
        }

        private void Email_Login_Leave(object sender, EventArgs e)
        {
            if (Email_Login.Text == "")
            {
                Email_Login.Text = "Email Login";
                Email_Login.ForeColor = Color.Silver;
            }
        }

        private void Pass_Login_Enter(object sender, EventArgs e)
        {
            if (Pass_Login.Text == "Password")
            {
                Pass_Login.Text = "";
                Pass_Login.ForeColor = Color.Black;
            }
        }

        private void Pass_Login_Leave(object sender, EventArgs e)
        {
            if (Pass_Login.Text == "")
            {
                Pass_Login.Text = "Password";
                Pass_Login.ForeColor = Color.Silver;
            }
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnDang_Nhap_Click(object sender, EventArgs e)
        {
            string userName = Email_Login.Text;
            string pass = Pass_Login.Text;
            if (CheckLogin(userName,pass))
            {
                AccountDAO.Instance.updateLogin(userName);
                Account account = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(account);
                this.Hide();                
                f.ShowDialog();
                this.Show();
                Email_Login.Text = "";
                Pass_Login.Text = "";
            }
            else MessageBox.Show("Sai Tên Tài Khoản Hoặc Mật Khẩu", "Cảnh Báo Đăng Nhập");
           
        }

        bool CheckLogin(string userName,string passEncrypt)
        {
            return AccountDAO.Instance.CheckLogin(userName, passEncrypt);
        }

        private void addNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Query = "select count(*) from Nguoi_Quan_Li where Chu_Quan = 1";
            int Count = (int)DataProvider.Instance.ExecuteScalar(Query);
            faddNewAccount Account = new faddNewAccount();
            if (Count == 0) Account.Show();
            else MessageBox.Show("Đã Tồn Tại Tài Khoản Admin", "Cảnh Báo");
        }
    }
}

