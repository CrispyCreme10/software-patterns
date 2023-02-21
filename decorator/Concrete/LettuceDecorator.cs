using Decorator.Abstract;

namespace Decorator.Concrete
{
    public class LettuceDecorator : SandwichComponentDecorator
    {
        SandwichComponent SandwichComponent;

        public LettuceDecorator(SandwichComponent sandwichComponent)
        {
            SandwichComponent = sandwichComponent;
        }

        public override string GetDesc()
        {
            return SandwichComponent.GetDesc() + $", Lettuce";
        }

        public override double GetCost()
        {
            return SandwichComponent.GetCost() + 0.25;
        }
    }
}