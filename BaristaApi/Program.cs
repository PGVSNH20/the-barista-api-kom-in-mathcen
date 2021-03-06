using System;

namespace BaristaApi
{



    class Program
    {
        static void Main(string[] args)

        {
            
            IBeverage beverage1 = new CoffeeMachine()
                .AddWater(50)
                .AddBeans(50, Bean.BeanTypes.Rozza)
                .AddEspresso(1)
                .MakeADrink();
            Console.WriteLine($" Your {beverage1.GetType().Name} is ready, enjoy!");

            IBeverage beverage2 = new CoffeeMachine()
                .AddWater(5)
                .AddBeans(20, Bean.BeanTypes.Gimoka)
                .AddMilk(25)
                .AddMilkFoam(35)
                .MakeADrink();
            Console.WriteLine($" Your {beverage2.GetType().Name} is ready, enjoy!");

            IBeverage beverage3 = new CoffeeMachine()
                .AddWater(5)
                .AddBeans(40, Bean.BeanTypes.Rozza)
                .AddMilkFoam(32)
                .MakeADrink();
            Console.WriteLine($" Your {beverage3.GetType().Name} is ready, enjoy!");

            IBeverage beverage4 = new CoffeeMachine()
                .AddWater(5)
                .AddBeans(25, Bean.BeanTypes.Rozza)
                .AddMilk(20)
                .AddChocolateSyrup(15)
                .MakeADrink();
            Console.WriteLine($" Your {beverage4.GetType().Name} is ready, enjoy!");

            IBeverage beverage5 = new CoffeeMachine()
                .AddWater(20)
                .AddBeans(60, Bean.BeanTypes.Lavazza)
                .MakeADrink();
            Console.WriteLine($" Your {beverage5.GetType().Name} is ready, enjoy!");

            IBeverage beverage6 = new CoffeeMachine()
                .AddWater(5)
                .AddBeans(20, Bean.BeanTypes.Lavazza)
                .AddMilk(70)
                .MakeADrink();
            Console.WriteLine($" Your {beverage6.GetType().Name} is ready, enjoy!");

            IBeverage beverage7 = new CoffeeMachine()
                .AddWater(1)
                .AddBeans(5, Bean.BeanTypes.IcaBasic)
                .AddMilkFoam(1)
                .AddChocolateSyrup(1)
                .MakeADrink();
            Console.WriteLine($" Your '{beverage7.GetType().Name}' is ready, enjoy!");

        }

    }







}
