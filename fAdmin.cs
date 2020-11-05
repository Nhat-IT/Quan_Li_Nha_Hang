using Quan_Li_Nha_Hang.DAO;
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
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
            LoadFood();
        }
        
        void LoadAccountList()
        {
            
            string query1 = "insert Loai_Thuc_An values ('Tiep theo1','Bún')"; 
            DataProvider.Instance1.ExecuteNonQuery(query1);
        }
        void LoadFood()
        {
            string query = "exec dbo.USP_GetAccountByUserName @username";
            dataGridView1.DataSource = DataProvider.Instance1.ExecuteQuery(query, new object[] { "Nguyen Tan Nhat" });
        }
    }
}
