using Ch1StrategyPattern.QuackBehavior;
using System;

namespace Ch1StrategyPattern
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Silent();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a decoy duck");
        }
    }
}
