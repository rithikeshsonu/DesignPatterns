using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.AbstractFactory
{
    //Concrete Product B1
    internal class London : ICapitalCity
    {
        public int GetPopulation()
        {
            return 890000;
        }

        public List<string> ListTopAttractions()
        {
            return new List<string> { "Tower Bridge", "Buckingham Palace", "Big Ben" };
        }
    }
}
