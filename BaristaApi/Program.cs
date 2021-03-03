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
            


        }



        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public static void GetMeOneLatte()
        {
            var latte = new Latte()
                            .addWater()
                            .addBeans()
                            .makeADrink();

            
        }


        public static void GetMeOneEspresso()
        {
            var espresso = new Espresso()
                            .addWater()
                            .addBeans()
                            .makeADrink();


        }


    }

    

    


    
}
