using System;
using System.Collections.Generic;
using System.Text;
using OO3.Lottery_Functionality.LotteryTypes.Standard;

namespace OO3.Lottery_Functionality.Abstract_Classes
{
    public abstract class Coupon : ICoupon
    {
        protected IList<Row> couponContents;
        protected int standardRows = 10;
        protected int jokerRows = 2;
        protected string timestamp;
        protected string standardCouponString;

        protected IList<Row> GetStandardRows()
        {
            for (int i = 0; i < standardRows; i++) //standard ticket
            {
                couponContents[i] = new LotteryRow();

                if (i > 0)
                {
                    if (!VerifyRow(couponContents, couponContents[i], i))
                    {
                        i--;
                    }
                }
                couponContents[i].RowNumber = i + 1;
            }

            return couponContents;
        }

        public bool VerifyRow(IList<Row> previousRows, Row currentRow, int iteration)
        {
            for (int i = 0; i < iteration; i++)
            {
                if (previousRows[i].Equals(previousRows[i], currentRow))
                {
                    return false;
                }
            }
            return true;
        }

        protected string StandardString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"   Lotto {timestamp}\n\n\n");

            for (int i = 0; i < standardRows; i++)
            {
                builder.Append(couponContents[i] + "\n");
            }

            return builder.ToString();
        }
    }
}
