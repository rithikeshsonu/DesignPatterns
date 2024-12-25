using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.AbstractFactory
{
    //Abstract Factory
    internal interface IInternationalFactory
    {
        ILanguage CreateLanguage();
        ICapitalCity CreateCapital();
    }
}
