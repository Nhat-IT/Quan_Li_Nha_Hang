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
    }
}
