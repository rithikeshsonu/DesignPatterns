using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.FactoryMethod
{
    internal class GooglePayPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Google pay payment done for {amount}");
        }
    }
}
