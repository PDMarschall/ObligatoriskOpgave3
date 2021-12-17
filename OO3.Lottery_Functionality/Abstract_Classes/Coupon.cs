using System;
using System.Collections.Generic;
using System.Text;
using OO3.Lottery_Functionality.LotteryTypes.Standard;

namespace OO3.Lottery_Functionality.Abstract_Classes
{
    public abstract class Coupon : ICoupon
    {
        //Control Tower for coupons and related methods
        protected int standardRows = 10;
        protected int jokerRows = 2;

        protected IList<Row> couponContents;
        protected string timestamp;
        protected string standardCouponString;

        protected IList<Row> GetStandardRows()
        {
            for (int i = 0; i < standardRows; i++)
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
            int rowNumberSpacing = 4;
            int numberSpacing = 2;
            int numberWidth = 2;
            int couponWidth = couponContents[0].GetLength() * numberWidth + (couponContents[0].GetLength()-1) * numberSpacing + rowNumberSpacing;

            string dateLine = $"Lotto {timestamp}";
            string duration = "1-Uge";
            string couponType = "LYN-LOTTO";

            StringBuilder builder = new StringBuilder();

            builder.Append(new String(' ', (couponWidth / 2) - (dateLine.Length / 2)));
            builder.Append(dateLine);
            builder.Append("\n\n");
            builder.Append(new String(' ', (couponWidth / 2) - (duration.Length / 2)));
            builder.Append(duration);
            builder.Append("\n");
            builder.Append(new String(' ', (couponWidth / 2) - (couponType.Length / 2)));
            builder.Append(couponType);
            builder.Append("\n\n");
            builder.Append("\n\n");





            //builder.Append($"   Lotto {timestamp}\n\n");
            //builder.Append("    1-uge\n");
            //builder.Append("    LYN-LOTTO\n\n");

            for (int i = 0; i < standardRows; i++)
            {
                builder.Append(couponContents[i] + "\n");
            }

            return builder.ToString();
        }
    }
}
