using Decorator.Abstract;
using Decorator.Concrete;

var burger = new BriocheBunDecorator(
    new TomatoDecorator(
        new LettuceDecorator(
            new CheeseDecorator(
                new BeefPattyComponent()
            )
        )
    )
);

System.Console.WriteLine(burger.GetDesc());
System.Console.WriteLine($"${burger.GetCost()}");

var chickenSandwich = new BriocheBunDecorator(
    new TomatoDecorator(
        new TomatoDecorator(
            new LettuceDecorator(
                new CheeseDecorator(
                    new CheeseDecorator(
                        new BeefPattyComponent()
                    )
                )
            )
        )
    )
);

System.Console.WriteLine(chickenSandwich.GetDesc());
System.Console.WriteLine($"${chickenSandwich.GetCost()}");