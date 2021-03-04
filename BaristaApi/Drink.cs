using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    class Drink 

    {
        public List<Ingredient> Ingredients { get; set; }

        public string CupType => throw new NotImplementedException();

        

        public Drink()
        {

            Ingredients = new List<Ingredient>();

        }




    }


    



}
