using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso(){
            //Pseudo code
            
            // Act
            var beverage = new CoffeeMachine("Espresso").addWater(1).addBeans(50, Bean.BeanTypes.IcaBasic).makeADrink();
            // Assert
            Assert.IsType<Espresso>(beverage);
            
        }
    }
}