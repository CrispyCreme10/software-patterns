using Decorator.Abstract;

namespace Decorator.Concrete
{
    public class BeefPattyComponent : SandwichComponent
    {
        public override string GetDesc()
        {
            return "Beef Patty";
        }

        public override double GetCost()
        {
            return 1.5;
        }
    }
}