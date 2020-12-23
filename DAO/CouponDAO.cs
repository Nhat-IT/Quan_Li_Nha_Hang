using Quan_Li_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang.DAO
{
    class CouponDAO
    {
        private static CouponDAO instance;

        internal static CouponDAO Instance
        {
            get
            {
                if (instance == null) instance = new CouponDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private CouponDAO() { }

        public int getPhanTramGiam()
        {
            DateTime date = DateTime.Now;
            int count = (int)DataProvider.Instance.ExecuteScalar("exec USP_getCountCoupon @date", new object[] { date });
            if(count > 0)
            {
                return (int)DataProvider.Instance.ExecuteScalar("exec USP_getPhanTramGiam @date", new object[] { date });
            }
            return 0;
        }

        public Coupon[] getListCoupon()
        {
            int count = (int)DataProvider.Instance.ExecuteScalar("select count(*) from Coupon");
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Coupon");
            Coupon[] list = new Coupon[count];
            int i = 0;
            foreach(DataRow item in data.Rows)
            {
                list[i] = new Coupon(item);
                i++;
            }
            return list;
        }

        public int getCountCouponExceptKhongKM()
        {
            return (int)DataProvider.Instance.ExecuteScalar("select count(*) from Coupon where Phan_Tram_Giam != 0");
        }

        public Coupon[] getListCouponExceptKhongKM()
        {
            int count = (int)DataProvider.Instance.ExecuteScalar("select count(*) from Coupon where Phan_Tram_Giam != 0");
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Coupon where Phan_Tram_Giam != 0");
            Coupon[] list = new Coupon[count];
            int i = 0;
            foreach (DataRow item in data.Rows)
            {
                list[i] = new Coupon(item);
                i++;
            }
            return list;
        }
    }
}
