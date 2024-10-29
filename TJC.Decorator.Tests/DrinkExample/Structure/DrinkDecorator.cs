namespace TJC.Decorator.Tests.DrinkExample.Structure;

public class DrinkDecorator(IDrink coffee) : DecoratorBaseClass<IDrink>(coffee), IDrink
{
    public DrinkTemperature Temperature
    {
        get => Decoratable.Temperature;
        set => Decoratable.Temperature = value;
    }
}
