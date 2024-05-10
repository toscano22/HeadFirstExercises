using  DuckSimulator.Interfaces;

namespace DuckSimulator.Classes
{

    public class DuckCallDevice
    {
        public IQuackable QuackBehavior { get; private set; }

        public DuckCallDevice()
        {
            QuackBehavior = new MakeQuack();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
    }

   
    
}
