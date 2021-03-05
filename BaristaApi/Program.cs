using System;
using System.Collections.Generic;

namespace BaristaApi
{
    


    class Program
    {
        static void Main(string[] args)
        {

            GetMyCustomDrink();         
            

        }
 
        
        //public static void GetMeOneAmericano()
        //{
        //    var latte = new CoffeeMachine("Americano")
        //                    .addWater(60)
        //                    .addBeans(22, Bean.BeanTypes.Gimoka)
        //                    .makeADrink();

            
        //}


        //public static void GetMeOneEspresso()
        //{
        //    var espresso = new CoffeeMachine("Espresso")
        //                    .addWater(20)
        //                    .addBeans(5, Bean.BeanTypes.Lavazza)
        //                    .addMilk(1)
        //                    .makeADrink();




        //}
        

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


