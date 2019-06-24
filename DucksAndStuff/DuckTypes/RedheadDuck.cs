using DucksAndStuff.QuackBehavior;
using System;

namespace DucksAndStuff
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