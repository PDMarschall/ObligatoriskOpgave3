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
            _rowNumberCollection = new Number[standardLength];

            for (int i = 0; i < standardLength; i++)
            {
                _rowNumberCollection[i] = new LotteryNumber();

            }
        }
    }
}
