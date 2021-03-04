using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso(){
            //Pseudo code
            
            // Act
            var beverage = new CoffeeMachine("Latte").addWater(50).addBeans(50, Bean.BeanTypes.DeLuxe).makeADrink();
            // Assert
            Assert.IsType<Espresso>(beverage);
            
        }
    }
}