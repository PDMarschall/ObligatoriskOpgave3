using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.Coupon
{
    public class LotteryCoupon : IVerifiable<LotteryCoupon>
    {
        IVerifiable<Row>[] couponContents;
        
        public LotteryCoupon()
        {
            couponContents = new IVerifiable<Row>[10];
        }

        public LotteryCoupon(bool joker)
        {
            couponContents = new IVerifiable<Row>[12];            
        }

        public LotteryCoupon Generate()
        {
            throw new NotImplementedException();
        }

        public bool Verify(LotteryCoupon entity)
        {
            throw new NotImplementedException();
        }
    }
}
