﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.FactoryMethod
{
    internal class PayPalPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paypal payment done for {amount}");
        }
    }
}
