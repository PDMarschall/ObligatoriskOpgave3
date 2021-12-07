using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.Coupon.Standard
{
    public class LotteryNumber : Number
    {
        public override int MaxVærdi { get => 36;}
        public LotteryNumber()
        {

        }        
    }
}
