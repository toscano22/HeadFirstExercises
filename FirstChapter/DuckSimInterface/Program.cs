using DuckSimulator.Classes;

public class MiniDuckSimulator
{
    public static void Main(String[] args)
    {
        Duck mallard = new MallardDuck();
        mallard.Display();
        mallard.PerformQuack();
        mallard.PerformFly();


    }
}



