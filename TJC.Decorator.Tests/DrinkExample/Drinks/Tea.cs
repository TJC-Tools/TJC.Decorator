namespace TJC.Decorator.Tests.DrinkExample.Drinks;

public class Tea : DecoratableDrink
{
    public Tea()
    {
        Temperature = DrinkTemperature.Scorching;
    }
}