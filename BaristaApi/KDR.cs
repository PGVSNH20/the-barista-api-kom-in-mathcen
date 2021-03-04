using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public class Custom : IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; }
        public List<Bean> Beans { get; set; }

        public Custom()
        {
            Ingredients = new List<Ingredient>();
            Beans = new List<Bean>();
            
        }

        public IBeverage addBeans(Bean.BeanTypes bean, int amount)
        {
            //Beans.Add(bean);
            Beans.Add(new Bean(bean) { beanType = bean, Amount = amount });
            return this;
        }
        public IBeverage addWater(int amount)
        {
            Ingredients.Add(new Ingredient() { Type = "Water", Amount = amount });
            return this;
        }
        public IBeverage addMilk(int amount)
        {
            Ingredients.Add(new Ingredient() { Amount = amount, Type = "Milk" });
            return this;

        }

        public IBeverage makeADrink()
        {
            Console.WriteLine();
            Console.WriteLine($"En {Name} som innehåller:");

            foreach (var drink in Ingredients)
            {

                Console.WriteLine(drink.Amount + "%" + " " + drink.Type);

                foreach(var bean in Beans)
                {
                    Console.WriteLine(bean.beanType);
                }

            }

            return this;
        }

        public IBeverage addMilkFoam(int amount)
        {
            throw new NotImplementedException();
        }

        public IBeverage addEspresso(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
