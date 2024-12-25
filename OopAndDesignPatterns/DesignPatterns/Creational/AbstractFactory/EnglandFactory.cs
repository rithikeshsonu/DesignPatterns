using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.AbstractFactory
{
    //Concrete Factory 1
    internal class EnglandFactory : IInternationalFactory
    {
        public ICapitalCity CreateCapital()
        {
            return new London();
        }

        public ILanguage CreateLanguage()
        {
            return new English();
        }
    }
}
