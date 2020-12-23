﻿using Quan_Li_Nha_Hang.DAO;
using Quan_Li_Nha_Hang.DTO;
using Quan_Li_Nha_Hang.GUI;
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
        BindingSource listKM = new BindingSource();
        private object lsvBill;

        public fAdmin()
        {            
            InitializeComponent();
            dtgvListFood.DataSource = foodList;
            dtgvListAccount.DataSource = listaccount;
            dgvKM.DataSource = listKM;
            LoadListFood();
            LoadAccount();
            LoadCategoryIntoComboBox(cbTen_Loai);
            AddAccount();
            LoadKM();
            AddFoodBinding();
            AddKM();
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

        void LoadKM()
        {
            listKM.DataSource = CouponDAO.Instance.getListCoupon();
        }

        void AddKM()
        {
            txtMCTKM.DataBindings.Add(new Binding("text", dgvKM.DataSource, "Ma_Coupon"));
            txtTCTKM.DataBindings.Add(new Binding("text", dgvKM.DataSource, "Ten_Chuong_Trinh"));
            txtPTG.DataBindings.Add(new Binding("text", dgvKM.DataSource, "Phan_Tram_Giam"));
            timeStart.DataBindings.Add(new Binding("Value", dgvKM.DataSource, "Ngay_Bat_Dau"));
            timeEnd.DataBindings.Add(new Binding("Value", dgvKM.DataSource, "Ngay_Ket_Thuc"));
        }


        void LoadCategoryIntoComboBox(ComboBox cb)
        {
            cbTen_Loai.DataSource = CategoryDAO.Instance.GetListCategory();
            cbTen_Loai.DisplayMember = "Ten_Loai";
        }
        #endregion

        #region event

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
            faddNewFood f = new faddNewFood();
            f.ShowDialog();
            LoadListFood();
        }

        private void ShowBill(int id)
        {
            throw new NotImplementedException();
        }

        private void ShowMonAn(string iD)
        {
            throw new NotImplementedException();
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
                if(updateFood != null)
                {
                    updateFood(this, new EventArgs());
                }
            }
            if (FoodDAO.Instance.ChangeFood(ID_Mon,Ten_Mon, ID_Loai, Tinh_Trang, Gia, Don_Vi_Tinh))
            {
                MessageBox.Show("Sửa thành công");
            }
            else MessageBox.Show("Sửa thất bại");
            LoadListFood();
        }

        private void deleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID_Mon.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xoá Món Thành Công");
                LoadListFood();
                if(deletefood != null)
                {
                    deletefood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xóa Món");
            }
        }

        private void btnThong_Ke_Click(object sender, EventArgs e)
        {
            DateTime date_start = dateStart.Value;
            DateTime date_end = dateEnd.Value;
            dgviewDoanh_Thu.DataSource = BillDAO.Instance.getListBillByDate(date_start, date_end);
        }

        private void btnAddKM_Click(object sender, EventArgs e)
        {
            fAddNewKM KM = new fAddNewKM();
            KM.InsertCoupon += KM_InsertCoupon;
            KM.Show();
        }

        private void KM_InsertCoupon(object sender, EventArgs e)
        {
            LoadKM();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            faddNewAccount formAddNewAccount = new faddNewAccount();
            formAddNewAccount.ShowDialog();
            LoadAccount();
        }

        private event EventHandler deletefood;
        public event EventHandler Deletefood
        {
            add
            {
                deletefood += value;
            }
            remove
            {
                deletefood += value;
            }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add
            {
                updateFood += value;
            }
            remove
            {
                updateFood += value;
            }
        }      

        private void btnDuyetTheoLoaiTang_Click(object sender, EventArgs e)
        {
            string[] list = CategoryDAO.Instance.getListID_Loai();
            int count = (int)DataProvider.Instance.ExecuteScalar("select count(*) from Loai_Thuc_An");
            QuickSortWithLoai(list, 0, count - 1, 2);
            dtgvListFood.DataSource = FoodDAO.Instance.getFoodOneByOneByIDMon(list);
            LoadListFood();
        }

        private void btnLoaiGiamDan_Click(object sender, EventArgs e)
        {
            string[] list = CategoryDAO.Instance.getListID_Loai();
            int count = (int)DataProvider.Instance.ExecuteScalar("select count(*) from Loai_Thuc_An");
            QuickSortWithLoai(list, 0, count - 1, 1);
            dtgvListFood.DataSource = FoodDAO.Instance.getFoodOneByOneByIDMon(list);
            LoadListFood();
        }

        #endregion

        #region algorithm
        public int partition(string[] list, int low, int high, int num)

        {
            string pivot = list[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (compareTwoString(list[j],pivot) == num)
                {
                    i++;
                    string temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            } 
            string temp1 = list[i + 1];
            list[i + 1] = list[high];
            list[high] = temp1;

            return i + 1;
        }

        public void QuickSortWithLoai(string[] list,int first, int last, int num)
        {
            if (first < last)
            {

                int pivot = partition(list, first, last, num);

                QuickSortWithLoai(list, first, pivot - 1, num);
                QuickSortWithLoai(list, pivot + 1, last, num);
            }
        }

        public int compareTwoString(string a,string b)
        {
            int lenghtA = a.Length;
            int lenghtB = b.Length;
            char[] A = a.ToCharArray();
            char[] B = b.ToCharArray();
            int[] A1 = new int[lenghtA];
            int[] B1 = new int[lenghtB];
            int length = lenghtA;
            if (lenghtA > lenghtB) length = lenghtB;
            else if (lenghtA < lenghtB) length = lenghtA;
            for(int i = 0;i < length; i++)
            {
                A1[i] = Convert.ToInt32(A[i]);
                B1[i] = Convert.ToInt32(B[i]);
                if (A1[i] > B1[i] || A1[i] - 32 > B1[i]) return 1;
                else if (A1[i] < B1[i] || B1[i] - 32 > A1[i]) return 2;
                else if (A1[i] == B1[i] || Math.Abs(A1[i] - B1[i]) == 32)
                {
                    if (lenghtA > lenghtB && i == length - 1) return 1;
                    else if (lenghtA < lenghtB && i == length - 1) return 2;
                    else if (lenghtA == lenghtB && i == length - 1) return 0;
                }
            }
            return 3;
        }
        #endregion
    }
}
