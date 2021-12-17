using System;
using System.Text;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.LotteryTypes.Standard
{
    public class LotteryTicket : Coupon
    {
        public LotteryTicket()
        {
            timestamp = DateTime.Today.ToShortDateString();
            couponContents = new LotteryRow[standardRows];

            GetStandardRows();

            standardCouponString = this.StandardString();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(standardCouponString);
            builder.Append("\n\n");
            return builder.ToString();
        }
    }
}
