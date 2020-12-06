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
    public partial class faddNewAccount : Form
    {
        public faddNewAccount()
        {
            InitializeComponent();
        }

        private void bthVerify_Click(object sender, EventArgs e)
        {
            List<Account> list = AccountDAO.Instance1.getListAccount();
            bool checkExistEmail = false;
            foreach (Account item in list)
            {
                if (item.Email_Dang_Nhap == txtEmailLogin.Text) checkExistEmail = true;
            }
            if (checkExistEmail == true) MessageBox.Show("Đã tồn tại email này!");
            else
            {
                string EmailLogin = txtEmailLogin.Text;
                string Name = txtName.Text;
                string Sex = txtSex.Text;
                string PhoneNumber = txtPhoneNumber.Text;
                DateTime birthday = Birthday.Value;
                string Address = txtAddress.Text;
                int Tang = (int)numTang_Phuc_Vu.Value;
                string Password = txtNewPassword.Text;
                string passCrypt = BCrypt.Net.BCrypt.HashPassword(Password);
                int admin = (int)numAdmin.Value;
                if (EmailLogin == "" || Name == "" || Sex == "" || PhoneNumber == "" || Address == "" || Password == "")
                {
                    MessageBox.Show("Cần nhập đầy đủ");
                }
                else if (admin == 0 && Tang == 4) MessageBox.Show("Không phải admin số tầng không được là 4");
                else
                {
                    if (MessageBox.Show("Bạn thật sự muốn thêm " + Name + " là admin ?", "Cảnh Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        AccountDAO.Instance1.insertNewAccount(EmailLogin, Name, Sex, PhoneNumber, birthday, Address, Tang, passCrypt, admin);
                        this.Hide();
                    }
                }
            }
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
