using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.OOPPrinciples.Polymorphism
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public override void Start()
        {
            Console.WriteLine("Car is starting");
        }
        public override void Stop() 
        { 
            Console.WriteLine("Car is stopping.");
        }
    }
}
