using DuckSimulator.Interfaces;

namespace DuckSimulator.Classes
{
    public class FlyWithWings() : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I've spread my wings to fly");
        }
    }
}