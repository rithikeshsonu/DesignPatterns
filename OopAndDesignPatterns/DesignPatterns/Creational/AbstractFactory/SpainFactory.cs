using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.AbstractFactory
{
    //Concrete Factory 2
    internal class SpainFactory : IInternationalFactory
    {
        public ICapitalCity CreateCapital()
        {
            return new Madrid();
        }

        public ILanguage CreateLanguage()
        {
            return new Spanish();
        }
    }
}
