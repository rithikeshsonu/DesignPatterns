using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Behavioral.Observer
{
    public class User(string userName) : IObserver
    {
        private string _userName = userName ;

        public void Update(string news)
        {
            Console.WriteLine($"User {_userName} has received the news: {news}");
        }
    }
}
