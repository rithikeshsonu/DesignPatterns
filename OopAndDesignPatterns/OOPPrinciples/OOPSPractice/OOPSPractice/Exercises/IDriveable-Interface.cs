using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice.Exercises
{
    public interface IDriveable
    {
        void Start();
        void Stop();
    }
    public class Car : IDriveable
    {
        public void Start() => Console.WriteLine("Car started");
        public void Stop() => Console.WriteLine("Car stopped");
    }
    public class Bike: IDriveable
    {
        public void Start() => Console.WriteLine("Bike started");
        public void Stop() => Console.WriteLine("Bike stopped");
    }
}
