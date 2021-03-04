using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    class Latte:IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; } = "Latte";
        public static string[] BeanSelection { get; set; }


        public Latte()
        {
            Ingredients = new List<Ingredient>();
            BeanSelection = new string[] { "Arabica", "Robusta", "Uppsala" };
        }
        


    public IBeverage addWater(int amount)
        {
            Ingredients.Add(new Ingredient() { Type = "Vatten", Amount = amount });
            return this;
        }


        public IBeverage addBeans(int amount, string type)
        {
            Ingredients.Add(new Ingredient() { Amount = 12, Type = type });
            return this;
        }

        public IBeverage addMilk(int amount)
        {
            Ingredients.Add(new Ingredient() { Amount = 2, Type = "Milk" });
            return this;

        }


        public IBeverage makeADrink()


        {

            Console.WriteLine();
            Console.WriteLine($"En {Name} som innehåller:");
            foreach (var drink in Ingredients)
            {
                Console.WriteLine(drink.Amount + "%" + " " + drink.Type);
                    
               

                
            }

            return this;


        }

        


    }
}
