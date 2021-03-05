using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Latte()
        {

            var beverage = new CoffeeMachine("")
                .addWater(0)
                .addBeans(30, Bean.BeanTypes.IcaBasic)
                .addMilk(70)
                .addMilkFoam(0)
                .makeADrink();



            Assert.IsType<Latte>(beverage);
        }
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso()
        {

            var beverage = new CoffeeMachine("")
                .addWater(0)
                .addBeans(30, Bean.BeanTypes.IcaBasic)
                .addMilk(0)
                .addMilkFoam(0)
                .makeADrink();




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
            var beverage = new CoffeeMachine("")
                .addWater(0)
                .addBeans(30, Bean.BeanTypes.IcaBasic)
                .addMilk(0)
                .addMilkFoam(20)
                .makeADrink();

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