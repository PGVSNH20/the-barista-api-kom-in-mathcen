using System;
using System.Collections.Generic;

namespace BaristaApi
{



    class Program
    {
        static void Main(string[] args)
        {
            GetMeOneLatte();

            GetMeOneEspresso();

            GetMeOneLatte();

            GetMeOneMachiatto();

            GetMeOneMocha();

            GetMeOneAmericano();


        }

        public static void GetMeOneAmericano()
        {
            var latte = new CoffeeMachine("Americano")
                            .addWater(50)
                            .addBeans(50, Bean.BeanTypes.Rozza)
                            .makeADrink();


        }


        public static void GetMeOneEspresso()
        {
            var espresso = new CoffeeMachine("Espresso")
                            .addWater(20)
                            .addBeans(31, Bean.BeanTypes.Lavazza)
                            .addMilk(0)
                            .makeADrink();


        }


        public static void GetMeOneLatte()
        {
            var custom = new CoffeeMachine("Latte")
                .addWater(45)
                .addBeans(50, Bean.BeanTypes.IcaBasic)
                .addMilk(1)
                .makeADrink();
        }

        public static void GetMeOneMachiatto()
        {
            var custom = new CoffeeMachine("Machiatto")
                .addWater(67)
                .addBeans(50, Bean.BeanTypes.Starbucks)
                .addMilk(1)
                .makeADrink();
        }

        public static void GetMeOneMocha()
        {
            var custom = new CoffeeMachine("Mocha")
                .addWater(67)
                .addBeans(50, Bean.BeanTypes.Starbucks)
                .addMilk(1)
                .makeADrink();
        }
        

    }    
}
