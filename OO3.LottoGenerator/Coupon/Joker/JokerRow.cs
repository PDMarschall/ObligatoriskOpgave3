﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.Coupon.Joker
{
    public class JokerRow : Row, IVerifiable<JokerRow>
    {
        public JokerRow()
        {

        }
        public JokerRow Generate()
        {
            throw new NotImplementedException();
        }

        public bool Verify(JokerRow entity)
        {
            throw new NotImplementedException();
        }
    }
}
