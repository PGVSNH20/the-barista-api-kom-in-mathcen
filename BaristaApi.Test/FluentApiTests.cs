using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Latte()
        {
            var beverage = new CoffeeMachine("water").makeADrink();
          
            Assert.IsType<Latte>(beverage);
        }
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso()
        {
            var beverage = new CoffeeMachine("water").makeADrink();
        
            Assert.IsType<Espresso>(beverage);
        }
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Americano()
        {
            var beverage = new CoffeeMachine("").makeADrink();
            
            Assert.IsType<Americano>(beverage);
        }
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Mocha()
        {
            var beverage = new CoffeeMachine("").makeADrink();
            
            Assert.IsType<Mocha>(beverage);
        }
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Machiatto()
        {
            var beverage = new CoffeeMachine("").makeADrink();
           
            Assert.IsType<Machiatto>(beverage);
        }
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Cappuccino()
        {
            var beverage = new CoffeeMachine("").makeADrink();
           
            Assert.IsType<Cappuccino>(beverage);
        }
    }
}