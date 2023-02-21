using Strategy.Strategies.Fly.Concrete;
using Strategy.Strategies.Quack.Concrete;
using Strategy.Strategies.Swim.Concrete;

namespace Strategy
{
    public class Duck
    {
        public IFlyStrategy fly = new SimpleFly();
        public IQuackStrategy quack = new SimpleQuack();
        public ISwimStrategy swim = new SimpleSwim();

        public void Execute()
        {
            fly.Run();
            quack.Run();
            swim.Run();
        }
    }
}