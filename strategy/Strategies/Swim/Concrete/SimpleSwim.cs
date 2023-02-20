namespace Strategy.Strategies.Swim.Concrete
{
    public class SimpleSwim : ISwimStrategy
    {
        public void Run()
        {
            System.Console.WriteLine("Simple Swim");
        }
    }
}