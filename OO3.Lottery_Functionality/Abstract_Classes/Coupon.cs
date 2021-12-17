using System;
using System.Collections.Generic;
using System.Text;
using OO3.Lottery_Functionality.LotteryTypes.Standard;

namespace OO3.Lottery_Functionality.Abstract_Classes
{
    public abstract class Coupon : ICoupon
    {
        //The contents of the coupon
        protected int standardRows = 10;
        protected int jokerRows = 2;        
        protected IList<Row> couponContents;

        //the formatting of the coupon
        protected string timestamp;
        protected string standardCouponString;
        private int rowNumberSpacing = 4;
        private int numberSpacing = 2;
        private int numberWidth = 2;

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
            
            int couponWidth = couponContents[0].GetLength() * numberWidth + (couponContents[0].GetLength() - 1) * numberSpacing + rowNumberSpacing;

            string dateLine = $"Lotto {timestamp}";
            string duration = "1-Uge";
            string couponType = "LYN-LOTTO";

            StringBuilder builder = new StringBuilder();

            builder.Append(FormattingHelper.CenterString(dateLine, (couponWidth / 2) - (dateLine.Length / 2)));
            builder.Append("\n\n");
            builder.Append(FormattingHelper.CenterString(duration, (couponWidth / 2) - (duration.Length / 2)));
            builder.Append("\n");
            builder.Append(FormattingHelper.CenterString(couponType, (couponWidth / 2) - (couponType.Length / 2)));
            builder.Append("\n\n");


            for (int i = 0; i < standardRows; i++)
            {
                builder.Append(couponContents[i] + "\n");
            }

            return builder.ToString();
        }
    }
}
