namespace Strategy.Strategies.Quack.Concrete
{
    public class ExtremeQuack : IQuackStrategy
    {
        public void Run()
        {
            System.Console.WriteLine("Extreme Quack");
        }
    }
}