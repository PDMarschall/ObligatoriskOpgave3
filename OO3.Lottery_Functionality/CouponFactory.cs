using System;
using OO3.Lottery_Functionality.LotteryTypes.Joker;
using OO3.Lottery_Functionality.LotteryTypes.Standard;

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
                    ticket = new LotteryTicket();
                    break;
                case "Joker":
                    ticket = new JokerTicket();
                    break;
                default:
                    throw new ArgumentException("Invalid ticket type");
            }

            return ticket;
        }
    }
}
