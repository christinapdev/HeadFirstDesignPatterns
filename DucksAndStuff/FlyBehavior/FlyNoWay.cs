using System;

namespace Ch1StrategyPattern
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't Fly...");
        }
    }
}
