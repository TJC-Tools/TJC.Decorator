using TJC.Decorator.Interfaces;
using TJC.Decorator.Tests.DrinkExample.Interfaces;

namespace TJC.Decorator.Tests;

[TestClass]
public class DecoratorBaseClassTests
{
    [TestMethod]
    public void GetAs_ResolvesDecoratorInterfaceAndDelegatesToDecoratable()
    {
        IDrink drink = new Coffee();
        IDecoratable decorator = new Milk(drink);

        Assert.IsNotNull(decorator.GetAs<IDrink>());
        Assert.IsNotNull(decorator.GetAs<Milk>());
        Assert.IsNull(decorator.GetAs<Ice>());
        Assert.IsTrue(decorator.IsType<IDrink>());
        Assert.IsFalse(decorator.IsType<Ice>());
    }
}
