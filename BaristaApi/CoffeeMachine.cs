using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public class CoffeeMachine : IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; }

        public CoffeeMachine(string value)
        {
            Ingredients = new List<Ingredient>();
            
            Name = value;

                                    
        }


        public IBeverage addBeans(int amount, string type)
        {
            Ingredients.Add(new Ingredient() { Type = type, Amount = amount });
            return this;
        }
        public IBeverage addWater(int amount)
        {
            Ingredients.Add(new Ingredient() { Type = "Water", Amount = amount });
            return this;
        }
        public IBeverage addMilk(int amount)
        {
            Ingredients.Add(new Ingredient() { Type = "Milk", Amount = amount  });
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
