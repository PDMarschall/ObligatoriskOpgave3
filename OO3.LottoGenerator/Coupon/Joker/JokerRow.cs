using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.Coupon.Joker
{
    public class JokerRow : Row
    {
        public JokerRow()
        {
            _rowNumberCollection = new JokerNumber[standardLength];

            for (int i = 0; i < standardLength; i++)
            {
                _rowNumberCollection[i] = new JokerNumber();
            }
        }
        public override string ToString()
        {
            return String.Join<Number>(' ', _rowNumberCollection);
        }
    }
}
