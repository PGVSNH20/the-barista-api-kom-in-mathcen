using System;
using System.Collections.Generic;

namespace BaristaApi
{
    


    class Program
    {
        static void Main(string[] args)
        {
            //GetMeOneLatte(); 

            //GetMeOneEspresso();

            GetMyCustomDrink();         
            

        }



        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /*
        public static void GetMeOneLatte()
        {
            var latte = new Latte()
                            .addWater(60)
                            .addBeans(22, "")
                            .makeADrink();

            
        }


        public static void GetMeOneEspresso()
        {
            var espresso = new Espresso()
                            .addWater(20)
                            .addBeans(31, "")
                            .addMilk(1)
                            .makeADrink();


        }
        */

        public static void GetMyCustomDrink()
        {
            var latte = new CoffeeMachine("Latte")
                .addWater(0)
                .addBeans(30, Bean.BeanTypes.IcaBasic)
                .addMilk(70)
                .makeADrink();



            var espresso = new CoffeeMachine("Espresso")
                .addWater(0)
                .addBeans(30, Bean.BeanTypes.IcaBasic)
                .addMilk(0)
                .makeADrink();


        }





    }

    

    


    
}
