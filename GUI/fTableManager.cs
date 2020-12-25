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
using Menu = Quan_Li_Nha_Hang.DTO.Menu;

namespace Quan_Li_Nha_Hang
{
    public partial class fTableManager : Form
    {
        private Account account;
        BindingSource food_List = new BindingSource();
        public Account Account 
        { 
            get => account;
            set 
            { 
                account = value;
                ChangeAccount(account.Chu_Quan);        
            } 
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();            
            this.Account = acc;
            dgvListFoodBaseCategory.DataSource = food_List;
            LoadTable();
            LoadCategory();
            addMonAn();
        }

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1; 
        }

        #region Method
        void LoadCategory()
        {
            
            cbLoai_Mon_An.DataSource = CategoryDAO.Instance.GetListCategory();
            cbLoai_Mon_An.DisplayMember = "Ten_Loai";
        }


        private void LoadTable(int IDBill = 0)
        {
            flpTable.Controls.Clear();
            int Tang = AccountDAO.Instance.getTang();
            Table table = lsvBill.Tag as Table;
            TimeNow.Value = DateTime.Now;
            if (table != null) txtBan.Text = table.Ban.ToString();
            else 
            {
                txtBan.Text = "Chưa chọn bàn !";
            }

            Table[] listTable = new Table[TableDAO.Instance.LoadTableList(Tang).Length];
            TableDAO.Instance.LoadTableList(Tang).CopyTo(listTable, 0);

            for (int i=0;i<listTable.Length; i++)
            {
                Button btn = new Button() { Width = TableDAO.btnWidth, Height = TableDAO.btnHeight };
                btn.Text = listTable[i].Ban + Environment.NewLine + listTable[i].Status;
                btn.Click += Btn_Click;
                btn.Tag = listTable[i];
                if (listTable[i].Status == "Có Người")
                {
                    btn.BackColor = Color.LightSteelBlue;
                }
                else
                {
                    btn.BackColor = Color.Beige;
                }
                flpTable.Controls.Add(btn);                
            }
        }
        void ShowBill(int ID,int IDBill = 0)
        {
            long tongCongTien = 0;
            lsvBill.Items.Clear();          
            for (int i=0;i<MenuDAO.Instance.GetListMenuByID(ID).Length;i++)
            {
                string TenMonVaLoai = MenuDAO.Instance.GetListMenuByID(ID)[i].TenLoai.ToString()+ " : " + MenuDAO.Instance.GetListMenuByID(ID)[i].FoodName.ToString();
                ListViewItem lsvItem = new ListViewItem(TenMonVaLoai);
                lsvItem.SubItems.Add(MenuDAO.Instance.GetListMenuByID(ID)[i].Count.ToString());
                lsvItem.SubItems.Add(MenuDAO.Instance.GetListMenuByID(ID)[i].DonGia.ToString());
                lsvItem.SubItems.Add(MenuDAO.Instance.GetListMenuByID(ID)[i].TongTien.ToString());
                tongCongTien += MenuDAO.Instance.GetListMenuByID(ID)[i].TongTien;
                lsvBill.Items.Add(lsvItem);
            }
            int Phan_Tram_Giam = CouponDAO.Instance.getPhanTramGiam();
            double PTGinText = Phan_Tram_Giam / 100.0;
            txtPTG.Text = PTGinText.ToString(".%");
            double tongCongTienSauKM = tongCongTien - tongCongTien * (double)(Phan_Tram_Giam / 100.0);
            TotalSauKM.Text = tongCongTienSauKM.ToString("c");
            nmFoodCount.Value = 0;
            Total.Text = tongCongTien.ToString("c");
            Total.ForeColor = Color.Red;
            LoadTable();
        }

        void ShowMonAn(string id)
        {
            food_List.DataSource = ListFoodBaseCategoryDAO.Instance.getListFoodBaseCategory(id);
        }

        void addMonAn()
        {
            txtTenMon.DataBindings.Add(new Binding("text", dgvListFoodBaseCategory.DataSource, "TenMon"));
            txtTinhTrang.DataBindings.Add(new Binding("text", dgvListFoodBaseCategory.DataSource, "TinhTrang"));
            txtGiaHienTai.DataBindings.Add(new Binding("text", dgvListFoodBaseCategory.DataSource, "Gia"));
        }

        #endregion

        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
            txtTenKhach.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        void f_UpdateAccount(object sender,AccountEvent e)
        {
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();            
            f.Deletefood += f_deletefood;
            f.UpdateFood += f_UpdateFood;
            f.ShowDialog();
        }

        private void f_UpdateFood(object sender, EventArgs e)
        {
            ShowMonAn((cbLoai_Mon_An.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
        }

        private void f_deletefood(object sender, EventArgs e)
        {
            ShowMonAn((cbLoai_Mon_An.SelectedItem as Category).ID);
            if(lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
            LoadTable();
        }

        private void cbLoai_Mon_An_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Category select = cb.SelectedItem as Category;

            id = select.ID;
            ShowMonAn(id);
        }
        private void btnThem_Mon_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn!");
                return;
            }
            int idBIll = BillDAO.Instance.GetUncheckBillIByTableID(table.Id);
            string MaNhanVien = AccountDAO.Instance.GetMaNhanVien();
            string tenMon = txtTenMon.Text;
            int gia = Convert.ToInt32(txtGiaHienTai.Text);
            int foodID = FoodDAO.Instance.getIdMonByTenMonAndGia(tenMon, gia);

            int count = (int)nmFoodCount.Value;
            int checkChiSo = BillInfoDAO.Instance.checkMonCanThayDoiCoExist(foodID, idBIll); //kiểm tra món đó không tồn tại trong bill info thì ko đc numberic < 0
            string Tinh_Trang = DataProvider.Instance.ExecuteScalar("select Tinh_Trang from Thuc_An where ID_Mon = " + foodID).ToString();

            if (Tinh_Trang == "Đã Hết") MessageBox.Show("Món này quán đã hết !", "Thông báo");
            else if (idBIll == -1 && count > 0)
            {
                BillDAO.Instance.InsertBill(table.Id,MaNhanVien);
                BillInfoDAO.Instance.InsertBillInfor(BillDAO.Instance.GetMaxIDBill(), foodID, count, FoodDAO.Instance.GetGiaHienTai(foodID));
            }
            else if(idBIll > 0)
            {
                if((checkChiSo > 0 && count > 0) || (checkChiSo == -1 && count > 0) || (checkChiSo > 0 && count < 0) )
                {
                    BillInfoDAO.Instance.InsertBillInfor(idBIll, foodID, count, FoodDAO.Instance.GetGiaHienTai(foodID));
                }
            }
            ShowBill(table.Id,idBIll);
        }

        private void btnThanh_Toán_Click(object sender, EventArgs e)
        {
            Table ban = lsvBill.Tag as Table;
            if (ban == null)
            {
                MessageBox.Show("Hãy chọn bàn!");
                return;
            }
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIByTableID(table.Id);
            if(idBill != -1)
            {
                if (MessageBox.Show("Bạn có muốn thanh toán hóa đơn cho bàn " + table.Ban, "Thông báo",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill);
                    ShowBill(table.Id);
                }
            }
            long tongCongTien = 0;
            DataTable Table = DataProvider.Instance.ExecuteQuery("select * from Thong_Tin_Hoa_Don where ID_Bill = " + idBill);
            if (Table.Rows.Count > 0)
            {
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    BillInfo billInfo = new BillInfo(Table.Rows[i]);
                    tongCongTien += billInfo.Tong_Tien;
                }
                int Phan_Tram_Giam = CouponDAO.Instance.getPhanTramGiam();
                long tongCongTienSauKM = (long)(tongCongTien - tongCongTien * (double)(Phan_Tram_Giam / 100.0));
                DataProvider.Instance.ExecuteNonQuery("update Hoa_Don set Tong_Tien = " + tongCongTien + " where ID_Bill = " + idBill + " and Trang_Thai_Thanh_Toan = 1");
                string TenKhach = txtTenKhach.Text;
                string Email = txtEmail.Text;
                string DiaChi = txtDiaChi.Text;
                string SDT = txtSDT.Text;
                DataProvider.Instance.ExecuteNonQuery("update Hoa_Don set Ten = @Ten , Email = @email , Dia_Chi_Khach = @diachi , So_Dien_Thoai = @sdt where ID_Bill = @idBill", new object[] { TenKhach, Email, DiaChi, SDT, idBill });
            }

            txtTenKhach.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                this.Hide();
                AccountDAO.Instance.updateLogout();
        }
        private void fTableManager_FormClosed(object sender, FormClosedEventArgs e)
        {
                AccountDAO.Instance.updateLogout();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThong_Tin_Ca_Nhan f = new fThong_Tin_Ca_Nhan(account);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }
        #endregion
    }
}
