using Ch1StrategyPattern.FlyBehavior;
using System;

namespace Ch1StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck();
            AddSeperator();

            RedheadDuck();
            AddSeperator();

            RubberDuck();
            AddSeperator();

            DecoyDuck();

            Console.ReadLine();
        }

        private static void DecoyDuck()
        {
            Duck decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.Swim();
            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();
            decoyDuck.SetFlyBehavior(new FlyRocketPowered());
            decoyDuck.PerformFly();
        }

        private static void RubberDuck()
        {
            Duck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Swim();
            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();
        }

        private static void RedheadDuck()
        {
            Duck redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.Swim();
            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();
        }

        private static void MallardDuck()
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Swim();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
        }

        static void AddSeperator()
        {
            Console.WriteLine();
        }
    }
}