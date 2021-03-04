using BaristaApi;
using System.Collections.Generic;

public interface IBeverage{
	List<Ingredient> Ingredients { get; set; }
    List<Bean> Beans { get; set; }
    string Name { get; set; }
   
   
}

