using System;
using System.Text;
using OO3.Lottery_Functionality.Abstract_Classes;
using OO3.Lottery_Functionality.LotteryTypes.Standard;
using System.Collections.Generic;


namespace OO3.Lottery_Functionality.LotteryTypes.Joker
{
    public class JokerTicket : Coupon
    {
        public JokerTicket()
        {            
            timestamp = DateTime.Today.ToShortDateString();
            couponContents = new Row[standardRows + jokerRows];

            couponContents = GetStandardRows();
            couponContents = GetJokerRows();

            standardCouponString = this.StandardString();
        }

        private IList<Row> GetJokerRows()
        {
            for (int i = 0; i < jokerRows; i++) //joker rows
            {
                couponContents[standardRows + i] = new JokerRow();

                if (i > 0)
                {
                    if (!VerifyRow(couponContents, couponContents[standardRows + i], standardRows + i))
                    {
                        i--;
                    }
                }
            }

            return couponContents;
        }

        public override string ToString() //finish string representation
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(standardCouponString);

            builder.Append("\n ******** Joker Tal ********\n");

            for (int i = 0; i < jokerRows; i++)
            {
                builder.Append(couponContents[standardRows + i] + "\n");
            }

            builder.Append("\n\n\n");

            return builder.ToString();
        }
    }
}
