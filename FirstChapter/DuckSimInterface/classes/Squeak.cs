using DuckSimulator.Interfaces;

namespace DuckSimulator.Classes
{
    public class Squeak() : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}