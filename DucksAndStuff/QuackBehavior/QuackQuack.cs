using System;

namespace Ch1StrategyPattern.QuackBehavior
{
    class QuackQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack, Quack");
        }
    }
}
