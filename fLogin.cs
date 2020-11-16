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
            if (Email_Login.Text == "Email Đăng Nhập")
            {
                Email_Login.Text = "";
                Email_Login.ForeColor = Color.Black;
            }
        }

        private void Email_Login_Leave(object sender, EventArgs e)
        {
            if (Email_Login.Text == "")
            {
                Email_Login.Text = "Email Đăng Nhập";
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
            if(MessageBox.Show("Bạn thật sự muốn thoát ?","Thông Báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnDang_Nhap_Click(object sender, EventArgs e)
        {
            string userName = Email_Login.Text;
            string passWord = Pass_Login.Text;
            if (CheckLogin(userName,passWord))
            {
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

        bool CheckLogin(string userName,string passWord)
        {
            return AccountDAO.Instance1.CheckLogin(userName, passWord);
        }
    }
}

