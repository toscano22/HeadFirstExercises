
using DuckSimulator.Interfaces;

namespace DuckSimulator.Classes
{
    public abstract class Duck
    {

        public IFlyable FlyBehavior { get; private set; }
        public IQuackable QuackBehavior { get; private set; }

        public Duck (IFlyable flyBehavior, IQuackable quackBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
        public abstract void Display();

        public void SetFlyBehavior(IFlyable fb)
        {
            FlyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackable qb)
        {
            QuackBehavior = qb;
        }


    }
}