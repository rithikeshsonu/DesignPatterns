using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.AbstractFactory
{
    //Concrete Product A2
    internal class Spanish : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine("Hola");
        }
    }
}
