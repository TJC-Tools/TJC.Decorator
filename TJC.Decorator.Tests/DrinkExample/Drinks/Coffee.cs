namespace TJC.Decorator.Tests.DrinkExample.Drinks;

public class Coffee : DecoratableDrink
{
    public Coffee()
    {
        Temperature = DrinkTemperature.Hot;
    }
}
