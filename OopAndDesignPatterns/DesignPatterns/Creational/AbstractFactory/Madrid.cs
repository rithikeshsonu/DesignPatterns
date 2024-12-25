using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.AbstractFactory
{
    //Concrete Product B2
    internal class Madrid : ICapitalCity
    {
        public int GetPopulation()
        {
            return 120000;
        }

        public List<string> ListTopAttractions()
        {
            return new List<string> { "Royal Palace", "Prado Museum"};
        }
    }
}
