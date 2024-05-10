using DuckSimulator.Interfaces;

namespace DuckSimulator.Classes
{
    public class MakeQuack() : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}