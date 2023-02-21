using Decorator.Abstract;

namespace Decorator.Concrete
{
    public class CheeseDecorator : SandwichComponentDecorator
    {
        SandwichComponent SandwichComponent;

        public CheeseDecorator(SandwichComponent sandwichComponent)
        {
            SandwichComponent = sandwichComponent;
        }

        public override string GetDesc()
        {
            return SandwichComponent.GetDesc() + $", Cheese";
        }

        public override double GetCost()
        {
            return SandwichComponent.GetCost() + 0.5;
        }
    }
}