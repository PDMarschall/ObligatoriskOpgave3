using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;


namespace OO3.Lottery_Functionality.Coupon.Standard
{
    public class LotteryRow : Row, IVerifiable<LotteryNumber>
    {
        public LotteryRow()
        {

        }
        public LotteryNumber Generate()
        {
            throw new NotImplementedException();
        }

        public bool Verify(LotteryNumber entity)
        {
            throw new NotImplementedException();
        }
    }
}
