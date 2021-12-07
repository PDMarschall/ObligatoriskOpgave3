using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.Coupon.Joker
{
    public class JokerNumber : Number, IVerifiable<JokerNumber>
    {
        public JokerNumber()
        {

        }

        public JokerNumber Generate()
        {
            throw new NotImplementedException();
        }

        public bool Verify(JokerNumber entity)
        {
            throw new NotImplementedException();
        }
    }
}
