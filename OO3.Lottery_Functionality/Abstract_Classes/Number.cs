using System;

namespace OO3.Lottery_Functionality.Abstract_Classes
{
    public abstract class Number : IComparable<Number>
    {
        public abstract int MaxValue { get; }
        public int Value { get; set; }
        private Random _rnd = new Random();

        public Number()
        {
            Value = _rnd.Next(1, MaxValue + 1);
        }

        public int CompareTo(Number other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}