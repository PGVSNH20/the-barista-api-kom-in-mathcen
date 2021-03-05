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
        //public int _milk;
       

        public CoffeeMachine(string name)
        {
            Ingredients = new List<Ingredient>();
            Beans = new List<Bean>();
            Name = name;
            
        }

        public ICoffeeMachine addBeans(int amount, Bean.BeanTypes bean)
        {
            Beans.Add(new Bean(bean) { beanType = bean, BeanAmount = amount });
            return this;
        }
        public ICoffeeMachine addWater(int amount)
        {
            Ingredients.Add(new Ingredient() { Type = "Vatten", WaterAmount = amount });
            return this;
        }
        public ICoffeeMachine addMilk(int amount)
        {
            Ingredients.Add(new Ingredient() { MilkAmount = amount, Type = "Mjölk" });
            return this;

        }
        public ICoffeeMachine addMilkFoam(int amount)
        {
            Ingredients.Add(new Ingredient() { MilkFoamAmount = amount });
            return this;
        }

        public ICoffeeMachine addChocolateSyrup(int amount)
        {
            Ingredients.Add(new Ingredient() { ChocolateSyrupAmount = amount });
            return this;
        }

        //public ICoffeeMachine addEspresso(int amount)
        //{
        //    Ingredients.Add(new Ingredient() { BeanAmount = amount });
        //    return this;
        //}





        public IBeverage makeADrink()
        {
            
            if (Ingredients.Any(a => a.MilkAmount > 0 && Beans.Any(b => b.BeanAmount > 0))) return new Latte();
            
            else
            {
                
                throw new Exception("FEL");
            }


            // if(ingrediens.contains 
            //if (Ingredients.Contains()) ;
            

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
