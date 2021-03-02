using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var Espresso = new Espresso().toFinalShot();
        }
    }
    class Espresso: IEspresso
    {
        public void addBeans()
        {
            throw new NotImplementedException();
        }

        public void addWater()
        {

        }

        public string toFinalShot()
        {
            throw new NotImplementedException();
        }
    }
    interface IEspresso
    {
        void addWater();
        void addBeans();

        string toFinalShot(); 
    }
}
