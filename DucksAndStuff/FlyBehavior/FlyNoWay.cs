using System;

namespace DucksAndStuff
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't Fly...");
        }
    }
}
