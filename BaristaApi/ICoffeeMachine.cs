using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public interface ICoffeeMachine
    {

        ICoffeeMachine addWater(int amount);
        ICoffeeMachine addBeans(int amount, Bean.BeanTypes bean);
        ICoffeeMachine addMilk(int amount);
        ICoffeeMachine addMilkFoam(int amount);
        ICoffeeMachine addEspresso(int amount);
        // addChocolateSyrup(int amout);
        IBeverage makeADrink();

    }
}
