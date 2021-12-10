using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality.Concrete_Classes.Joker
{
    public class JokerNumber : Number
    {
        public override int MaxValue => 9;
        public JokerNumber() : base()
        {

        }
        public override string ToString()
        {
            return $"  {Value}";
        }
    }
}