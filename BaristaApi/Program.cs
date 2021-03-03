using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var Espresso = new Espresso().addBeans().addWater().toFinalShot();
        }
    }
    class Espresso: IEspresso
    {
        public IEspresso addBeans()
        {
            throw new NotImplementedException();
        }

        public IEspresso addWater()
        {

        }

        public string toFinalShot()
        {
            throw new NotImplementedException();
        }
    }
    interface IEspresso
    {
        IEspresso addWater();
        IEspresso addBeans();

        string toFinalShot(); 
    }
}
