using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.LotteryTypes.Ticket;

namespace OO3.Lottery_Functionality
{
    public static class CouponFactory
    {
        public static ICoupon GetCoupon(string couponType)
        {
            ICoupon ticket = null;

            switch (couponType)
            {
                case "Standard":
                    ticket = new StandardTicket();
                    break;
                case "Joker":
                    ticket = new JokerTicket();
                    break;
                default:
                    throw new ArgumentException("Invalid repository type");
            }

            return ticket;
        }
    }
}
