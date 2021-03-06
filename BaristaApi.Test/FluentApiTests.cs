using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests
    {
        [Fact]
        public void What_To_Expect_Latte()
        {
            var beverage = new CoffeeMachine()
                .AddWater(5)
                .AddBeans(20, Bean.BeanTypes.Lavazza)
                .AddMilk(70)
                .MakeADrink();
            Assert.IsType<Latte>(beverage);
        }
        [Fact]
        public void What_To_Expect_Espresso()
        {
            var beverage = new CoffeeMachine()
                .AddWater(20)
                .AddBeans(60, Bean.BeanTypes.Lavazza)
                .MakeADrink();
            Assert.IsType<Espresso>(beverage);
        }
        [Fact]
        public void What_To_Expect_Americano()
        {
            var beverage = new CoffeeMachine()
                .AddWater(50)
                .AddBeans(50, Bean.BeanTypes.Rozza)
                .AddEspresso(1)
                .MakeADrink();
            Assert.IsType<Americano>(beverage);
        }
        [Fact]
        public void What_To_Expect_Mocha()
        {
            var beverage = new CoffeeMachine()
                .AddWater(5)
                .AddBeans(25, Bean.BeanTypes.Rozza)
                .AddMilk(20)
                .AddChocolateSyrup(15)
                .MakeADrink();                
            Assert.IsType<Mocha>(beverage);
        }
        [Fact]
        public void What_To_Expect_Machiatto()
        {
            var beverage = new CoffeeMachine()
                .AddWater(5)
                .AddBeans(40, Bean.BeanTypes.Rozza)
                .AddMilkFoam(32)
                .MakeADrink();
            Assert.IsType<Machiatto>(beverage);
        }
        [Fact]
        public void What_To_Expect_Cappuccino()
        {
            var beverage = new CoffeeMachine()
                .AddWater(5)
                .AddBeans(20, Bean.BeanTypes.Gimoka)
                .AddMilk(25)
                .AddMilkFoam(35)
                .MakeADrink();
            Assert.IsType<Cappuccino>(beverage);
        }

        [Fact]
        public void What_To_Expect_CustomCoffee()
        {
            var beverage = new CoffeeMachine()
                .AddWater(5)
                .AddBeans(20, Bean.BeanTypes.Gimoka)
                .AddMilk(25)
                .AddMilkFoam(99)
                .MakeADrink();
           
            Assert.IsType<CustomCoffee>(beverage);
        }
    }
}