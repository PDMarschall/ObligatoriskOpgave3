using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.LotteryTypes.Joker
{
    public class JokerRow : Row
    {
        public JokerRow()
        {
            _rowNumberCollection = new JokerNumber[standardNumberAmount];

            for (int i = 0; i < standardNumberAmount; i++)
            {
                _rowNumberCollection[i] = new JokerNumber();
            }

            for (int i = 0; i < standardNumberAmount; i++)
            {
                _id += $"{_rowNumberCollection[i]}";
            }
        }

        public override string ToString()
        {
            string result = "        ";
            result += string.Join<Number>("  ", _rowNumberCollection);
            return result;
        }
    }
}
