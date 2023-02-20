namespace Strategy.Strategies.Quack.Concrete
{
    public class SimpleQuack : IQuackStrategy
    {
        public void Run()
        {
            System.Console.WriteLine("Simple Quack");
        }
    }
}