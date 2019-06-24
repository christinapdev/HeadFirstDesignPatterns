using System;

namespace DucksAndStuff.QuackBehavior
{
    class Silent : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("*crickets...*")
;        }
    }
}
