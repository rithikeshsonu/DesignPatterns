using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.SOLIDPrinciples.LiskovSubstitution
{
    internal class Rectangle : Shape
    {
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }
        public override double Area => Height * Width;
    }
}
