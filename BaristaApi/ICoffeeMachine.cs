using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public interface ICoffeeMachine
    {

        ICoffeeMachine AddWater(int amount);
        ICoffeeMachine AddBeans(int amount, Bean.BeanTypes bean);
        ICoffeeMachine AddMilk(int amount);
        ICoffeeMachine AddMilkFoam(int amount);
        ICoffeeMachine AddEspresso(int amount);
        ICoffeeMachine AddChocolateSyrup(int amout);
        IBeverage MakeADrink();

    }
}
