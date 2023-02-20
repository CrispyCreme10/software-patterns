namespace Strategy.Strategies.Swim.Concrete
{
    public class FastSwim : ISwimStrategy
    {
        public void Run()
        {
            System.Console.WriteLine("Fast Swim");
        }
    }
}