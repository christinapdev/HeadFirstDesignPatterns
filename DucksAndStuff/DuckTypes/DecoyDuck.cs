using DucksAndStuff.QuackBehavior;
using System;

namespace DucksAndStuff
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
