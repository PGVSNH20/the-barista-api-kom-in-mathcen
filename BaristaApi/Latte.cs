using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public class Latte:IBeverage
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Bean> Beans { get; set; }
        public string Name { get; set; }

    }
}
