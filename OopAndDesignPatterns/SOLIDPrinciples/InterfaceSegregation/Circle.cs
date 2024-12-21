using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.SOLIDPrinciples.InterfaceSegregation
{
    internal class Circle : IShape2D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
