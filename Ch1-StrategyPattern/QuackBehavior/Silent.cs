using System;

namespace Ch1StrategyPattern.QuackBehavior
{
    class Silent : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("*crickets...*")
;        }
    }
}
