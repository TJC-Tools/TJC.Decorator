using TJC.Decorator.Interfaces;
using TJC.Decorator.Tests.DrinkExample.Interfaces;

namespace TJC.Decorator.Tests;


public class DecoratorBaseClassTests
{
    [Fact]
    public void GetAs_ResolvesDecoratorInterfaceAndDelegatesToDecoratable()
    {
        IDrink drink = new Coffee();
        IDecoratable decorator = new Milk(drink);

        Assert.NotNull(decorator.GetAs<IDrink>());
        Assert.NotNull(decorator.GetAs<Milk>());
        Assert.Null(decorator.GetAs<Ice>());
        Assert.True(decorator.IsType<IDrink>());
        Assert.False(decorator.IsType<Ice>());
    }
}