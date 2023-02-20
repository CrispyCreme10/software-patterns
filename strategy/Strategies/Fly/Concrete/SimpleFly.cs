namespace Strategy.Strategies.Fly.Concrete
{
    public class SimpleFly : IFlyStrategy
    {
        public void Run()
        {
            System.Console.WriteLine("Simple Fly");
        }
    }
}