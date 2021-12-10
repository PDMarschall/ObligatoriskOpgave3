using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.LotteryTypes.Joker
{
    public class JokerNumber : Number
    {
        public override int MaxValue => 9;

        public override string ToString()
        {
            return $"  {Value}";
        }
    }
}