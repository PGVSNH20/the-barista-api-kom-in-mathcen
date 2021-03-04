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
        public List<Bean> Beans { get; set; }

        public CoffeeMachine(string name)
        {
            Ingredients = new List<Ingredient>();
            Beans = new List<Bean>();
            Name = name;
            
        }

        public IBeverage addBeans(int amount, Bean.BeanTypes bean)
        {
            Beans.Add(new Bean(bean) { beanType = bean, Amount = amount });
            return this;
        }
        public IBeverage addWater(int amount)
        {
            Ingredients.Add(new Ingredient() { Type = "Vatten", Amount = amount });
            return this;
        }
        public IBeverage addMilk(int amount)
        {
            Ingredients.Add(new Ingredient() { Amount = amount, Type = "Mjölk" });
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
            foreach (var bean in Beans)
            {
                Console.WriteLine(bean.Amount + "%" + " " + bean.beanType);
            }

            return this;
        }

        
    }
}
