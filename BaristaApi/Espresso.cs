using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    class Espresso : IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; } = "Espresso";



        public Espresso()
        {
            Ingredients = new List<Ingredient>();
        }



        public IBeverage addBeans()
        {
            Ingredients.Add(new Ingredient() { Type = "Espresso", Amount = 60 });
            return this;
        }

        public IBeverage addWater()
        {
            Ingredients.Add(new Ingredient() { Amount = 40, Type = "Vatten" });
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
