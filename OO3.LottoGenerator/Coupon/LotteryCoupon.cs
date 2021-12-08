using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.Coupon
{
    public class LotteryCoupon
    {
        private IList<Row> _couponContents;

        public LotteryCoupon()
        {
            _couponContents = new Row[10];
        }

        public LotteryCoupon(bool joker)
        {
            _couponContents = new Row[12];
        }

        private bool VerifyRow(IList<Row> previousRows, Row currentRow)
        {
            for (int i = 0; i < previousRows.Count; i++)
            {
                if (previousRows[i].Equals(previousRows[i], currentRow))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
