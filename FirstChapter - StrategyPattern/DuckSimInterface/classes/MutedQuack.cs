using DuckSimulator.Interfaces;

namespace DuckSimulator.Classes
{
    public class MuyedQuack() : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}