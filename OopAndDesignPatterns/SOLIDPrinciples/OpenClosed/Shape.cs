using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.SOLIDPrinciples.OpenClosed
{
    public class Shape
    {
        public ShapeType ShapeType { get; set; }
        public double Radius { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double CalculateArea()
        {
            switch(ShapeType)
            {
                case ShapeType.Circle: 
                    return Math.PI * Math.Pow(Radius, 2);
                case ShapeType.Rectangle:
                    return Length * Width;
                default:
                    throw new NotSupportedException("Unsupported shape");
            }
        }
    }
}
