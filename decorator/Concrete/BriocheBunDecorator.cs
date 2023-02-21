using Decorator.Abstract;

namespace Decorator.Concrete
{
    public class BriocheBunDecorator : SandwichComponentDecorator
    {
        SandwichComponent SandwichComponent;

        public BriocheBunDecorator(SandwichComponent sandwichComponent)
        {
            SandwichComponent = sandwichComponent;
        }

        public override string GetDesc()
        {
            return SandwichComponent.GetDesc() + $", Brioche Bun";
        }

        public override double GetCost()
        {
            return SandwichComponent.GetCost() + 1.2;
        }
    }
}