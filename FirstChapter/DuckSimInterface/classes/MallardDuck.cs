
using DuckSimulator.Interfaces;

namespace DuckSimulator.Classes
{
    public class MallardDuck : Duck
    {

        public MallardDuck (): base(new FlyWithWings(), new MakeQuack())
        {

        }

      
        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck!");
        }
        


    }
}