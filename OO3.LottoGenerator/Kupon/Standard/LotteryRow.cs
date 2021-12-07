using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO3.Lottery_Functionality.Standard
{
    public class LotteryRow : IVerifiable<LotteryNumber>
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
