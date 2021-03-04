using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    class Cappuccino : IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; } = "Cappuccino";

        public Cappuccino()
        {      
            Ingredients = new List<Ingredient>();     
        }



        public IBeverage addBeans(int amount, string type)
        {
            throw new NotImplementedException();
        }

        public IBeverage addMilk(int amount)
        {
            Ingredients.Add(new Ingredient() { Type = "Hot milk", Amount = 33 });
            return this;
        }


        public IBeverage addWater(int amount)
        {
            Ingredients.Add(new Ingredient() { Type = "Vatten", Amount = amount });
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

        public IBeverage addMilkFoam(int amount)
        {
            Ingredients.Add(new Ingredient() { Type = "Milk foam", Amount = 33 });
            return this;
        }

        public IBeverage addEspresso(int amount)
        {
            Ingredients.Add(new Ingredient() { Type = "Espresso", Amount = 33 });
            return this;
        }
    }
}
