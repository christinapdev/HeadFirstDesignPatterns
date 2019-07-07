using System;

namespace Ch1StrategyPattern
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("SQUEEEEAK....");
        }
    }
}
