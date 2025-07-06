using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOPSPractice.Exercises
{
    public class Shape
    {
        public virtual void Draw() => Console.WriteLine("Drawing Shape");
    }
    public class Circle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing Circle");
    }
    public class Rectangle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing Rectangle");
    }
    public class Triangle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing Triangle");
    }
}
