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
       
       

        public CoffeeMachine()
        {
            Ingredients = new List<Ingredient>();
            Beans = new List<Bean>();
            
            
        }

        public ICoffeeMachine AddBeans(int amount, Bean.BeanTypes bean)
        {
            Beans.Add(new Bean(bean) { beanType = bean, BeanAmount = amount });
            return this;
        }
        public ICoffeeMachine AddWater(int amount)
        {
            Ingredients.Add(new Ingredient() { WaterAmount = amount });
            return this;
        }
        public ICoffeeMachine AddMilk(int amount)
        {
            Ingredients.Add(new Ingredient() { MilkAmount = amount});
            return this;

        }
        public ICoffeeMachine AddEspresso(int amount)
        {
            Ingredients.Add(new Ingredient() { EspressoAmount = amount });
            return this;
        }
        public ICoffeeMachine AddMilkFoam(int amount)
        {
            Ingredients.Add(new Ingredient() { MilkFoamAmount = amount });
            return this;
        }

        public ICoffeeMachine AddChocolateSyrup(int amount)
        {
            Ingredients.Add(new Ingredient() { ChocolateSyrupAmount = amount });
            return this;
        }



        public IBeverage MakeADrink()
        {
            if(Beans.Any(b => b.BeanAmount > 0))
            {
                if (Ingredients.Any(a => a.MilkAmount == 70 && Beans.Any(b => b.BeanAmount == 20)))
                    return new Latte();

                if (Ingredients.Any(a => a.WaterAmount == 20 && Beans.Any(b => b.BeanAmount == 60)))
                    return new Espresso();

                if (Ingredients.Any(a => a.WaterAmount == 50 && Beans.Any(b => b.BeanAmount == 50)
                    && Ingredients.Any(e => e.EspressoAmount == 1)))
                    return new Americano();

                if (Ingredients.Any(a => a.MilkAmount == 20 && Beans.Any(b => b.BeanAmount == 25)
                    && Ingredients.Any(e => e.ChocolateSyrupAmount == 15 && (Ingredients.Any(d => d.WaterAmount == 5)))))
                    return new Mocha();

                if (Ingredients.Any(a => a.MilkFoamAmount == 32 && Beans.Any(b => b.BeanAmount == 40 &&
                   (Ingredients.Any(d => d.WaterAmount == 5)))))
                    return new Machiatto();

                if (Ingredients.Any(a => a.MilkFoamAmount == 35 && Beans.Any(b => b.BeanAmount == 20)
                    && Ingredients.Any(e => e.MilkAmount == 25 && (Ingredients.Any(d => d.WaterAmount == 5)))))
                    return new Cappuccino();

                else 
                {
                    return new CustomCoffee();
                }



            }

            

            


            else
            {

                throw new Exception("Kontrollera maskin, fyll på vid behov. Service Tel: 031-17KAFF3TRA51G");
            }

        }
        
    }
}
