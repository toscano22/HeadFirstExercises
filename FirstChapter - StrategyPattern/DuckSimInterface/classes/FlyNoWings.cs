using DuckSimulator.Interfaces;

namespace DuckSimulator.Classes
{
    public class FlyNoWings() : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}