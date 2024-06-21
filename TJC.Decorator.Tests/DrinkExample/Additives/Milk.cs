namespace TJC.Decorator.Tests.DrinkExample.Additives;

public class Milk : DrinkDecorator
{
    public Milk(IDrink drink) : base(drink)
    {
        Decoratable.Cool();
    }
}