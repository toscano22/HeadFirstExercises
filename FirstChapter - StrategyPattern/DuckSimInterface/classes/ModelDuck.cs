
using DuckSimulator.Interfaces;

namespace DuckSimulator.Classes
{
    public class ModelDuck : Duck
    {

        public ModelDuck (): base(new FlyNoWings(), new MakeQuack())
        {

        }

      
        public override void Display()
        {
            Console.WriteLine("I'm a model duck!");
        }
        


    }
}