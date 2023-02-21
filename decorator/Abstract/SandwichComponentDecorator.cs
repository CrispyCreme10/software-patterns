namespace Decorator.Abstract
{
    public abstract class SandwichComponentDecorator : SandwichComponent
    {
        public override abstract string GetDesc();
        public override abstract double GetCost();
    }
}