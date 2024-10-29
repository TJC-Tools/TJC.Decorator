namespace TJC.Decorator.Tests.DrinkExample.Interfaces;

public interface IDrink : IDecoratable
{
    DrinkTemperature Temperature { get; set; }
}
