using BaristaApi;
using System.Collections.Generic;

public interface IBeverage{
	List<Ingredient> Ingredients { get; set; }
    string Name { get; set; }
    IBeverage addWater(int amount);
    IBeverage addBeans(int amount, string type);
    IBeverage addMilk(int amount);
    IBeverage makeADrink();

}

