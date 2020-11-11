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
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }

        #region Method

        private void LoadTable()
        {
            List<Table> listTable = TableDAO.Instance.LoadTableList();

        foreach(Table item in listTable)
            {
                Button btn = new Button() { Width = TableDAO.btnWidth, Height = TableDAO.btnHeight };
                btn.Text = item.Ban + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                if(item.Status == "Có Người")
                {
                    btn.BackColor = Color.Aqua;
                }
                else
                {
                    btn.BackColor = Color.Beige;
                }
                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int ID)
        {
            List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUncheckBillIByTableID(ID));

            foreach(BillInfo item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.ID_Mon.ToString());
                lsvItem.SubItems.Add(item.So_Mon.ToString());

                lsvBill.Items.Add(lsvItem);
            }
        }

        #endregion

        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            ShowBill(tableID);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThong_Tin_Ca_Nhan f = new fThong_Tin_Ca_Nhan();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
        #endregion
    }
}
