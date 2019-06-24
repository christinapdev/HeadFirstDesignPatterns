using System;

namespace DucksAndStuff.QuackBehavior
{
    class QuackQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack, Quack");
        }
    }
}
