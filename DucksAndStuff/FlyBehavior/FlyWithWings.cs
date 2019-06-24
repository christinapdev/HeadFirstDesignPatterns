using System;

namespace DucksAndStuff
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
}
