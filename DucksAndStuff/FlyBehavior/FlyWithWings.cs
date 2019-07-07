using System;

namespace Ch1StrategyPattern
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
}
