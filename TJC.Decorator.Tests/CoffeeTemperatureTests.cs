namespace TJC.Decorator.Tests
{
    
    public class CoffeeTemperatureTests
    {
        [Fact]
        public void BlackCoffee_IsHot()
        {
            var coffee = new Coffee();
            Assert.Equal(DrinkTemperature.Hot, coffee.Temperature);
        }

        [Fact]
        public void CoffeeWithMilk_IsWarm()
        {
            IDrink coffee = new Coffee();
            coffee = new Milk(coffee);
            Assert.True(
                DrinkTemperature.Warm == coffee.Temperature,
                "Coffee with milk should be warm"
            );
        }

        [Fact]
        public void CoffeeWithIce_IsMild()
        {
            IDrink coffee = new Coffee();
            coffee = new Ice(coffee);
            Assert.True(
                DrinkTemperature.Mild == coffee.Temperature,
                "Coffee with ice should be mild"
            );
        }

        [Fact]
        public void CoffeeWithMilkAndIce_IsCool()
        {
            IDrink coffee = new Coffee();
            coffee = new Milk(coffee);
            coffee = new Ice(coffee);
            Assert.True(
                DrinkTemperature.Cool == coffee.Temperature,
                "Coffee with milk & ice should be cool"
            );
        }

        [Fact]
        public void CoffeeWithMilkAndTwoIce_IsFreezing()
        {
            IDrink coffee = new Coffee();
            coffee = new Milk(coffee);
            coffee = new Ice(coffee);
            coffee = new Ice(coffee);
            Assert.True(
                DrinkTemperature.Freezing == coffee.Temperature,
                "Coffee with milk & two ice should be freezing"
            );
        }
    }
}
