using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public class CoffeeMachine : ICoffeeMachine
    {
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; }
        public List<Bean> Beans { get; set; }

        public CoffeeMachine(string name)
        {
            Ingredients = new List<Ingredient>();
            Beans = new List<Bean>();
            Name = name;
            
        }

        public ICoffeeMachine addBeans(int amount, Bean.BeanTypes bean)
        {
            Beans.Add(new Bean(bean) { beanType = bean, Amount = amount });
            return this;
        }
        public ICoffeeMachine addWater(int amount)
        {
            Ingredients.Add(new Ingredient() { Type = "Vatten", Amount = amount });
            return this;
        }
        public ICoffeeMachine addMilk(int amount)
        {
            Ingredients.Add(new Ingredient() { Amount = amount, Type = "Mjölk" });
            return this;

        }
        public ICoffeeMachine addMilkFoam(int amount)
        {
            Ingredients.Add(new Ingredient() { Amount = amount });
            return this;
        }

        public ICoffeeMachine addEspresso(int amount)
        {
            Ingredients.Add(new Ingredient() { Amount = amount });
            return this;
        }





        public IBeverage makeADrink()
        {

           // if (Ingredients.Contains
                { return new Espresso(); }
                    // if(ingrediens.contains 

                    

            /*
            Console.WriteLine();
            Console.WriteLine($"En {Name} som innehåller:");

            foreach (var drink in Ingredients)
            {

                Console.WriteLine(drink.Amount + "%" + " " + drink.Type);

            }
            foreach (var bean in Beans)
            {
                Console.WriteLine(bean.Amount + "%" + " " + bean.beanType);
            }

            return this;
            */




        }

        
    }
}
