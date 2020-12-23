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
    public partial class faddNewFood : Form
    {
        public faddNewFood()
        {
            InitializeComponent();
            prepareBeforeAddFood();
        }

        public void prepareBeforeAddFood()
        {
            txtID_Mon.Text = IndexFoodDAO.Instance.getIndexHole().ToString();
            cbTen_Loai.DataSource = CategoryDAO.Instance.GetListCategory();
            cbTen_Loai.DisplayMember = "Ten_Loai";
            Con.Checked = true;
        }

        #region method
        private void addFood_Click(object sender, EventArgs e)
        {
            int ID_Mon = Convert.ToInt32(txtID_Mon.Text);
            string Ten_Mon = txtTen_Mon.Text;
            string ID_Loai = (cbTen_Loai.SelectedItem as Category).ID;
            int Gia = (int)nmGia.Value;
            string Don_Vi_Tinh = txtDon_Vi_Tinh.Text;
            string Tinh_Trang = "";
            if (Con.Checked == true) Tinh_Trang = "Còn";
            else Tinh_Trang = "Đã Hết";
            if (FoodDAO.Instance.AddFood(ID_Mon,Ten_Mon, ID_Loai, Tinh_Trang, Gia, Don_Vi_Tinh))
            {
                MessageBox.Show("Thêm thành công");
            }
            else MessageBox.Show("Thêm thất bại");

        }
        #endregion

        #region event

        private void escape_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Con_Click(object sender, EventArgs e)
        {
            if (Con.Checked == true && Het.Checked == true)
            {
                Con.Checked = true;
                Het.Checked = false;
            }
            else if (Con.Checked == false)
            {
                Con.Checked = true;
                Het.Checked = false;
            }
        }

        private void Het_Click(object sender, EventArgs e)
        {
            if (Het.Checked == true && Con.Checked == true)
            {
                Het.Checked = true;
                Con.Checked = false;
            }
            else if (Het.Checked == false)
            {
                Het.Checked = true;
                Con.Checked = false;
            }
        }

        #endregion
    }
}
