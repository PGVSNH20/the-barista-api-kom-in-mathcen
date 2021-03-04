using System;
using System.Collections.Generic;

namespace BaristaApi
{
    


    class Program
    {
        static void Main(string[] args)
        {
            GetMeOneAmericano(); 

            GetMeOneEspresso();

            GetMyCustomDrink();         
            

        }
 
        
        public static void GetMeOneAmericano()
        {
            var latte = new CoffeeMachine("Americano")
                            .addWater(60)
                            .addBeans(22, Bean.BeanTypes.Gimoka)
                            .makeADrink();

            
        }


        public static void GetMeOneEspresso()
        {
            var espresso = new CoffeeMachine("Espresso")
                            .addWater(20)
                            .addBeans(5, Bean.BeanTypes.Lavazza)
                            .addMilk(1)
                            .makeADrink();




        }
        

        public static void GetMyCustomDrink()
        {
            var custom = new CoffeeMachine("Latte")
                .addWater(90)
                .addBeans(50, Bean.BeanTypes.IcaBasic)
                .addMilk(1)
                .makeADrink();
        }


    }  
}
