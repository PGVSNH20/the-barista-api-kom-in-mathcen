﻿using System;
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
        public List<Bean> Beans { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Espresso()
        {
            Ingredients = new List<Ingredient>();
        }

        public IBeverage addBeans(int amount, string type)
        {
            Ingredients.Add(new Ingredient() { Type = "Espresso", Amount = 60 });
            return this;
        }

        public IBeverage addWater(int amount)
        {
            Ingredients.Add(new Ingredient() { Amount = 40, Type = "Vatten" });
            return this;
        }

        public IBeverage addMilk(int amount)
        {
            Ingredients.Add(new Ingredient() { Amount = 40, Type = "Milk" });
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

        public IBeverage addBeans(Bean bean)
        {
            throw new NotImplementedException();
        }

        public IBeverage addBeans(Bean.BeanTypes bean)
        {
            throw new NotImplementedException();
        }
    }
}
