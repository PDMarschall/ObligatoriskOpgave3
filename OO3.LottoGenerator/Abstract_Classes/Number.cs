using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO3.Lottery_Functionality.Abstract_Classes
{
    public abstract class Number
    {
        public abstract int MaxVærdi { get; }
        public int Værdi { get; set; }

        private Random _rnd = new Random();

        public Number()
        {
            Værdi = _rnd.Next(MaxVærdi + 1);
        }
    }
}