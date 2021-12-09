using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;
using OO3.Lottery_Functionality.LotteryTypes.Standard;

namespace OO3.Lottery_Functionality.LotteryTypes
{
    public class LotteryCoupon
    {
        private IList<Row> _couponContents;

        public LotteryCoupon()
        {
            _couponContents = new Row[10];

            for (int i = 0; i < _couponContents.Count; i++)
            {
                _couponContents[i] = new LotteryRow();

                if (i > 0)
                {
                    if (!VerifyRow(_couponContents, _couponContents[i], i))
                    {
                        i--;
                    }
                }
            }
        }

        public LotteryCoupon(bool joker)
        {
            _couponContents = new Row[12];
        }

        private bool VerifyRow(IList<Row> previousRows, Row currentRow, int iteration)
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

        public override string ToString()
        {
            return string.Join("\n", _couponContents);
        }
    }
}
