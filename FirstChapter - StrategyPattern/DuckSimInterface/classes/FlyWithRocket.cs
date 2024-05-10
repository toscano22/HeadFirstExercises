using DuckSimulator.Interfaces;

namespace DuckSimulator.Classes
{
    public class FlyWithRocket() : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a Rocket!");
        }
    }
}