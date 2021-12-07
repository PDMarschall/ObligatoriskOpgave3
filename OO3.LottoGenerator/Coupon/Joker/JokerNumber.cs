using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO3.Lottery_Functionality.Coupon.Joker
{
    public class JokerNumber : IVerifiable<JokerNumber>
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
