using Quan_Li_Nha_Hang.DAO;
using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Nha_Hang
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource listaccount = new BindingSource();
        public fAdmin()
        {            
            InitializeComponent();
            dtgvListFood.DataSource = foodList;
            dtgvListAccount.DataSource = listaccount;
            LoadListFood();
            LoadAccount();
            LoadCategoryIntoComboBox(cbTen_Loai);
            AddAccount();
            AddFoodBinding();
        }

        #region method
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        void AddFoodBinding()
        {
            txtID_Mon.DataBindings.Add(new Binding("text", dtgvListFood.DataSource, "ID_Mon"));
            txtTen_Mon.DataBindings.Add(new Binding("text", dtgvListFood.DataSource, "Ten_Mon"));
            txtDon_Vi_Tinh.DataBindings.Add(new Binding("text", dtgvListFood.DataSource, "Don_Vi_Tinh"));
            txtTinhTrang.DataBindings.Add(new Binding("text", dtgvListFood.DataSource, "Tinh_Trang"));
            nmGia.DataBindings.Add(new Binding("Value", dtgvListFood.DataSource, "Gia"));
        }

        void LoadAccount()
        {
             listaccount.DataSource =   AccountDAO.Instance.getListAccount();
        }

        void AddAccount()
        {
            txtEmailLogin.DataBindings.Add(new Binding("text", dtgvListAccount.DataSource, "Email_Dang_Nhap"));
            txtName.DataBindings.Add(new Binding("text", dtgvListAccount.DataSource, "Ten"));
            txtSex.DataBindings.Add(new Binding("text", dtgvListAccount.DataSource, "Gioi_Tinh"));
            txtPhoneNumber.DataBindings.Add(new Binding("text", dtgvListAccount.DataSource, "So_Dien_Thoai"));
            Birthday.DataBindings.Add(new Binding("Value", dtgvListAccount.DataSource, "Ngay_Sinh"));
            txtAddress.DataBindings.Add(new Binding("text", dtgvListAccount.DataSource, "Dia_Chi"));
            numTang_Phuc_Vu.DataBindings.Add(new Binding("value", dtgvListAccount.DataSource, "Tang"));
            numAdmin.DataBindings.Add(new Binding("value", dtgvListAccount.DataSource, "Chu_Quan"));
        }



        void LoadCategoryIntoComboBox(ComboBox cb)
        {
            cbTen_Loai.DataSource = CategoryDAO.Instance.GetListCategory();
            cbTen_Loai.DisplayMember = "Ten_Loai";
        }
        #endregion

        private void Xem_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txtID_Mon_TextChanged(object sender, EventArgs e)
        {
                int ID_Mon = Int32.Parse((sender as TextBox).Text);
                string ID_Loai = FoodDAO.Instance.GetTenLoaibyIDMon(ID_Mon);
                Category category = CategoryDAO.Instance.GetCategoryByID(ID_Loai);
                cbTen_Loai.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach(Category item in cbTen_Loai.Items)
                {
                    if(item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbTen_Loai.SelectedIndex = index;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Ten_Mon = txtTen_Mon.Text;
            string ID_Loai = (cbTen_Loai.SelectedItem as Category).ID;
            string Tinh_Trang = txtTinhTrang.Text;
            int Gia = (int)nmGia.Value;
            string Don_Vi_Tinh = txtDon_Vi_Tinh.Text;
            if (FoodDAO.Instance.AddFood(Ten_Mon, ID_Loai, Tinh_Trang, Gia, Don_Vi_Tinh))
            {
                MessageBox.Show("Thêm thành công");
            }
            else MessageBox.Show("Thêm thất bại");

            LoadListFood();

         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Ten_Mon = txtTen_Mon.Text;
            string ID_Loai = (cbTen_Loai.SelectedItem as Category).ID;
            string Tinh_Trang = txtTinhTrang.Text;
            int Gia = (int)nmGia.Value;
            string Don_Vi_Tinh = txtDon_Vi_Tinh.Text;
            int ID_Mon = Int32.Parse(txtID_Mon.Text);
            if (Ten_Mon == "" || ID_Loai == "" || Tinh_Trang == "" || Don_Vi_Tinh == "") 
            { 
                MessageBox.Show("Nhập đầy đủ để thêm!");
                return;
            }
            if (FoodDAO.Instance.ChangeFood(ID_Mon,Ten_Mon, ID_Loai, Tinh_Trang, Gia, Don_Vi_Tinh))
            {
                MessageBox.Show("Sửa thành công");
            }
            else MessageBox.Show("Sửa thất bại");
            LoadListFood();
        }

        private void btnThong_Ke_Click(object sender, EventArgs e)
        {
            DateTime date_start = dateStart.Value;
            DateTime date_end = dateEnd.Value;
            dgviewDoanh_Thu.DataSource = BillDAO.Instance.getListBillByDate(date_start, date_end);
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void Gioi_Tinh_Khac_Click(object sender, EventArgs e)
        {

        }

        private void Nam_Click(object sender, EventArgs e)
        {

        }

        private void Nu_Click(object sender, EventArgs e)
        {

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            faddNewAccount formAddNewAccount = new faddNewAccount();
            formAddNewAccount.ShowDialog();
            LoadAccount();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTen_Mon_TextChanged(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tabThuc_An_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void tabTai_Khoan_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
