namespace TJC.Decorator.Tests
{
    [TestClass]
    public class CoffeeTemperatureTests
    {
        [TestMethod]
        public void BlackCoffee_IsHot()
        {
            var coffee = new Coffee();
            Assert.AreEqual(DrinkTemperature.Hot, coffee.Temperature, "Black coffee should be hot");
        }

        [TestMethod]
        public void CoffeeWithMilk_IsWarm()
        {
            IDrink coffee = new Coffee();
            coffee = new Milk(coffee);
            Assert.AreEqual(DrinkTemperature.Warm, coffee.Temperature, "Coffee with milk should be warm");
        }

        [TestMethod]
        public void CoffeeWithIce_IsMild()
        {
            IDrink coffee = new Coffee();
            coffee = new Ice(coffee);
            Assert.AreEqual(DrinkTemperature.Mild, coffee.Temperature, "Coffee with ice should be mild");
        }

        [TestMethod]
        public void CoffeeWithMilkAndIce_IsCool()
        {
            IDrink coffee = new Coffee();
            coffee = new Milk(coffee);
            coffee = new Ice(coffee);
            Assert.AreEqual(DrinkTemperature.Cool, coffee.Temperature, "Coffee with milk & ice should be cool");
        }

        [TestMethod]
        public void CoffeeWithMilkAndTwoIce_IsFreezing()
        {
            IDrink coffee = new Coffee();
            coffee = new Milk(coffee);
            coffee = new Ice(coffee);
            coffee = new Ice(coffee);
            Assert.AreEqual(DrinkTemperature.Freezing, coffee.Temperature, "Coffee with milk & two ice should be freezing");
        }
    }
}