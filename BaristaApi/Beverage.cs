using BaristaApi;
using System.Collections.Generic;

public interface IBeverage{
	List<Ingredient> Ingredients { get; set; }
    List<Bean> Beans { get; set; }
    string Name { get; set; }
    IBeverage addWater(int amount);
    IBeverage addBeans(Bean.BeanTypes bean, int amount);
    IBeverage addMilk(int amount);
    IBeverage addMilkFoam(int amount);
    IBeverage addEspresso(int amount);
    IBeverage makeADrink();
   
}

