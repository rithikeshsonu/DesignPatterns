using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOPSPractice.Exercises
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public double Add(double a, double b) => a + b;
    }
    public class Logger
    {
        public virtual void Log() => Console.WriteLine("Log to console");
    }
    public class FileLogger : Logger
    {
        public override void Log() => Console.WriteLine("Log to File");
    }
}
