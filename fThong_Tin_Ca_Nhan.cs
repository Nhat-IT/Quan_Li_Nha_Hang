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
    public partial class fThong_Tin_Ca_Nhan : Form
    {
        private Account account;

        public Account Account
        {
            get => account;
            set
            {
                account = value;
                ChangeAccount(account);
            }
        }

        public fThong_Tin_Ca_Nhan(Account acc)
        {
            InitializeComponent();
            Account = acc;
        }

        void ChangeAccount(Account account)
        {
            profileTen.Text = account.Ten;
            profileEmail.Text = account.Email_Dang_Nhap;
            profileDiaChi.Text = account.Dia_Chi;
            profileSDT.Text = account.So_Dien_Thoai;
            if (account.Gioi_Tinh == "Nam") Nam.Checked = true;
            else if (account.Gioi_Tinh == "Nữ") Nu.Checked = true;
            else Gioi_Tinh_Khac.Checked = true;
            Birthday.Value = account.Ngay_Sinh;
        }

        void ChangePass()
        {
            string mk_cu = MK_Cu.Text;
            string mk_moi = MK_Moi.Text;
            string xac_nhan_mk = Xac_Nhan_MK.Text;
            string email_dang_nhap = profileEmail.Text;
            if (mk_moi.Equals(xac_nhan_mk))
            {
                if(AccountDAO.Instance1.updatePass(email_dang_nhap, mk_cu, mk_moi))
                    MessageBox.Show("Cập nhập thành công");
            }
            else MessageBox.Show("Sai mật khẩu rùi !");
        }

        void UpdateProfile()
        {
            string emailLogin = profileEmail.Text;
            string ten = profileTen.Text;
            string diaChi = profileDiaChi.Text;
            string soDienThoai = profileSDT.Text;
            string gioiTinh;
            if (Nam.Checked == true) gioiTinh = "Nam";
            else if (Nu.Checked == true) gioiTinh = "Nữ";
            else gioiTinh = "Giới tính khác";
            string pass = CheckPass.Text;
            DateTime birthday = Birthday.Value;
            if (account.PassWord.Equals(pass))
            {
                if (AccountDAO.Instance1.updateProfile(emailLogin, ten, diaChi, soDienThoai, gioiTinh, pass, birthday))
                    MessageBox.Show("Cập nhập thành công");
            }
            else MessageBox.Show("Sai mật khẩu rùi !");
        }

        private void Tro_Lai_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            UpdateProfile();
        }

        private void Nu_Click(object sender, EventArgs e)
        {
            if(Nam.Checked == true || Gioi_Tinh_Khac.Checked == true)
            {
                Nam.Checked = false;
                Nu.Checked = true;
                Gioi_Tinh_Khac.Checked = false;
            }
        }

        private void Nam_Click(object sender, EventArgs e)
        {
            if (Nu.Checked == true || Gioi_Tinh_Khac.Checked == true)
            {
                Nu.Checked = false;
                Nam.Checked = true;
                Gioi_Tinh_Khac.Checked = false;
            }
        }

        private void Gioi_Tinh_Khac_Click(object sender, EventArgs e)
        {
            if (Nu.Checked == true || Nam.Checked == true)
            {
                Nu.Checked = false;
                Nam.Checked = false;
                Gioi_Tinh_Khac.Checked = true;
            }
        }

        private void Cap_Nhat_Click(object sender, EventArgs e)
        {
            ChangePass();
        }
    }
}
