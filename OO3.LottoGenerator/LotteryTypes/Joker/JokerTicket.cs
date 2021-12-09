using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;
using OO3.Lottery_Functionality.LotteryTypes.Standard;


namespace OO3.Lottery_Functionality.LotteryTypes.Joker
{
    public class JokerTicket : Coupon
    {
        public JokerTicket()
        {
            _dateAndTime = DateTime.Today;
            _timestamp = _dateAndTime.ToShortDateString();
            _couponContents = new Row[standardRows + jokerRows];

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

            for (int i = 0; i < jokerRows; i++)
            {
                _couponContents[standardRows + i] = new JokerRow();

                if (i > 0)
                {
                    if (!VerifyRow(_couponContents, _couponContents[standardRows + i], standardRows + i))
                    {
                        i--;
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"Lotto {_timestamp}\n\n\n");

            for (int i = 0; i < standardRows; i++)
            {
                builder.Append(_couponContents[i] + "\n");
            }

            builder.Append("******* JOKER TAL *******\n");

            for (int i = 0; i < jokerRows; i++)
            {
                builder.Append(_couponContents[standardRows + i] + "\n");
            }
            return builder.ToString();
        }
    }
}
