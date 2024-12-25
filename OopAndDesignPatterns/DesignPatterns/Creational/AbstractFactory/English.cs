using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.AbstractFactory
{
    //Concrete Product A1
    internal class English : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
}
