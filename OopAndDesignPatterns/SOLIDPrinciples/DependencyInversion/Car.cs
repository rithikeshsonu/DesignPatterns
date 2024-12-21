using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.SOLIDPrinciples.DependencyInversion
{
    internal class Car(IEngine engine)
    {
        internal IEngine _iengine = engine;

        public void StartCar()
        {
            _iengine.Start();
            Console.WriteLine("Car started");
        }
    }
}
