using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOPSPractice.Exercises
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public abstract decimal CalculateSalary();
        public void GetDetails() => Console.WriteLine($"Name: {Name}");
    }
    public class FullTimeEmployee : Employee
    {
        public decimal MonthlySalary { get; set; }
        public override decimal CalculateSalary() => MonthlySalary;
    }
    public class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public override decimal CalculateSalary() => HoursWorked * HourlyRate;
    }
}

