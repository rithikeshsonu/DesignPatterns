using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.AbstractFactory
{
    //Abstract Product B
    internal interface ICapitalCity
    {
        int GetPopulation();
        List<string> ListTopAttractions();
    }
}
