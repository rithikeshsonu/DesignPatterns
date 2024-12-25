using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.Singleton
{
    internal class Test
    {
        public static void Run()
        {
            var settings = AppSettings.GetInstance();
            Console.WriteLine(settings.Get("app_creator"));
        }
    }
}
