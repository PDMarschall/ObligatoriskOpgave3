using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;
using OO3.Lottery_Functionality.Coupon.Standard;


namespace OO3.Lottery_Functionality.Coupon.Standard
{
    public class LotteryRow : Row
    {
        public LotteryRow()
        {
            _rowNumberCollection = new LotteryNumber[standardLength];

            for (int currentIndex = 0; currentIndex < standardLength; currentIndex++)
            {
                _rowNumberCollection[currentIndex] = new LotteryNumber();

                if (currentIndex > 0)
                {
                    for (int previousIndex = 0; previousIndex < currentIndex; previousIndex++)
                    {
                        if (_rowNumberCollection[previousIndex].Value == _rowNumberCollection[currentIndex].Value)
                        {                            
                            currentIndex--;
                        }
                    }
                }
            }

            Array.Sort(_rowNumberCollection);

            for (int i = 0; i < standardLength; i++)
            {
                _id += $"{_rowNumberCollection[i]}";
            }
        }

        public override string ToString()
        {
            return String.Join<Number>(' ', _rowNumberCollection);
        }
    }
}
