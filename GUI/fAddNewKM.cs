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

namespace Quan_Li_Nha_Hang.GUI
{
    public partial class fAddNewKM : Form
    {
        public fAddNewKM()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string Ma = txtMCTKM.Text;
            string TenCT = txtTCTKM.Text;
            int PTG = (int)numPTG.Value;
            DateTime dateEnd = timeEnd.Value;
            DateTime dateStart = timeStart.Value;           
            bool check = checkMauThuan(dateStart,dateEnd,Ma);
            if (dateStart > dateEnd)
            {
                MessageBox.Show("Ngày Bắt Đầu Lớn Hơn Kết Thúc", "Thống Báo");
                return;
            }
            else if(Ma == "" || TenCT == "")
            {
                MessageBox.Show("Cần Nhập Đủ", "Thông Báo");
                return;
            }
            else if(check == false)
            {
                MessageBox.Show("Mâu Thuẫn Với Khuyến Mãi Khác", "Thông Báo");
                return;
            }
            else
            {
                int kt = DataProvider.Instance.ExecuteNonQuery("exec USP_insertCoupon @ma , @ten , @pt , @start , @end", new object[] { Ma, TenCT, PTG, dateStart, dateEnd });
                if(kt > 0)
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    if(insertCoupon != null)
                    {
                        insertCoupon(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                }
            }
        }

        bool checkMauThuan(DateTime start,DateTime end, string Ma)
        {
            Coupon[] list = CouponDAO.Instance.getListCouponExceptKhongKM();
            int count = CouponDAO.Instance.getCountCouponExceptKhongKM();
            if(count > 0)
            {
                for(int i = 0; i < count; i++)
                {
                    if (start > list[i].Ngay_Bat_Dau && end < list[i].Ngay_Ket_Thuc) return false;
                    if (end > list[i].Ngay_Bat_Dau && start < list[i].Ngay_Ket_Thuc ) return false;
                    if (start > list[i].Ngay_Bat_Dau && start < list[i].Ngay_Ket_Thuc && end > list[i].Ngay_Ket_Thuc ) return false;
                    if (start < list[i].Ngay_Bat_Dau && end < list[i].Ngay_Ket_Thuc && end > list[i].Ngay_Bat_Dau) return false;
                    if (Ma == list[i].Ma_Coupon) return false;
                }
                if (Ma == "0") return false;
            }
            return true;
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private event EventHandler insertCoupon;
        public event EventHandler InsertCoupon
        {
            add
            {
                insertCoupon += value;
            }
            remove
            {
                insertCoupon -= value;
            }
        }
    }
}
