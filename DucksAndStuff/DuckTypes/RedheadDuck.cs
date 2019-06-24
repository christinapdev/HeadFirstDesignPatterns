using Ch1StrategyPattern.QuackBehavior;
using System;

namespace Ch1StrategyPattern
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new QuackQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck");
        }
    }
}