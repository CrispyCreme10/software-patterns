using Decorator.Abstract;

namespace Decorator.Concrete
{
    public class ChickenPattyComponent : SandwichComponent
    {
        public override string GetDesc()
        {
            return "Chicken Patty";
        }

        public override double GetCost()
        {
            return 2.2;
        }
    }
}