using Strategy.Strategies.Fly.Concrete;
using Strategy.Strategies.Quack.Concrete;
using Strategy.Strategies.Swim.Concrete;

namespace Strategy
{
    public class DuckFactory
    {
        public static Duck CreateSimpleDuck()
        {
            return new Duck
            {
                fly = new SimpleFly(),
                quack = new SimpleQuack(),
                swim = new SimpleSwim()
            };
        }

        public static Duck CreateExtremeDuck()
        {
            return new Duck
            {
                fly = new JetFly(),
                quack = new ExtremeQuack(),
                swim = new FastSwim()
            };
        }
    }
}