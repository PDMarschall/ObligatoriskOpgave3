using System;
using System.Text;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.LotteryTypes.Standard
{
    public class LotteryTicket : Coupon
    {
        public LotteryTicket()
        {
            _timestamp = DateTime.Today.ToShortDateString();
            _couponContents = new LotteryRow[standardRows];

            for (int i = 0; i < standardRows; i++)
            {
                _couponContents[i] = new LotteryRow();

                if (i > 0)
                {
                    if (!VerifyRow(_couponContents, _couponContents[i], i))
                    {
                        i--;
                    }
                }
                _couponContents[i].RowNumber = i + 1;
            }
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"   Lotto {_timestamp}\n\n\n");

            for (int i = 0; i < standardRows; i++)
            {
                builder.Append(_couponContents[i] + "\n");
            }

            return builder.ToString();
        }
    }
}
