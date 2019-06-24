using System;

namespace DucksAndStuff
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public abstract void Display();
        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }        

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior.Quack();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Swimming, swimming...");
        }

    }
}