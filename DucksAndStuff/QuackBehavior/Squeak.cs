using System;

namespace DucksAndStuff
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("SQUEEEEAK....");
        }
    }
}
