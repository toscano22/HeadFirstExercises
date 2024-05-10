using DuckSimulator.Classes;

public class MiniDuckSimulator
{
    public static void Main(String[] args)
    {

        // Test #1
        Duck mallard = new MallardDuck();
        mallard.Display();
        mallard.PerformQuack();
        mallard.PerformFly();

        // Test #2
        Duck modelDuck = new ModelDuck();
        modelDuck.Display();
        modelDuck.PerformQuack();
        modelDuck.PerformFly();
        Console.WriteLine("But I am a SA and want to build a rocket");
        modelDuck.SetFlyBehavior(new FlyWithRocket());
        modelDuck.PerformFly();



    }
}



