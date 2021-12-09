﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.LotteryTypes.Standard
{
    public class LotteryNumber : Number
    {
        public override int MaxValue => 36;
        public LotteryNumber() : base()
        {

        }

        public override string ToString()
        {
            if (Value < 10)
                return $"0{Value}";
            else
                return $"{Value}";
        }
    }
}