using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;
using OO3.Lottery_Functionality.Coupon.Standard;


namespace OO3.Lottery_Functionality.Coupon.Standard
{
    public class LotteryRow : Row
    {
        public LotteryRow()
        {
            _rowNumberCollection = new LotteryNumber[standardLength];

            for (int i = 0; i < standardLength; i++)
            {
                _rowNumberCollection[i] = new LotteryNumber();

                if (i > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (_rowNumberCollection[j].Value == _rowNumberCollection[i].Value)
                        {
                            _rowNumberCollection[i] = null;
                            i--;
                        }
                    }
                }
            }

            Array.Sort(_rowNumberCollection);
        }

        public override string ToString()
        {
            return String.Join<Number>(' ', _rowNumberCollection);
        }
    }
}
