using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso(){
            //Pseudo code

            // Act
            var beverage = new CoffeeMachine("water").makeADrink();//.AddWater(1).AddBeans().ToBeverage();
            // Assert
            Assert.IsType<Latte>(beverage);
            
        }
    }
}