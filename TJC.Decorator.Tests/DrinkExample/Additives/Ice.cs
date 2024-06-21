namespace TJC.Decorator.Tests.DrinkExample.Additives;

public class Ice : DrinkDecorator
{
    public Ice(IDrink drink) : base(drink)
    {
        Decoratable.Cool();
        Decoratable.Cool();
    }
}