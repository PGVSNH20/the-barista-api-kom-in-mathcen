using System.Collections.Generic;


namespace BaristaApi
{
    public class Latte : IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Bean> Beans { get; set; }
        public string Name { get; set; }

    }

    public class Espresso : IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Bean> Beans { get; set; }
        public string Name { get; set; }
    }
    public class Cappuccino : IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Bean> Beans { get; set; }
        public string Name { get; set; }
    }
    public class Machiatto : IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Bean> Beans { get; set; }
        public string Name { get; set; }
    }
    public class Mocha : IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Bean> Beans { get; set; }
        public string Name { get; set; }
    }
    public class Americano : IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Bean> Beans { get; set; }
        public string Name { get; set; }
    }

    public class CustomCoffee : IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Bean> Beans { get; set; }
        public string Name { get; set; }
    }
}



