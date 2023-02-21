using Decorator.Abstract;

namespace Decorator.Concrete
{
    public class TomatoDecorator : SandwichComponentDecorator
    {
        SandwichComponent SandwichComponent;

        public TomatoDecorator(SandwichComponent sandwichComponent)
        {
            SandwichComponent = sandwichComponent;
        }

        public override string GetDesc()
        {
            return SandwichComponent.GetDesc() + $", Tomato";
        }

        public override double GetCost()
        {
            return SandwichComponent.GetCost() + 0.35;
        }
    }
}