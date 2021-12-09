﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO3.Lottery_Functionality.Abstract_Classes
{
    public abstract class Coupon : ICoupon
    {
        protected IList<Row> _couponContents;
        protected int standardRows = 10;
        protected int jokerRows = 2;
        protected DateTime timeStamp;        

        public bool VerifyRow(IList<Row> previousRows, Row currentRow, int iteration)
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
