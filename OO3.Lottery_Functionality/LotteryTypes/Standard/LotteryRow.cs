using System;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.LotteryTypes.Standard
{
    public class LotteryRow : Row
    {
        public LotteryRow()
        {
            _rowNumberCollection = new LotteryNumber[standardNumberAmount];

            for (int currentIndex = 0; currentIndex < standardNumberAmount; currentIndex++)
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

            for (int i = 0; i < standardNumberAmount; i++)
            {
                _id += $"{_rowNumberCollection[i]}";
            }
        }

        public override string ToString()
        {
            string result = RowNumber > 9 ? $"{RowNumber}. " : $"  {RowNumber}. ";
            result += string.Join<Number>(' ', _rowNumberCollection);
            return result;
        }
    }
}
