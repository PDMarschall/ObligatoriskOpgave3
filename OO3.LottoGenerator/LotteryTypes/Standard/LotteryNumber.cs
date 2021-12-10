using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.LotteryTypes.Standard
{
    public class LotteryNumber : Number
    {
        public override int MaxValue => 36;
        public LotteryNumber() : base()
        {

        }

        public override string ToString()
        {
            return $"{Value:0#}";
        }
    }
}
