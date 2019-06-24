using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1StrategyPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }
}
