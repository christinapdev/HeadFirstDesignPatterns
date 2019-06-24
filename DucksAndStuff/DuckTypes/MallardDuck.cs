using DucksAndStuff.QuackBehavior;
using System;

namespace DucksAndStuff
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new QuackQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }

    }
}