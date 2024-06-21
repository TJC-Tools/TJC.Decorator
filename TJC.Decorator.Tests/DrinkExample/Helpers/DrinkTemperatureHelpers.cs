namespace TJC.Decorator.Tests.DrinkExample.Helpers;

public static class DrinkTemperatureHelpers
{
    public static void Cool(this IDrink drink) =>
        drink.Temperature = drink.Temperature.Cool();
    public static void Heat(this IDrink drink) =>
        drink.Temperature = drink.Temperature.Heat();

    public static DrinkTemperature Cool(this DrinkTemperature temperature)
    {
        if (temperature == DrinkTemperature.Freezing)
            return temperature;
        temperature--;
        return temperature;
    }

    public static DrinkTemperature Heat(this DrinkTemperature temperature)
    {
        if (temperature == DrinkTemperature.Scorching)
            return temperature;
        temperature++;
        return temperature;
    }
}