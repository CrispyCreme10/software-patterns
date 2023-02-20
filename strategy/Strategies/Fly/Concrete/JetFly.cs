namespace Strategy.Strategies.Fly.Concrete
{
    public class JetFly : IFlyStrategy
    {
        public void Run()
        {
            System.Console.WriteLine("Jet Fly");
        }
    }
}