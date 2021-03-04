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

            GetMyCustomDrink();         
            

        }



        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
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

        public static void GetMyCustomDrink()
        {
            var custom = new Custom().addWater(90).addBeans(7, "customBean").makeADrink();
        }


    }

    

    


    
}
