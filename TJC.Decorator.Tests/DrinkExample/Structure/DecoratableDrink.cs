namespace TJC.Decorator.Tests.DrinkExample.Structure;

public class DecoratableDrink : Decoratable, IDrink
{
    protected DrinkTemperature _temperature;
    public DrinkTemperature Temperature
    {
        get => _temperature;
        set => _temperature = value;
    }
}
