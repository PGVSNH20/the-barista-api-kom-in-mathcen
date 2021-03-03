using BaristaApi;
using System.Collections.Generic;

public interface IBeverage{
	List<Ingredient> Ingredients { get; set; }
    string Name { get; set; }
    IBeverage addWater();
    IBeverage addBeans();
    IBeverage makeADrink();

}

